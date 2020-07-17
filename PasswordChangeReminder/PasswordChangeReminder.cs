using KeePass.Forms;
using KeePass.Plugins;
using KeePass.UI;
using KeePassLib;
using KeePassLib.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChangeReminder
{
    public class PasswordChangeReminderExt : Plugin
    {
        public static IPluginHost m_host = null;
        private ToolStripMenuItem m_MainMenuItem;
        private PwEntryForm m_pweForm = null;
        private CheckBox cb_Remind = null;
        private NumericUpDown nup_RemindDays = null;
        public static PCRConfig m_config = null;
        private RenewInColumnProv m_prov = null;

        public static string _EntryStringKey = "_pcr_remindindays";
        public static string _PluginName = "Password Change Reminder";

        internal static IPluginHost Host
        {
            get { return m_host; }
        }
        internal static PCRConfig Config
        {
            get { return m_config; }
        }

        public override bool Initialize(IPluginHost host)
        {
            if (host == null) return false;
            m_host = host;

            GlobalWindowManager.WindowAdded += OnWindowAdded;

            m_MainMenuItem = new ToolStripMenuItem(_PluginName);
            m_MainMenuItem.Click += MainMenuItem_OnClick;
            m_MainMenuItem.Image = Properties.Resources.PCR_icon_48_48_png;
            m_host.MainWindow.ToolsMenu.DropDownItems.Add(m_MainMenuItem);
            m_host.MainWindow.FileOpened += checkOnStartup_onFileOpened;

            m_prov = new RenewInColumnProv();
            m_host.ColumnProviderPool.Add(m_prov);

            m_config = new PCRConfig(host);

            return true;
        }

        public override void Terminate()
        {
            if (m_host == null) return;

            GlobalWindowManager.WindowAdded -= OnWindowAdded;
            m_host.MainWindow.FileOpened -= checkOnStartup_onFileOpened;

            m_host.ColumnProviderPool.Remove(m_prov);
            m_prov = null;

            m_host = null;
        }

        public override string UpdateUrl
        {
            get
            {
                return "https://raw.githubusercontent.com/tiuub/PasswordChangeReminder/master/VERSION";
            }
        }

        private void OnWindowAdded(object sender, GwmWindowEventArgs e)
        {
            if (!(e.Form is PwEntryForm)) return;
            m_pweForm = (PwEntryForm)e.Form;
            PwEditMode m = EditMode();
            if (m == PwEditMode.Invalid) return;

            Control grpString = Tools.GetControl("m_grpstringFields", m_pweForm);
            Control lvStrings = Tools.GetControl("m_lvStrings", m_pweForm);

            cb_Remind = new CheckBox();
            nup_RemindDays = new NumericUpDown();

            cb_Remind.Top = 13;
            cb_Remind.Left = 9;
            cb_Remind.Width = 240;
            cb_Remind.Height = 17;
            cb_Remind.Text = Properties.strings.pcr_pwentry_cb_remind;
            cb_Remind.Name = "pcr_cbRemind";
            cb_Remind.Enabled = true;
            cb_Remind.CheckStateChanged += cbRemind_onCheckStateChanged;
            grpString.Parent.Controls.Add(cb_Remind);

            nup_RemindDays.Top = 13;
            nup_RemindDays.Left = cb_Remind.Right + 6;
            nup_RemindDays.Width = 50;
            nup_RemindDays.Height = 17;
            nup_RemindDays.Value = 90;
            nup_RemindDays.Minimum = 1;
            nup_RemindDays.Maximum = Int32.MaxValue;
            nup_RemindDays.Enabled = false;
            nup_RemindDays.Name = "pcr_nupRemindDays";
            grpString.Parent.Controls.Add(nup_RemindDays);

            grpString.Top = grpString.Top + 30;
            grpString.Height = grpString.Height - 25;
            lvStrings.Height = lvStrings.Height - 25;

            if (m_pweForm.EntryStrings.Exists(_EntryStringKey))
            {
                cb_Remind.Checked = true;
                nup_RemindDays.Value = Convert.ToInt32(m_pweForm.EntryStrings.Get(_EntryStringKey).ReadString());
            }

            if (m == PwEditMode.ViewReadOnlyEntry)
            {
                cb_Remind.Enabled = false;
                nup_RemindDays.Enabled = false;
            }

            m_pweForm.EntrySaving += PwEntryForm_onEntrySaving;

            cb_Remind.BringToFront();
            nup_RemindDays.BringToFront();
        }

        private void checkOnStartup_onFileOpened(object sender, EventArgs e)
        {

            if (m_host != null && m_host.Database != null && m_host.Database.IsOpen && m_config != null && m_config.checkOnStartup)
            {
                foreach (PwEntry pe in Tools.GetExpiringPasswords(m_host))
                {
                    if (pe.Strings.Exists(PasswordChangeReminderExt._EntryStringKey))
                    {
                        PwListItem pli = new PwListItem(pe);
                        int iRemindIn = Convert.ToInt32(pe.Strings.Get(PasswordChangeReminderExt._EntryStringKey).ReadString().ToString());
                        int iPwAge = Tools.calculateAge(pe);
                        int iChangeIn = iRemindIn - iPwAge;

                        if (iChangeIn <= m_config.checkOnStartupDays)
                        {
                            PCRPasswordsForm ep = new PCRPasswordsForm(m_host);
                            ep.InitEx(Tools.GetExpiringPasswords(m_host), m_host.Database, m_host.MainWindow.ClientIcons, m_config);
                            ep.ShowDialog();
                            break;
                        }
                    }
                }
            }
        }

        public void cbRemind_onCheckStateChanged(object sender, EventArgs e)
        {
            if (m_pweForm != null && sender.GetType() == typeof(CheckBox) && nup_RemindDays != null) nup_RemindDays.Enabled = ((CheckBox)sender).Checked;
        }

        public void PwEntryForm_onEntrySaving(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(PwEntryForm) && nup_RemindDays != null && cb_Remind != null)
            {
                if (nup_RemindDays.Value > 0 && cb_Remind.Checked)
                {
                    ((PwEntryForm)sender).EntryStrings.Set(_EntryStringKey, new ProtectedString(false, nup_RemindDays.Value.ToString()));
                }
                else if (((PwEntryForm)sender).EntryStrings.Exists(_EntryStringKey))
                {
                    ((PwEntryForm)sender).EntryStrings.Remove(_EntryStringKey);
                }

            }
        }

        private void MainMenuItem_OnClick(object sender, EventArgs e)
        {
            PCRPasswordsForm ep = new PCRPasswordsForm(m_host);
            ep.InitEx(Tools.GetExpiringPasswords(m_host), m_host.Database, m_host.MainWindow.ClientIcons, m_config);
            ep.ShowDialog();
        }

        private PwEditMode EditMode()
        {
            PwEditMode m = PwEditMode.Invalid;
            if (m_pweForm == null) return m;
            PropertyInfo pi = typeof(PwEntryForm).GetProperty("EditModeEx");
            if (pi != null)
            { //will work starting with KeePass 2.41, preferred way as it's a public attribute
                m = (PwEditMode)pi.GetValue(m_pweForm, null);
            }
            else
            { // try reading private field
                m = (PwEditMode)Tools.GetField("m_pwEditMode", m_pweForm);
            }
            return m;
        }

        public sealed class RenewInColumnProv : ColumnProvider
        {
            private const string RenewInColumnName = "Renew Password in";

            public override string[] ColumnNames
            {
                get { return new string[] { RenewInColumnName }; }
            }

            public override string GetCellData(string strColumnName, PwEntry pe)
            {
                if (pe.Strings.Exists(PasswordChangeReminderExt._EntryStringKey))
                {
                    PwListItem pli = new PwListItem(pe);
                    int iRemindIn = Convert.ToInt32(pe.Strings.Get(PasswordChangeReminderExt._EntryStringKey).ReadString().ToString());
                    int iPwAge = Tools.calculateAge(pe);
                    int iChangeIn = iRemindIn - iPwAge;
                    
                    if (iChangeIn <= 0)
                    {
                        return Properties.strings.pcr_today + " (" + iChangeIn.ToString() + " " + Properties.strings.pcr_days + ")";
                    }

                    return iChangeIn.ToString() + " days";
                }
                return string.Empty;
            }

            public override bool SupportsCellAction(string strColumnName)
            {
                return (strColumnName == RenewInColumnName);
            }

            public override void PerformCellAction(string strColumnName, PwEntry pe)
            {
                if ((strColumnName == RenewInColumnName) && (pe != null))
                {
                    PCRPasswordsForm ep = new PCRPasswordsForm(PasswordChangeReminderExt.Host);
                    ep.InitEx(Tools.GetExpiringPasswords(PasswordChangeReminderExt.Host), PasswordChangeReminderExt.Host.Database, PasswordChangeReminderExt.Host.MainWindow.ClientIcons, PasswordChangeReminderExt.Config);
                    ep.ShowDialog();
                }
            }
        }
    }
}
