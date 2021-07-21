namespace PasswordChangeReminder
{
    partial class PCRSettingsForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCheckStartup = new System.Windows.Forms.CheckBox();
            this.gB_startupoptions = new System.Windows.Forms.GroupBox();
            this.lbl_checkstartup = new System.Windows.Forms.Label();
            this.nUD_startupremind = new System.Windows.Forms.NumericUpDown();
            this.lbl_startupremind = new System.Windows.Forms.Label();
            this.gB_coloroptions = new System.Windows.Forms.GroupBox();
            this.pb_critical = new System.Windows.Forms.PictureBox();
            this.lbl_critical = new System.Windows.Forms.Label();
            this.pb_tentative = new System.Windows.Forms.PictureBox();
            this.lbl_tentative = new System.Windows.Forms.Label();
            this.pb_great = new System.Windows.Forms.PictureBox();
            this.lbl_great = new System.Windows.Forms.Label();
            this.gB_expiringoptions = new System.Windows.Forms.GroupBox();
            this.nUD_critical = new System.Windows.Forms.NumericUpDown();
            this.lbl_criticalstate = new System.Windows.Forms.Label();
            this.nUD_tentative = new System.Windows.Forms.NumericUpDown();
            this.lbl_tentativestate = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_reset = new System.Windows.Forms.Button();
            this.llbl_Donate = new System.Windows.Forms.LinkLabel();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pb_default = new System.Windows.Forms.PictureBox();
            this.lbl_default = new System.Windows.Forms.Label();
            this.gB_startupoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_startupremind)).BeginInit();
            this.gB_coloroptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_critical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tentative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_great)).BeginInit();
            this.gB_expiringoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_critical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_tentative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_default)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(294, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbCheckStartup
            // 
            this.cbCheckStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCheckStartup.AutoSize = true;
            this.cbCheckStartup.Location = new System.Drawing.Point(306, 23);
            this.cbCheckStartup.Name = "cbCheckStartup";
            this.cbCheckStartup.Size = new System.Drawing.Size(15, 14);
            this.cbCheckStartup.TabIndex = 4;
            this.cbCheckStartup.UseVisualStyleBackColor = true;
            this.cbCheckStartup.CheckedChanged += new System.EventHandler(this.cbCheckStartup_CheckedChanged);
            // 
            // gB_startupoptions
            // 
            this.gB_startupoptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_startupoptions.Controls.Add(this.lbl_checkstartup);
            this.gB_startupoptions.Controls.Add(this.nUD_startupremind);
            this.gB_startupoptions.Controls.Add(this.cbCheckStartup);
            this.gB_startupoptions.Controls.Add(this.lbl_startupremind);
            this.gB_startupoptions.Location = new System.Drawing.Point(12, 62);
            this.gB_startupoptions.Name = "gB_startupoptions";
            this.gB_startupoptions.Size = new System.Drawing.Size(371, 78);
            this.gB_startupoptions.TabIndex = 5;
            this.gB_startupoptions.TabStop = false;
            this.gB_startupoptions.Text = "Startup Options";
            // 
            // lbl_checkstartup
            // 
            this.lbl_checkstartup.AutoSize = true;
            this.lbl_checkstartup.Location = new System.Drawing.Point(6, 26);
            this.lbl_checkstartup.Name = "lbl_checkstartup";
            this.lbl_checkstartup.Size = new System.Drawing.Size(200, 13);
            this.lbl_checkstartup.TabIndex = 7;
            this.lbl_checkstartup.Text = "Check for matrued passwords at startup?";
            // 
            // nUD_startupremind
            // 
            this.nUD_startupremind.Enabled = false;
            this.nUD_startupremind.Location = new System.Drawing.Point(306, 50);
            this.nUD_startupremind.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_startupremind.Name = "nUD_startupremind";
            this.nUD_startupremind.Size = new System.Drawing.Size(56, 20);
            this.nUD_startupremind.TabIndex = 6;
            this.nUD_startupremind.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_startupremind
            // 
            this.lbl_startupremind.AutoSize = true;
            this.lbl_startupremind.Location = new System.Drawing.Point(6, 52);
            this.lbl_startupremind.Name = "lbl_startupremind";
            this.lbl_startupremind.Size = new System.Drawing.Size(258, 13);
            this.lbl_startupremind.TabIndex = 5;
            this.lbl_startupremind.Text = "Remind on startup, if password is expiring in (... days):";
            // 
            // gB_coloroptions
            // 
            this.gB_coloroptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_coloroptions.Controls.Add(this.lbl_default);
            this.gB_coloroptions.Controls.Add(this.pb_default);
            this.gB_coloroptions.Controls.Add(this.pb_critical);
            this.gB_coloroptions.Controls.Add(this.lbl_critical);
            this.gB_coloroptions.Controls.Add(this.pb_tentative);
            this.gB_coloroptions.Controls.Add(this.lbl_tentative);
            this.gB_coloroptions.Controls.Add(this.pb_great);
            this.gB_coloroptions.Controls.Add(this.lbl_great);
            this.gB_coloroptions.Location = new System.Drawing.Point(12, 146);
            this.gB_coloroptions.Name = "gB_coloroptions";
            this.gB_coloroptions.Size = new System.Drawing.Size(371, 78);
            this.gB_coloroptions.TabIndex = 6;
            this.gB_coloroptions.TabStop = false;
            this.gB_coloroptions.Text = "Color Options";
            // 
            // pb_critical
            // 
            this.pb_critical.BackColor = System.Drawing.Color.LightSalmon;
            this.pb_critical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_critical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_critical.Location = new System.Drawing.Point(116, 45);
            this.pb_critical.Name = "pb_critical";
            this.pb_critical.Size = new System.Drawing.Size(20, 20);
            this.pb_critical.TabIndex = 5;
            this.pb_critical.TabStop = false;
            this.pb_critical.Click += new System.EventHandler(this.pb_critical_Click);
            // 
            // lbl_critical
            // 
            this.lbl_critical.AutoSize = true;
            this.lbl_critical.Location = new System.Drawing.Point(6, 52);
            this.lbl_critical.Name = "lbl_critical";
            this.lbl_critical.Size = new System.Drawing.Size(69, 13);
            this.lbl_critical.TabIndex = 4;
            this.lbl_critical.Text = "Critical State:";
            // 
            // pb_tentative
            // 
            this.pb_tentative.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pb_tentative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_tentative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_tentative.Location = new System.Drawing.Point(306, 19);
            this.pb_tentative.Name = "pb_tentative";
            this.pb_tentative.Size = new System.Drawing.Size(20, 20);
            this.pb_tentative.TabIndex = 3;
            this.pb_tentative.TabStop = false;
            this.pb_tentative.Click += new System.EventHandler(this.pb_tentative_Click);
            // 
            // lbl_tentative
            // 
            this.lbl_tentative.AutoSize = true;
            this.lbl_tentative.Location = new System.Drawing.Point(205, 26);
            this.lbl_tentative.Name = "lbl_tentative";
            this.lbl_tentative.Size = new System.Drawing.Size(83, 13);
            this.lbl_tentative.TabIndex = 2;
            this.lbl_tentative.Text = "Tentative State:";
            // 
            // pb_great
            // 
            this.pb_great.BackColor = System.Drawing.Color.LightGreen;
            this.pb_great.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_great.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_great.Location = new System.Drawing.Point(116, 19);
            this.pb_great.Name = "pb_great";
            this.pb_great.Size = new System.Drawing.Size(20, 20);
            this.pb_great.TabIndex = 1;
            this.pb_great.TabStop = false;
            this.pb_great.Click += new System.EventHandler(this.pb_great_Click);
            // 
            // lbl_great
            // 
            this.lbl_great.AutoSize = true;
            this.lbl_great.Location = new System.Drawing.Point(6, 26);
            this.lbl_great.Name = "lbl_great";
            this.lbl_great.Size = new System.Drawing.Size(64, 13);
            this.lbl_great.TabIndex = 0;
            this.lbl_great.Text = "Great State:";
            // 
            // gB_expiringoptions
            // 
            this.gB_expiringoptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_expiringoptions.Controls.Add(this.nUD_critical);
            this.gB_expiringoptions.Controls.Add(this.lbl_criticalstate);
            this.gB_expiringoptions.Controls.Add(this.nUD_tentative);
            this.gB_expiringoptions.Controls.Add(this.lbl_tentativestate);
            this.gB_expiringoptions.Location = new System.Drawing.Point(12, 230);
            this.gB_expiringoptions.Name = "gB_expiringoptions";
            this.gB_expiringoptions.Size = new System.Drawing.Size(371, 78);
            this.gB_expiringoptions.TabIndex = 7;
            this.gB_expiringoptions.TabStop = false;
            this.gB_expiringoptions.Text = "Expiring Options";
            // 
            // nUD_critical
            // 
            this.nUD_critical.Location = new System.Drawing.Point(306, 50);
            this.nUD_critical.Name = "nUD_critical";
            this.nUD_critical.Size = new System.Drawing.Size(56, 20);
            this.nUD_critical.TabIndex = 9;
            // 
            // lbl_criticalstate
            // 
            this.lbl_criticalstate.AutoSize = true;
            this.lbl_criticalstate.Location = new System.Drawing.Point(6, 52);
            this.lbl_criticalstate.Name = "lbl_criticalstate";
            this.lbl_criticalstate.Size = new System.Drawing.Size(280, 13);
            this.lbl_criticalstate.TabIndex = 8;
            this.lbl_criticalstate.Text = "Set color to critical color, if pasword is expiring in (... days):";
            // 
            // nUD_tentative
            // 
            this.nUD_tentative.Location = new System.Drawing.Point(306, 24);
            this.nUD_tentative.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_tentative.Name = "nUD_tentative";
            this.nUD_tentative.Size = new System.Drawing.Size(56, 20);
            this.nUD_tentative.TabIndex = 7;
            this.nUD_tentative.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_tentativestate
            // 
            this.lbl_tentativestate.AutoSize = true;
            this.lbl_tentativestate.Location = new System.Drawing.Point(6, 26);
            this.lbl_tentativestate.Name = "lbl_tentativestate";
            this.lbl_tentativestate.Size = new System.Drawing.Size(291, 13);
            this.lbl_tentativestate.TabIndex = 0;
            this.lbl_tentativestate.Text = "Set color to tentative color, if pasword is expiring in (... days):";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.Location = new System.Drawing.Point(12, 317);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // llbl_Donate
            // 
            this.llbl_Donate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbl_Donate.AutoSize = true;
            this.llbl_Donate.Location = new System.Drawing.Point(93, 322);
            this.llbl_Donate.Name = "llbl_Donate";
            this.llbl_Donate.Size = new System.Drawing.Size(42, 13);
            this.llbl_Donate.TabIndex = 9;
            this.llbl_Donate.TabStop = true;
            this.llbl_Donate.Text = "Donate";
            this.llbl_Donate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Donate_LinkClicked);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(394, 50);
            this.pictureBoxBanner.TabIndex = 10;
            this.pictureBoxBanner.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(200, 317);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pb_default
            // 
            this.pb_default.BackColor = System.Drawing.Color.LightGray;
            this.pb_default.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_default.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_default.Location = new System.Drawing.Point(306, 45);
            this.pb_default.Name = "pb_default";
            this.pb_default.Size = new System.Drawing.Size(20, 20);
            this.pb_default.TabIndex = 6;
            this.pb_default.TabStop = false;
            this.pb_default.Click += new System.EventHandler(this.pb_default_Click);
            // 
            // lbl_default
            // 
            this.lbl_default.AutoSize = true;
            this.lbl_default.Location = new System.Drawing.Point(205, 52);
            this.lbl_default.Name = "lbl_default";
            this.lbl_default.Size = new System.Drawing.Size(71, 13);
            this.lbl_default.TabIndex = 7;
            this.lbl_default.Text = "Default Color:";
            // 
            // PCRSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 352);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.llbl_Donate);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.gB_expiringoptions);
            this.Controls.Add(this.gB_coloroptions);
            this.Controls.Add(this.gB_startupoptions);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PCRSettingsForm";
            this.Text = "Password Change Reminder - Settings";
            this.Load += new System.EventHandler(this.PCRPasswordsFormSettings_Load);
            this.gB_startupoptions.ResumeLayout(false);
            this.gB_startupoptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_startupremind)).EndInit();
            this.gB_coloroptions.ResumeLayout(false);
            this.gB_coloroptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_critical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tentative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_great)).EndInit();
            this.gB_expiringoptions.ResumeLayout(false);
            this.gB_expiringoptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_critical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_tentative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_default)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbCheckStartup;
        private System.Windows.Forms.GroupBox gB_startupoptions;
        private System.Windows.Forms.NumericUpDown nUD_startupremind;
        private System.Windows.Forms.Label lbl_startupremind;
        private System.Windows.Forms.GroupBox gB_coloroptions;
        private System.Windows.Forms.PictureBox pb_critical;
        private System.Windows.Forms.Label lbl_critical;
        private System.Windows.Forms.PictureBox pb_tentative;
        private System.Windows.Forms.Label lbl_tentative;
        private System.Windows.Forms.PictureBox pb_great;
        private System.Windows.Forms.Label lbl_great;
        private System.Windows.Forms.Label lbl_checkstartup;
        private System.Windows.Forms.GroupBox gB_expiringoptions;
        private System.Windows.Forms.NumericUpDown nUD_critical;
        private System.Windows.Forms.Label lbl_criticalstate;
        private System.Windows.Forms.NumericUpDown nUD_tentative;
        private System.Windows.Forms.Label lbl_tentativestate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.LinkLabel llbl_Donate;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label lbl_default;
        private System.Windows.Forms.PictureBox pb_default;
    }
}