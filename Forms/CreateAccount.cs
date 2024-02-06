using Dapper;
using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NEA_Prototype
{
    public partial class frmCreateAccount : Form
    {
        bool validUsername = false;
        bool validEmail = false;
        bool validPassword = false;
        User newUser = new User();
        public const string Database_Connection_String = "..\\..\\Data\\MTDatabase.db";

        public frmCreateAccount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form controls changes
        /// </summary>

        private void txtRegUsername_TextChanged_1(object sender, EventArgs e)
        {
            lblUsernameError.Text = "";
            UsernameCheck();
        }

        private void txtRegEmail_TextChanged_1(object sender, EventArgs e)
        {
            lblEmailError.Text = "";
            bool realEmail = IsValidEmail();
            EmailCheck(realEmail);
        }

        private void txtRegPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtRegPassword.UseSystemPasswordChar = true;
            txtRegPassword.PasswordChar = '●';
            lblPasswordError.Text = "";
            PasswordCheck();

        }

        private void txtRegCPassword_TextChanged(object sender, EventArgs e)
        {
            txtRegCPassword.UseSystemPasswordChar = true;
            txtRegCPassword.PasswordChar = '●';
            lblPasswordError.Text = "";
            PasswordCheck();
        }

        private void cbxAccessLevel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RegisterValidCheck();
        }

        public void btnSignUp_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Username = txtRegUsername.Text.ToString().Trim(),
                Email = txtRegEmail.Text.ToString().Trim()
            };

            //this is hashing the password using SHA256
            newUser.Password = newUser.HashPassword(txtRegPassword.Text.ToString());
            newUser.AccessLevel = cbxAccessLevel.SelectedItem.ToString();

            //the connection string isd the connection ot the database
            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
            {
                dbConnection.Open();
                //this is the SQL command to insert the values into the database
                dbConnection.Execute(@"INSERT INTO LoginDetails(Username, Email, Password, AccessLevel)
                VALUES ( @Username, @Email, @Password, @AccessLevel); select last_insert_rowid()", newUser);
                dbConnection.Close();

            }

            this.Validate();

            this.Close();
            frmUserLogin Login = new frmUserLogin();
            Login.Show();
        }

        private void chxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chxShowPassword.Checked == true)
            {
                txtRegCPassword.UseSystemPasswordChar = false;
                txtRegPassword.UseSystemPasswordChar = false;

                txtRegPassword.PasswordChar = '\0';
                txtRegCPassword.PasswordChar = '\0';
            }
            else
            {
                txtRegCPassword.UseSystemPasswordChar = true;
                txtRegPassword.UseSystemPasswordChar = true;
                txtRegPassword.PasswordChar = '●';
                txtRegCPassword.PasswordChar = '●';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUserLogin login = new frmUserLogin();
            login.Show();
        }

        /// <summary>
        /// Create account authorisation and check
        /// </summary>

        private void UsernameCheck()
        {
            bool TakenUsername = newUser.IsUsernameTaken(txtRegUsername.Text.ToString().Trim());
            btnSignUp.Enabled = false;

            

            if (txtRegUsername.Text.ToString() == "")
            {
                lblUsernameError.Text = "Username cannot be empty";
                validUsername = false;
            }
            else if (TakenUsername)
            {
                lblUsernameError.Text = "Username is already taken";
                validUsername = false;
            }

            else 
            {
                validUsername = true;
                RegisterValidCheck();
            }
        }

        private void EmailCheck(bool realEmail)
        {
            bool TakenEmail = newUser.IsEmailTaken(txtRegEmail.Text.ToString().Trim());

            btnSignUp.Enabled = false;
            if (txtRegEmail.Text.ToString() == "")
            {
                lblEmailError.Text = "Email cannot be empty";
                validEmail = false;
            }
            else if (TakenEmail)
            {
                lblEmailError.Text = "Email is already taken";
                validEmail = false;
                // add the email taken check
            }
            else if (realEmail == false)
            {
                lblEmailError.Text = "Email is in incorrect format"; // add the email taken check
                validEmail = false;

            }
            else
            {
                validEmail = true;
                RegisterValidCheck();
            }

        }

        private void PasswordCheck()
        {
            btnSignUp.Enabled = false;
            if (txtRegCPassword.Text.ToString() != txtRegPassword.Text.ToString())
            {
                lblPasswordError.Text = "Passwords do not match";
                validPassword = false;
            }
            else if (txtRegPassword.Text.ToString() == "")
            {
                lblPasswordError.Text = "Password cannot be empty";
                validPassword = false;
            }
            else if (txtRegPassword.Text.ToString().Length < 6)
            {
                lblPasswordError.Text = "Password has to be longer then 6 characters";
                validPassword = false;
            }
            else
            {
                validPassword = true;
                RegisterValidCheck();
            }

        }

        private void RegisterValidCheck()
        {
            
            if (validEmail == true && validPassword == true && validUsername == true && cbxAccessLevel.Text != "")
            {
                btnSignUp.Enabled = true;
            }
            else
            {
                btnSignUp.Enabled = false;
            }
        }

        bool IsValidEmail()
        {
            string emailChecker = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string userEmail = txtRegEmail.Text;

            if (Regex.IsMatch(userEmail.Trim(), emailChecker))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
