using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public partial class frmEditAccount : Form
    {
        public const string Database_Connection_String = "..\\..\\Data\\MTDatabase.db";
        public User currentUser = new User();
        public bool validPassword = false;
        public frmEditAccount(string username)
        {
            currentUser.Username = username;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (validPassword)
            {
                string enteredPassword = currentUser.HashPassword(txtCurrentPassword.Text.ToString());
                using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
                {
                    dbConnection.Open();
                    SQLiteCommand com = new SQLiteCommand("SELECT Password FROM LoginDetails WHERE Username = @Username", dbConnection);
                    com.Parameters.AddWithValue("@Username", currentUser.Username);

                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentUser.Password = reader.GetString(0);
                        }
                        if (currentUser.Password == enteredPassword)
                        {
                            string newPassword = currentUser.HashPassword(txtNewPassword.Text.ToString());
                            SQLiteCommand com2 = new SQLiteCommand("UPDATE LoginDetails SET Password = @Password WHERE Username = @Username", dbConnection);
                            com2.Parameters.AddWithValue("@Password", newPassword);
                            com2.Parameters.AddWithValue("@Username", currentUser.Username.ToString());
                            com2.ExecuteReader();
                            dbConnection.Close();
                            this.Close();
                        }
                        else
                        {
                            lblCurrentPassValidate.Text = "Password is incorrect";
                        }
                        dbConnection.Close();

                    }
                }
            }           
      
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewConfirm_TextChanged(object sender, EventArgs e)
        {
            txtNewConfirm.UseSystemPasswordChar = true;
            txtNewConfirm.PasswordChar = '●';
            lblNewPassValidate.Text = "";
            ValidPasswordCheck();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.PasswordChar = '●';
            lblNewPassValidate.Text = "";
            ValidPasswordCheck();
        }

        private void ValidPasswordCheck()
        {
            if (txtNewPassword.Text.ToString() != txtNewConfirm.Text.ToString())
            {
                lblNewPassValidate.Text = "Passwords do not match";
                validPassword = false;
            }
            else if (txtNewConfirm.Text.ToString() == "")
            {
                lblNewPassValidate.Text = "Password cannot be empty";
                validPassword = false;
            }
            else if (txtNewConfirm.Text.ToString().Length < 6)
            {
                lblNewPassValidate.Text = "Password has to be longer then 6 characters";
                validPassword = false;
            }
            else
            {
                validPassword = true;
            }

        }

        private void chxShowCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (chxShowCurrent.Checked == true)
            {
                txtCurrentPassword.UseSystemPasswordChar = false;
                txtCurrentPassword.PasswordChar = '\0';
            }
            else
            {
                txtCurrentPassword.UseSystemPasswordChar = true;
                txtCurrentPassword.PasswordChar = '●';
            }
        }

        private void chxShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chxShowNewPassword.Checked == true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewConfirm.UseSystemPasswordChar = false;
                txtNewPassword.PasswordChar = '\0';
                txtNewConfirm.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewConfirm.UseSystemPasswordChar = true;
                txtNewPassword.PasswordChar = '●';
                txtNewConfirm.PasswordChar = '●';
            }
        }
    }
}
