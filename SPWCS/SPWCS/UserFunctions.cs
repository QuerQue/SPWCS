using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

using System.Data;


namespace SPWCS
{
    class UserFunctions
    {
        public static string checkPassword(String login, String password)
        {
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Password, UserType, Pesel FROM Users WHERE Login ='" + login + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User doesn't exist");
                return null;
            }
            else
            {
                if (String.Equals(password, dt.Rows[0][0].ToString(), StringComparison.Ordinal))
                {
                    return dt.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    return null;
                }
            }
        }

        public static int getType(String pesel)
        {
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT UserType FROM Users WHERE '" + pesel + "' LIKE Pesel", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int type = Int32.Parse(dt.Rows[0][0].ToString());

            return type;
        }

        public static void addNewUser(String pesel, String name, String surname, String login, String password1, String password2, String type)
        {
            SqlConnection con = Connecter.connect();
            //con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\habr\system_planowania_w_centrum_szkoleniowym\SPWCS\SPWCS\DB.mdf;Integrated Security=True";
         
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO [PersonalData] VALUES(@Pesel, @Name, @Surename); INSERT INTO [Users] VALUES(@Pesel, @Login, @Password, @UserType);";
            cmd.Parameters.AddWithValue("@Pesel", pesel);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Surename", surname);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password1);
            Match match = Regex.Match(password1, @"(?:[A-Z].*[0-9])|(?:[0-9].*[A-Z])");

            int numUserType = 2;
            if (type == "Supervisor")
                numUserType = 1;
            else if (type == "Admin")
                numUserType = 0;

            cmd.Parameters.AddWithValue("@UserType", numUserType);

            //TODO sprawdzic czy istnieje podany pesel i login

            if (pesel.Length == 0 || name.Length == 0 || surname.Length == 0 || login.Length == 0 || password1.Length == 0 || type.Length == 0)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!");
            }
            else if (password1.Length < 6)
            {
                MessageBox.Show("Hasła musi mieć conajmniej 6 znaków");
            }
            else if (!match.Success)
            {
                MessageBox.Show("Hasło musi zawierać conajmniej 1 cyfrę, 1 znak specjalny i 1 dużą literę");
            }
            else if (password1 != password2)
            {
                MessageBox.Show("Podane hasla sa rozne");
            }
            else if (pesel.Length != 11)
            {
                if (pesel.Length < 11)
                    MessageBox.Show("Podany pesel jest za krótki");
                else
                    MessageBox.Show("Podany pesel jest za długi");
            }
                
            else
            {
                cmd.Connection = con;

                try
                {
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("User added successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static DataTable showUsers()
        {
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Users.Pesel, PersonalData.Name, PersonalData.Surename, Users.Login, Users.UserType FROM Users INNER JOIN PersonalData ON Users.Pesel=PersonalData.Pesel", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public static void deleteUser(String login)
        {
            SqlConnection con = Connecter.connect();
            con.Open();

            if (login == "Admin")
            {
                MessageBox.Show("Please don't.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pesel;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Users.Pesel FROM Users WHERE Users.Login='" + login + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User doesn't exist");
                return;
            }
            else
            {
                pesel = dt.Rows[0][0].ToString();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [Users] WHERE [Pesel]=@Pesel; DELETE FROM [PersonalData] WHERE [Pesel]=@Pesel;";
            cmd.Parameters.AddWithValue("@Pesel", pesel);
            cmd.Connection = con;
            try
            {
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("User deleted.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Error: no such user.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void changeAccesPermission(String login, String newType, int actualType)
        {
            int numUserType = 2;
            if (newType == "Supervisor")
                numUserType = 1;
            else if (newType == "Admin")
                numUserType = 0;

            if (actualType == 0)
            {
                MessageBox.Show("Please don't.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SqlConnection con = Connecter.connect();
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET UserType = '" + numUserType + "' WHERE Login = '" + login + "'", con);
                cmd.Connection = con;
                try
                {
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Access permission changed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static DataTable showUserInfo(String login)
        {
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Users.Login, PersonalData.Name, PersonalData.Surename, Users.UserType FROM Users INNER JOIN PersonalData ON Users.Pesel = PersonalData.Pesel WHERE Users.Login='" + login + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

    }
}
