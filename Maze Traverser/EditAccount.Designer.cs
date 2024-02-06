namespace NEA_Prototype
{
    partial class frmEditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAccount));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.chxShowCurrent = new System.Windows.Forms.CheckBox();
            this.lblNewPassValidate = new System.Windows.Forms.Label();
            this.lblCurrentPassValidate = new System.Windows.Forms.Label();
            this.txtNewConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chxShowNewPassword = new System.Windows.Forms.CheckBox();
            this.lblIncorrectLogin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.chxShowCurrent);
            this.pnlLogin.Controls.Add(this.lblNewPassValidate);
            this.pnlLogin.Controls.Add(this.lblCurrentPassValidate);
            this.pnlLogin.Controls.Add(this.txtNewConfirm);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.chxShowNewPassword);
            this.pnlLogin.Controls.Add(this.lblIncorrectLogin);
            this.pnlLogin.Controls.Add(this.btnBack);
            this.pnlLogin.Controls.Add(this.btnConfirm);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblCurrentPassword);
            this.pnlLogin.Controls.Add(this.txtCurrentPassword);
            this.pnlLogin.Controls.Add(this.txtNewPassword);
            this.pnlLogin.Location = new System.Drawing.Point(12, 39);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(308, 291);
            this.pnlLogin.TabIndex = 8;
            // 
            // chxShowCurrent
            // 
            this.chxShowCurrent.AutoSize = true;
            this.chxShowCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.chxShowCurrent.Location = new System.Drawing.Point(287, 46);
            this.chxShowCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.chxShowCurrent.Name = "chxShowCurrent";
            this.chxShowCurrent.Size = new System.Drawing.Size(15, 14);
            this.chxShowCurrent.TabIndex = 28;
            this.chxShowCurrent.TabStop = false;
            this.chxShowCurrent.UseVisualStyleBackColor = false;
            this.chxShowCurrent.CheckedChanged += new System.EventHandler(this.chxShowCurrent_CheckedChanged);
            // 
            // lblNewPassValidate
            // 
            this.lblNewPassValidate.ForeColor = System.Drawing.Color.Maroon;
            this.lblNewPassValidate.Location = new System.Drawing.Point(164, 120);
            this.lblNewPassValidate.Name = "lblNewPassValidate";
            this.lblNewPassValidate.Size = new System.Drawing.Size(141, 23);
            this.lblNewPassValidate.TabIndex = 26;
            // 
            // lblCurrentPassValidate
            // 
            this.lblCurrentPassValidate.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurrentPassValidate.Location = new System.Drawing.Point(175, 67);
            this.lblCurrentPassValidate.Name = "lblCurrentPassValidate";
            this.lblCurrentPassValidate.Size = new System.Drawing.Size(133, 23);
            this.lblCurrentPassValidate.TabIndex = 27;
            // 
            // txtNewConfirm
            // 
            this.txtNewConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNewConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewConfirm.Location = new System.Drawing.Point(32, 146);
            this.txtNewConfirm.Name = "txtNewConfirm";
            this.txtNewConfirm.PasswordChar = '●';
            this.txtNewConfirm.Size = new System.Drawing.Size(273, 24);
            this.txtNewConfirm.TabIndex = 3;
            this.txtNewConfirm.UseSystemPasswordChar = true;
            this.txtNewConfirm.TextChanged += new System.EventHandler(this.txtNewConfirm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirm password";
            // 
            // chxShowNewPassword
            // 
            this.chxShowNewPassword.AutoSize = true;
            this.chxShowNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.chxShowNewPassword.Location = new System.Drawing.Point(287, 100);
            this.chxShowNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chxShowNewPassword.Name = "chxShowNewPassword";
            this.chxShowNewPassword.Size = new System.Drawing.Size(15, 14);
            this.chxShowNewPassword.TabIndex = 8;
            this.chxShowNewPassword.TabStop = false;
            this.chxShowNewPassword.UseVisualStyleBackColor = false;
            this.chxShowNewPassword.CheckedChanged += new System.EventHandler(this.chxShowNewPassword_CheckedChanged);
            // 
            // lblIncorrectLogin
            // 
            this.lblIncorrectLogin.AutoSize = true;
            this.lblIncorrectLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lblIncorrectLogin.Location = new System.Drawing.Point(106, 79);
            this.lblIncorrectLogin.Name = "lblIncorrectLogin";
            this.lblIncorrectLogin.Size = new System.Drawing.Size(0, 13);
            this.lblIncorrectLogin.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 5;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Location = new System.Drawing.Point(42, 232);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 5;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(42, 187);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(255, 39);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(29, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "New password";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentPassword.Location = new System.Drawing.Point(29, 19);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(105, 15);
            this.lblCurrentPassword.TabIndex = 3;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(32, 40);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.Size = new System.Drawing.Size(273, 24);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(32, 94);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(273, 24);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblLogin.Location = new System.Drawing.Point(73, 11);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(183, 29);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Edit Account";
            // 
            // frmEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 351);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Account";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.CheckBox chxShowNewPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblIncorrectLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewPassValidate;
        private System.Windows.Forms.Label lblCurrentPassValidate;
        private System.Windows.Forms.CheckBox chxShowCurrent;
    }
}