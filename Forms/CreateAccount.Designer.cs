using System.Drawing;

namespace NEA_Prototype
{
    partial class frmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.chxShowPassword = new System.Windows.Forms.CheckBox();
            this.lblAccessLevels = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegCPassword = new System.Windows.Forms.TextBox();
            this.cbxAccessLevel = new System.Windows.Forms.ComboBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.chxShowPassword);
            this.pnlLogin.Controls.Add(this.lblAccessLevels);
            this.pnlLogin.Controls.Add(this.txtRegUsername);
            this.pnlLogin.Controls.Add(this.txtRegEmail);
            this.pnlLogin.Controls.Add(this.txtRegPassword);
            this.pnlLogin.Controls.Add(this.txtRegCPassword);
            this.pnlLogin.Controls.Add(this.cbxAccessLevel);
            this.pnlLogin.Controls.Add(this.lblConfirmPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblUsernameError);
            this.pnlLogin.Controls.Add(this.lblEmailError);
            this.pnlLogin.Controls.Add(this.lblPasswordError);
            this.pnlLogin.Controls.Add(this.lblEmail);
            this.pnlLogin.Controls.Add(this.btnSignUp);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Location = new System.Drawing.Point(17, 44);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 361);
            this.pnlLogin.TabIndex = 8;
            // 
            // chxShowPassword
            // 
            this.chxShowPassword.AutoSize = true;
            this.chxShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.chxShowPassword.Location = new System.Drawing.Point(321, 149);
            this.chxShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chxShowPassword.Name = "chxShowPassword";
            this.chxShowPassword.Size = new System.Drawing.Size(15, 14);
            this.chxShowPassword.TabIndex = 21;
            this.chxShowPassword.TabStop = false;
            this.chxShowPassword.UseVisualStyleBackColor = false;
            this.chxShowPassword.CheckedChanged += new System.EventHandler(this.chxShowPassword_CheckedChanged);
            // 
            // lblAccessLevels
            // 
            this.lblAccessLevels.AutoSize = true;
            this.lblAccessLevels.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessLevels.ForeColor = System.Drawing.Color.Gray;
            this.lblAccessLevels.Location = new System.Drawing.Point(22, 245);
            this.lblAccessLevels.Name = "lblAccessLevels";
            this.lblAccessLevels.Size = new System.Drawing.Size(77, 15);
            this.lblAccessLevels.TabIndex = 9;
            this.lblAccessLevels.Text = "Access Level";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsername.Location = new System.Drawing.Point(23, 28);
            this.txtRegUsername.Multiline = true;
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(318, 28);
            this.txtRegUsername.TabIndex = 1;
            this.txtRegUsername.TextChanged += new System.EventHandler(this.txtRegUsername_TextChanged_1);
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.ForeColor = System.Drawing.Color.Black;
            this.txtRegEmail.Location = new System.Drawing.Point(23, 80);
            this.txtRegEmail.Multiline = true;
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(318, 28);
            this.txtRegEmail.TabIndex = 2;
            this.txtRegEmail.TextChanged += new System.EventHandler(this.txtRegEmail_TextChanged_1);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.Location = new System.Drawing.Point(24, 143);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '●';
            this.txtRegPassword.Size = new System.Drawing.Size(318, 24);
            this.txtRegPassword.TabIndex = 3;
            this.txtRegPassword.UseSystemPasswordChar = true;
            this.txtRegPassword.TextChanged += new System.EventHandler(this.txtRegPassword_TextChanged_1);
            // 
            // txtRegCPassword
            // 
            this.txtRegCPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegCPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegCPassword.Location = new System.Drawing.Point(24, 207);
            this.txtRegCPassword.Name = "txtRegCPassword";
            this.txtRegCPassword.PasswordChar = '●';
            this.txtRegCPassword.Size = new System.Drawing.Size(318, 24);
            this.txtRegCPassword.TabIndex = 4;
            this.txtRegCPassword.UseSystemPasswordChar = true;
            this.txtRegCPassword.TextChanged += new System.EventHandler(this.txtRegCPassword_TextChanged);
            // 
            // cbxAccessLevel
            // 
            this.cbxAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccessLevel.FormattingEnabled = true;
            this.cbxAccessLevel.Items.AddRange(new object[] {
            "Administrator",
            "Club Teacher",
            "Club Member"});
            this.cbxAccessLevel.Location = new System.Drawing.Point(23, 266);
            this.cbxAccessLevel.Name = "cbxAccessLevel";
            this.cbxAccessLevel.Size = new System.Drawing.Size(318, 24);
            this.cbxAccessLevel.TabIndex = 5;
            this.cbxAccessLevel.SelectedIndexChanged += new System.EventHandler(this.cbxAccessLevel_SelectedIndexChanged_1);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(20, 189);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(107, 15);
            this.lblConfirmPassword.TabIndex = 19;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(20, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 15);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.ForeColor = System.Drawing.Color.Maroon;
            this.lblUsernameError.Location = new System.Drawing.Point(205, 59);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(150, 23);
            this.lblUsernameError.TabIndex = 25;
            // 
            // lblEmailError
            // 
            this.lblEmailError.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmailError.Location = new System.Drawing.Point(205, 111);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(150, 23);
            this.lblEmailError.TabIndex = 26;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.ForeColor = System.Drawing.Color.Maroon;
            this.lblPasswordError.Location = new System.Drawing.Point(205, 174);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(150, 23);
            this.lblPasswordError.TabIndex = 27;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(21, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Enabled = false;
            this.btnSignUp.FlatAppearance.BorderSize = 5;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(24, 303);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(315, 46);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Register";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Window;
            this.lblPassword.CausesValidation = false;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(20, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.BackColor = System.Drawing.Color.White;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCreateAccount.Location = new System.Drawing.Point(31, 14);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(216, 31);
            this.lblCreateAccount.TabIndex = 20;
            this.lblCreateAccount.Text = "Create Account";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 5;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Location = new System.Drawing.Point(43, 407);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(312, 41);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Back";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 463);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;  
        private System.Windows.Forms.TextBox txtRegCPassword;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAccessLevels;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.ComboBox cbxAccessLevel;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.CheckBox chxShowPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}