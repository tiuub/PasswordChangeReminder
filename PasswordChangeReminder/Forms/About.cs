using KeePass.Plugins;
using PasswordChangeReminder.Properties;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PasswordChangeReminder
{
    public partial class About : Form
    {
        private IPluginHost host;

        private GroupBox groupBoxLicense;

        public About(IPluginHost host)
        {
            InitializeComponent();

            pictureBoxBanner.Image = KeePass.UI.BannerFactory.CreateBanner(pictureBoxBanner.Width,
                pictureBoxBanner.Height,
                KeePass.UI.BannerStyle.Default,
                Resources.info_white,
                PCRStatics.About,
                PCRStatics.AboutSubline);

            this.Icon = host.MainWindow.Icon;

            this.host = host;
            this.TopMost = host.MainWindow.TopMost;

            groupBoxDependencies.Text = PCRStatics.Dependencies;
            linkLabelGitHubRepository.Text = PCRStatics.GitHubRepository;
            linkLabelDonate.Text = PCRStatics.Donate;
            buttonOK.Text = PCRStatics.OK;
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.Left = this.host.MainWindow.Left + 20;
            this.Top = this.host.MainWindow.Top + 20;

            groupBoxAbout.Text = PCRStatics.About;

            Assembly assembly = Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            labelAbout.Text = String.Format(PCRStatics.AboutDisclaimer, fvi.FileVersion);

            loadDependencies();
        }

        private void loadDependencies()
        {
            clv_Dependencies.Clear();

            clv_Dependencies.Columns.Add(PCRStatics.Dependencie, 100);
            clv_Dependencies.Columns.Add(PCRStatics.Author, 80);
            clv_Dependencies.Columns.Add(PCRStatics.License, 80);


            ListViewItem lvi = new ListViewItem("Material Icons");
            lvi.SubItems.Add("Google");
            lvi.SubItems.Add("Apache License Version 2.0");
            lvi.Tag = Resources.MaterialDesignIconsLICENSE;
            clv_Dependencies.Items.Add(lvi);
        }

        private void linkLabelGitHubRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(PCRStatics.RepositoryLicenseLink);
            linkLabelGitHubRepository.LinkVisited = true;
        }

        private void linkLabelDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(PCRStatics.DonateLink);
            linkLabelDonate.LinkVisited = true;
        }

        private void clv_Dependencies_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = clv_Dependencies.SelectedItems[0];
            Point mousePosition = clv_Dependencies.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = clv_Dependencies.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);

            if (columnindex < 2)
            {
                if (MessageBox.Show(PCRStatics.AboutMessageBoxOpenRepository, PCRStatics.Dependencies, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(PCRStatics.RepositoryLicenseLink);

            }
            else
            {
                if (groupBoxLicense != null)
                    hideLicense();
                if (lvi.Tag != null)
                {
                    showLicense(lvi.Text, lvi.SubItems[1].Text, lvi.Tag.ToString());
                }
                else
                    MessageBox.Show(String.Format(PCRStatics.AboutMessageBoxCantLoadLicense, lvi.Text), PCRStatics.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showLicense(string dependencie, string author, string license)
        {
            groupBoxDependencies.Anchor -= AnchorStyles.Bottom;
            int groupBoxLicenseHeight = 101;
            this.Height = this.Height + groupBoxLicenseHeight + groupBoxDependencies.Margin.All * 2;

            groupBoxLicense = new GroupBox();
            groupBoxLicense.Text = String.Format("{0} - {1} by {2}", PCRStatics.License, dependencie, author);
            groupBoxLicense.Left = groupBoxDependencies.Left;
            groupBoxLicense.Top = groupBoxDependencies.Bottom + groupBoxDependencies.Margin.All * 2;
            groupBoxLicense.Width = groupBoxDependencies.Width;
            groupBoxLicense.Height = groupBoxLicenseHeight;
            groupBoxLicense.Margin = groupBoxDependencies.Margin;

            RichTextBox richTextBoxLicense = new RichTextBox();
            richTextBoxLicense.ReadOnly = true;
            richTextBoxLicense.Dock = DockStyle.Fill;
            richTextBoxLicense.Text = license;

            groupBoxLicense.Controls.Add(richTextBoxLicense);

            this.Controls.Add(groupBoxLicense);
            groupBoxDependencies.Anchor -= AnchorStyles.Bottom;
        }

        private void hideLicense()
        {
            groupBoxDependencies.Anchor -= AnchorStyles.Bottom;

            int groupBoxLicenseHeight = groupBoxLicense.Height;
            this.Height = this.Height - groupBoxLicenseHeight - groupBoxDependencies.Margin.All * 2;

            this.Controls.Remove(groupBoxLicense);

            groupBoxLicense = null;

            groupBoxDependencies.Anchor -= AnchorStyles.Bottom;
        }
    }
}
