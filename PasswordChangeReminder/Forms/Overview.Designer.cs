namespace PasswordChangeReminder
{
    partial class PCRPasswordsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvExpiringPasswords = new KeePass.UI.CustomListViewEx();
            this.lb_description = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.llbl_Donate = new System.Windows.Forms.LinkLabel();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lvExpiringPasswords
            // 
            this.lvExpiringPasswords.AllowColumnReorder = true;
            this.lvExpiringPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvExpiringPasswords.FullRowSelect = true;
            this.lvExpiringPasswords.HideSelection = false;
            this.lvExpiringPasswords.Location = new System.Drawing.Point(12, 73);
            this.lvExpiringPasswords.MultiSelect = false;
            this.lvExpiringPasswords.Name = "lvExpiringPasswords";
            this.lvExpiringPasswords.ShowGroups = false;
            this.lvExpiringPasswords.ShowItemToolTips = true;
            this.lvExpiringPasswords.Size = new System.Drawing.Size(411, 169);
            this.lvExpiringPasswords.TabIndex = 0;
            this.lvExpiringPasswords.UseCompatibleStateImageBehavior = false;
            this.lvExpiringPasswords.View = System.Windows.Forms.View.Details;
            this.lvExpiringPasswords.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvExpiringPasswords_ColumnClick);
            this.lvExpiringPasswords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvExpiringPasswordsItem_onDoubleClick);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(9, 57);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(224, 13);
            this.lb_description.TabIndex = 1;
            this.lb_description.Text = "Entries list and when you have to renew them:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(334, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_settings.Location = new System.Drawing.Point(12, 248);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(75, 23);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // llbl_Donate
            // 
            this.llbl_Donate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbl_Donate.AutoSize = true;
            this.llbl_Donate.Location = new System.Drawing.Point(286, 253);
            this.llbl_Donate.Name = "llbl_Donate";
            this.llbl_Donate.Size = new System.Drawing.Size(42, 13);
            this.llbl_Donate.TabIndex = 7;
            this.llbl_Donate.TabStop = true;
            this.llbl_Donate.Text = "Donate";
            this.llbl_Donate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Donate_LinkClicked);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(434, 50);
            this.pictureBoxBanner.TabIndex = 11;
            this.pictureBoxBanner.TabStop = false;
            // 
            // PCRPasswordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 279);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.llbl_Donate);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lvExpiringPasswords);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 260);
            this.Name = "PCRPasswordsForm";
            this.Text = "Password Change Reminder - Overview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCRPasswordsForm_FormClosing);
            this.Load += new System.EventHandler(this.PCR_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeePass.UI.CustomListViewEx lvExpiringPasswords;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.LinkLabel llbl_Donate;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
    }
}