using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPWCS
{
    public partial class UsersManagement : Form
    {
        User u;
        public UsersManagement(User u)
        {
            this.u = u;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(552, 401);
            this.CenterToScreen();
            InitializeComponent();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddUser Add = new AddUser(this);
            Add.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login Lg = new Login();
            Lg.ShowDialog();
            u.Close();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            u.Visible = true;
            this.Close();
        }

        private void ShowUsers_Click(object sender, EventArgs e)
        {
           if (String.Equals(this.ShowUsers.Text.ToString(), "Show Users", StringComparison.Ordinal))
            {
                this.ShowUsers.Text = "Hide Users";
                this.DataGridOfAllUsers.Visible = true;

                UserFunctions.showUsers();

                this.DataGridOfAllUsers.Refresh();
                this.DataGridOfAllUsers.DataSource = UserFunctions.showUsers(); ;
            }
            else
            {
                this.ShowUsers.Text = "Show Users";
                this.DataGridOfAllUsers.Visible = false;
            }            
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DeleteUser Del = new DeleteUser(this);
            Del.ShowDialog();
        }

        private void ChangeAccessPermission_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AccessPermission Del = new AccessPermission(this);
            Del.ShowDialog();
        }
    }
}
