using System;
using System.Data.SQLite;
using System.Windows.Forms;
namespace NEA_Prototype
{
    public partial class frmUserLogin : Form
    {
        public const string Database_Connection_String = "..\\..\\Data\\MTDatabase.db";

        public frmUserLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form control changes
        /// </summary>
    
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCreateAccount CreateNewUser = new frmCreateAccount();
            CreateNewUser.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUserLogin();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CheckUserLogin();
            }
        }

        private void chxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chxShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '●';

            }
        }

        /// <summary>
        /// User login authorisation
        /// </summary>
       
        private void CheckUserLogin()
        {
            User userLogin = new User();
            userLogin.Password = userLogin.HashPassword(txtPassword.Text.ToString()); //hashes the inputted password
            userLogin.Username = txtUsername.Text.ToString();
            string givenUsernamePass = "";

            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
            {
                dbConnection.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT Password FROM LoginDetails WHERE Username = @Username", dbConnection);
                //selects the password from the users inputted username
                com.Parameters.AddWithValue("@Username", userLogin.Username);
                //adds username as the parameter in the above statement
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())//checks to see if a row has been selected
                    {
                        givenUsernamePass = reader.GetString(0);
                    }
                }
                dbConnection.Close();
            }

            //checks the hashed password
            if (givenUsernamePass == userLogin.Password)               
            {
                this.Close();
                frmMazeTraverser mainForm = (frmMazeTraverser)ActiveForm;
                mainForm.Enabled = true;
                mainForm.showUserDetails(userLogin);
                mainForm.RandomMaze();
            }

            else
            {
                lblIncorrectLogin.Text = "Incorrect username or password"; //displays this error message
            }
        }

       
    }
}
