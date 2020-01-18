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
            this.cbCheckStartup = new System.Windows.Forms.CheckBox();
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
            this.lvExpiringPasswords.Location = new System.Drawing.Point(12, 25);
            this.lvExpiringPasswords.MultiSelect = false;
            this.lvExpiringPasswords.Name = "lvExpiringPasswords";
            this.lvExpiringPasswords.ShowGroups = false;
            this.lvExpiringPasswords.ShowItemToolTips = true;
            this.lvExpiringPasswords.Size = new System.Drawing.Size(411, 206);
            this.lvExpiringPasswords.TabIndex = 0;
            this.lvExpiringPasswords.UseCompatibleStateImageBehavior = false;
            this.lvExpiringPasswords.View = System.Windows.Forms.View.Details;
            this.lvExpiringPasswords.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvExpiringPasswords_ColumnClick);
            this.lvExpiringPasswords.SelectedIndexChanged += new System.EventHandler(this.lvExpiringPasswords_SelectedIndexChanged);
            this.lvExpiringPasswords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvExpiringPasswordsItem_onDoubleClick);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(9, 9);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(344, 13);
            this.lb_description.TabIndex = 1;
            this.lb_description.Text = "Here are listed your renewable passwords and when they due to renew:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(335, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = global::PasswordChangeReminder.Properties.strings.pcr_form_close;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // cbCheckStartup
            // 
            this.cbCheckStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCheckStartup.AutoSize = true;
            this.cbCheckStartup.Location = new System.Drawing.Point(12, 237);
            this.cbCheckStartup.Name = "cbCheckStartup";
            this.cbCheckStartup.Size = new System.Drawing.Size(267, 17);
            this.cbCheckStartup.TabIndex = 3;
            this.cbCheckStartup.Text = global::PasswordChangeReminder.Properties.strings.pcr_form_cbCheckStartup;
            this.cbCheckStartup.UseVisualStyleBackColor = true;
            this.cbCheckStartup.CheckedChanged += new System.EventHandler(this.cbCheckStartup_CheckedChanged);
            // 
            // PCRPasswordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.cbCheckStartup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lvExpiringPasswords);
            this.Icon = global::PasswordChangeReminder.Properties.Resources.PCR_icon_48_48_ico;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 260);
            this.Name = "PCRPasswordsForm";
            this.Text = "Password Change Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCRPasswordsForm_FormClosing);
            this.Load += new System.EventHandler(this.PCR_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeePass.UI.CustomListViewEx lvExpiringPasswords;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbCheckStartup;
    }
}