using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace NEA_Prototype
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessLevel { get; set; }
        public const string Database_Connection_String = "..\\..\\Data\\MTDatabase.db";

        public string HashPassword(string password)
        {
            SHA256 hashingFunc = SHA256.Create();
            byte[] hashBytes = hashingFunc.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder hashPassword = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashPassword.Append(hashBytes[i].ToString("x2"));
            }

            password = hashPassword.ToString();
            return password;
        }

        public bool IsUsernameTaken(string username)
        {
            int rows = 0;
            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
            {
                dbConnection.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT COUNT(*) from LoginDetails WHERE lower(Username) = @Username", dbConnection);
                com.Parameters.AddWithValue("@Username", username.ToLower());
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rows = reader.GetInt32(0);
                    }
                }
                dbConnection.Close();

                if (rows == 0)
                {
                    return false;
                }
                return true;

            }

        }

        public bool IsEmailTaken(string email)
        {
            int rows = 0;
            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
            {
                dbConnection.Open();
                //selects the amount of occurances of that email
                SQLiteCommand com = new SQLiteCommand("SELECT COUNT(*) from LoginDetails WHERE lower(Email) = @Email", dbConnection);
                //adds the user entered email
                com.Parameters.AddWithValue("@Email", email.ToLower());

                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    //this returns the amount of rows
                    if (reader.Read())
                    {
                        rows = reader.GetInt32(0);
                    }
                }

                dbConnection.Close();
                //if rows is 0 then the email hasnt been used before
                if (rows == 0)
                {
                    return false;
                }

                return true;

            }
        }
        public bool IsMazeTaken(string maze)
        { 
            int rows = 0;
            
            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Database_Connection_String))
            {
                dbConnection.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT COUNT(*) from SavedMazes WHERE lower(MazeID) = @Maze", dbConnection);            
                com.Parameters.AddWithValue("@Maze", maze.ToLower());

                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rows = reader.GetInt32(0);
                    }
                }
                dbConnection.Close();

                if (rows == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
    

