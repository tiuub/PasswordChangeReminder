using KeePass.Plugins;
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
    public partial class PCRSettingsForm : Form
    {

        private PCRConfig m_config = null;
        private IPluginHost m_host = null;

        public PCRSettingsForm(IPluginHost m_host)
        {
            InitializeComponent();
            this.m_host = m_host;
        }

        private void PCRPasswordsFormSettings_Load(object sender, EventArgs e)
        {
            if (m_host != null)
            {
                this.Left = m_host.MainWindow.Left + 20;
                this.Top = m_host.MainWindow.Top + 20;
            }
        }

        public void InitEx(PCRConfig m_config)
        {
            this.m_config = m_config;

            if (m_config != null)
            {
                cbCheckStartup.Checked = m_config.checkOnStartup;
                nUD_startupremind.Value = m_config.checkOnStartupDays;

                pb_great.BackColor = m_config.pcrPasswordsFormGreatColor;
                pb_tentative.BackColor = m_config.pcrPasswordsFormTentativeColor;
                pb_critical.BackColor = m_config.pcrPasswordsFormCriticalColor;

                nUD_tentative.Value = m_config.pcrPasswordsFormTentativeState;
                nUD_critical.Value = m_config.pcrPasswordsFormCriticalState;
            }
        }

        private void cbCheckStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (m_config != null)
                m_config.checkOnStartup = cbCheckStartup.Checked;
            nUD_startupremind.Enabled = cbCheckStartup.Checked;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pb_great_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pb_great.BackColor = colorDialog1.Color;
                if (m_config != null)
                    m_config.pcrPasswordsFormGreatColor = colorDialog1.Color;
            }
        }

        private void pb_tentative_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pb_tentative.BackColor = colorDialog1.Color;
                if (m_config != null)
                    m_config.pcrPasswordsFormTentativeColor = colorDialog1.Color;
            }
        }

        private void pb_critical_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pb_critical.BackColor = colorDialog1.Color;
                if (m_config != null)
                    m_config.pcrPasswordsFormCriticalColor = colorDialog1.Color;
            }
        }

        private void nUD_startupremind_ValueChanged(object sender, EventArgs e)
        {
            if (m_config != null)
                m_config.checkOnStartupDays = (int)nUD_startupremind.Value;
        }

        private void nUD_tentative_ValueChanged(object sender, EventArgs e)
        {
            if (m_config != null)
                m_config.pcrPasswordsFormTentativeState = (int)nUD_tentative.Value;
        }

        private void nUD_critical_ValueChanged(object sender, EventArgs e)
        {
            if (m_config != null)
                m_config.pcrPasswordsFormCriticalState = (int)nUD_critical.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (m_config != null)
            {
                m_config.checkOnStartup = true;
                m_config.checkOnStartupDays = 5;
                m_config.pcrPasswordsFormGreatColor = Color.LightGreen;
                m_config.pcrPasswordsFormTentativeColor = Color.LightGoldenrodYellow;
                m_config.pcrPasswordsFormCriticalColor = Color.LightSalmon;
                m_config.pcrPasswordsFormTentativeState = 10;
                m_config.pcrPasswordsFormCriticalState = 1;
            }
            cbCheckStartup.Checked = true;
            nUD_startupremind.Value = 5;
            pb_great.BackColor = Color.LightGreen;
            pb_tentative.BackColor = Color.LightGoldenrodYellow;
            pb_critical.BackColor = Color.LightSalmon;
            nUD_tentative.Value = 10;
            nUD_critical.Value = 0;
        }

        private void llbl_Donate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=5F5QB7744AD5G&source=url");
            llbl_Donate.LinkVisited = true;
        }
    }
}
