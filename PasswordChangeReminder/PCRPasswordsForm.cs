﻿using KeePass;
using KeePass.Forms;
using KeePass.Plugins;
using KeePass.UI;
using KeePassLib;
using KeePassLib.Collections;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChangeReminder
{
    public partial class PCRPasswordsForm : Form
    {
        private PwObjectList<PwEntry> pwObjectList = null;
        private PwDatabase pdb = null;
        private ImageList il_icons = null;
        private PCRConfig m_config = null;
        private IPluginHost m_host = null;

        public PCRPasswordsForm(IPluginHost m_host)
        {
            InitializeComponent();
            this.m_host = m_host;

            buildListView();
        }

        public void InitEx(PwObjectList<PwEntry> pwObjectList, PwDatabase pdb, ImageList il_icons, PCRConfig m_config)
        {
            this.il_icons = il_icons;
            this.pdb = pdb;
            this.m_config = m_config;
            this.pwObjectList = pwObjectList;

            if (m_config != null)
            {
                this.Height = m_config.pcrPasswordsFormHeight;
            }

            lvExpiringPasswords.SmallImageList = il_icons;

            populateExpiringEntries(pwObjectList);
        }

        private void PCR_Form_Load(object sender, EventArgs e)
        {
            if (m_host != null)
            {
                this.Left = m_host.MainWindow.Left + 20;
                this.Top = m_host.MainWindow.Top + 20;
            }
        }

        private void buildListView()
        {
            lvExpiringPasswords.Columns.Add(Properties.strings.pcr_form_lv_name, 120);
            lvExpiringPasswords.Columns.Add(Properties.strings.pcr_form_lv_nextchangein, 90, HorizontalAlignment.Right);
            lvExpiringPasswords.Columns.Add(Properties.strings.pcr_form_lv_age, 90, HorizontalAlignment.Right);
            lvExpiringPasswords.Columns.Add(Properties.strings.pcr_form_lv_remindevery, 90, HorizontalAlignment.Right);

            ListSorter lsListSorter = new ListSorter(1, SortOrder.Ascending, true, false);
            lvExpiringPasswords.ListViewItemSorter = lsListSorter;

            ListViewGroup lvgListViewGroup = new ListViewGroup(Properties.strings.pcr_today);
            lvExpiringPasswords.Groups.Add(lvgListViewGroup);
            lvgListViewGroup = new ListViewGroup(Properties.strings.pcr_soon);
            lvExpiringPasswords.Groups.Add(lvgListViewGroup);
        }


        private void populateExpiringEntries(PwObjectList<PwEntry> pwObjectList)
        {
            if (pwObjectList.Count() > 0)
                foreach (PwEntry pe in pwObjectList)
                {
                    if (pe.Strings.Exists(PasswordChangeReminderExt._EntryStringKey))
                    {
                        PwListItem pli = new PwListItem(pe);
                        int iRemindIn = Convert.ToInt32(pe.Strings.Get(PasswordChangeReminderExt._EntryStringKey).ReadString().ToString());
                        int iPwAge = Tools.calculateAge(pe);
                        int iChangeIn = iRemindIn - iPwAge;

                        ListViewItem lvi = lvExpiringPasswords.Items.Add(pe.Strings.ReadSafe(PwDefs.TitleField));
                        lvi.UseItemStyleForSubItems = false;

                        if (iChangeIn > m_config.pcrPasswordsFormTentativeState)
                        {
                            lvi.SubItems.Add(iChangeIn + " " + Properties.strings.pcr_days).BackColor = m_config.pcrPasswordsFormGreatColor;
                            lvi.Group = lvExpiringPasswords.Groups[1];
                            lvi.BackColor = m_config.pcrPasswordsFormGreatColor;
                        }
                        else if (iChangeIn > m_config.pcrPasswordsFormCriticalState)
                        {
                            lvi.SubItems.Add(iChangeIn + " " + Properties.strings.pcr_days).BackColor = m_config.pcrPasswordsFormTentativeColor;
                            lvi.Group = lvExpiringPasswords.Groups[1];
                            lvi.BackColor = m_config.pcrPasswordsFormTentativeColor;
                            lvExpiringPasswords.ShowGroups = true;
                        }
                        else
                        {
                            lvi.SubItems.Add(Properties.strings.pcr_today + " (" + iChangeIn + Properties.strings.pcr_days + ")").BackColor = m_config.pcrPasswordsFormCriticalColor;
                            lvi.Group = lvExpiringPasswords.Groups[0];
                            lvi.BackColor = m_config.pcrPasswordsFormCriticalColor;
                            lvExpiringPasswords.ShowGroups = true;
                        }

                        lvi.SubItems.Add(iPwAge + " " + Properties.strings.pcr_days).BackColor = Color.LightGray;
                        lvi.SubItems.Add(iRemindIn + " " + Properties.strings.pcr_days).BackColor = Color.LightGray;
                        lvi.ToolTipText = Properties.strings.pcr_created + ": " + pe.CreationTime + "\r\n" + Properties.strings.pcr_last_modified + ": " + pe.LastModificationTime; 
                        lvi.Tag = pli;

                    
                        if (pe.CustomIconUuid.Equals(PwUuid.Zero))
                            lvi.ImageIndex = (int)pe.IconId;
                        else
                            lvi.ImageIndex = (int)PwIcon.Count + pdb.GetCustomIconIndex(pe.CustomIconUuid);
                    }
                }
            else
                lvExpiringPasswords.Items.Add(Properties.strings.pcr_nothing + "...");
        }

        private void lvExpiringPasswordsItem_onDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo lvHit = lvExpiringPasswords.HitTest(e.Location);
            ListViewItem lvi = lvHit.Item;
            PwListItem pli = (lvi.Tag as PwListItem);
            PwEntry pe = pli.Entry;
            if (pe == null || pdb == null || il_icons == null) return; // Do not assert
            this.Close();

            PwDatabase pwDb = pdb;
            PwEntryForm pForm = new PwEntryForm();
            pForm.InitEx(pe, PwEditMode.EditExistingEntry, pwDb, il_icons,
                false, false);

            DialogResult dr = pForm.ShowDialog();
            bool bMod = ((dr == DialogResult.OK) && pForm.HasModifiedEntry);
            UIUtil.DestroyForm(pForm);

            bool bUpdImg = pwDb.UINeedsIconUpdate;
            PwObjectList<PwEntry> pwEntries = new PwObjectList<PwEntry>();
            pwEntries.Add(pe);
            MainForm mf = Program.MainForm;
            mf.SelectEntries(pwEntries, true, true);
            mf.RefreshEntriesList();
            mf.UpdateUI(false, null, bUpdImg, null, false, null, bMod);

            if (Program.Config.Application.AutoSaveAfterEntryEdit && bMod)
                mf.SaveDatabase(pwDb, null);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void lvExpiringPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvExpiringPasswords_ColumnClick(object sender, ColumnClickEventArgs e)
        {            
            // arrows for showing sort
            const string ascArrow = "▲ ";
            const string descArrow = "▼ ";

            CustomListViewEx lv = (CustomListViewEx)sender;
            ListSorter sorter = (ListSorter)lv.ListViewItemSorter;
            ColumnHeader head = lv.Columns[sorter.Column];

            // remove arrow
            if (head.Text.StartsWith(ascArrow) || head.Text.StartsWith(descArrow))
                head.Text = head.Text.Substring(2, head.Text.Length - 2);

            head = lv.Columns[e.Column];
            if (sorter.Column == e.Column)
            {
                if(sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                    head.Text = descArrow + head.Text;
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                    head.Text = ascArrow + head.Text;
                }
            }
            else
            {
                sorter.Order = SortOrder.Ascending;
                sorter.Column = e.Column;
                head.Text = ascArrow + head.Text;
            }
            lv.ListViewItemSorter = sorter;
            lv.Sort();
        }

        private void PCRPasswordsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_config != null)
                m_config.pcrPasswordsFormHeight = this.Height;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            PCRSettingsForm ep = new PCRSettingsForm(m_host);
            ep.InitEx(m_config);
            ep.ShowDialog();

            lvExpiringPasswords.Items.Clear();
            populateExpiringEntries(pwObjectList);
        }

        private void llbl_Donate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=5F5QB7744AD5G&source=url");
            llbl_Donate.LinkVisited = true;
        }
    }
}
