using KeePass.Plugins;
using PasswordChangeReminder.Properties;
using System;
using System.Drawing;
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

            pictureBoxBanner.Image = KeePass.UI.BannerFactory.CreateBanner(pictureBoxBanner.Width,
                pictureBoxBanner.Height,
                KeePass.UI.BannerStyle.Default,
                Resources.settings_white,
                PCRStatics.Settings,
                PCRStatics.SettingsSubline);

            this.m_host = m_host;
            this.TopMost = m_host.MainWindow.TopMost;
            this.Icon = m_host.MainWindow.Icon;
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
                pb_default.BackColor = m_config.pcrPasswordsFormDefaultColor;

                nUD_tentative.Value = m_config.pcrPasswordsFormTentativeState;
                nUD_critical.Value = m_config.pcrPasswordsFormCriticalState;
            }
        }

        private void cbCheckStartup_CheckedChanged(object sender, EventArgs e)
        {
            nUD_startupremind.Enabled = cbCheckStartup.Checked;
        }

        private void pb_great_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pb_great.BackColor = colorDialog1.Color;
            }
        }

        private void pb_tentative_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pb_tentative.BackColor = colorDialog1.Color;
            }
        }

        private void pb_critical_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pb_critical.BackColor = colorDialog1.Color;
            }
        }

        private void pb_default_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pb_default.BackColor = colorDialog1.Color;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (m_config != null)
            {
                m_config.checkOnStartup = cbCheckStartup.Checked;
                m_config.pcrPasswordsFormGreatColor = pb_great.BackColor;
                m_config.pcrPasswordsFormTentativeColor = pb_tentative.BackColor;
                m_config.pcrPasswordsFormCriticalColor = pb_critical.BackColor;
                m_config.pcrPasswordsFormDefaultColor = pb_default.BackColor;
                m_config.checkOnStartupDays = (int)nUD_startupremind.Value;
                m_config.pcrPasswordsFormTentativeState = (int)nUD_tentative.Value;
                m_config.pcrPasswordsFormCriticalState = (int)nUD_critical.Value;
            }
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbCheckStartup.Checked = true;
            nUD_startupremind.Value = 5;
            pb_great.BackColor = Color.LightGreen;
            pb_tentative.BackColor = Color.LightGoldenrodYellow;
            pb_critical.BackColor = Color.LightSalmon;
            pb_default.BackColor = Color.LightGray;
            nUD_tentative.Value = 10;
            nUD_critical.Value = 0;
        }

        private void llbl_Donate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(PCRStatics.DonateLink);
            llbl_Donate.LinkVisited = true;
        }
    }
}
