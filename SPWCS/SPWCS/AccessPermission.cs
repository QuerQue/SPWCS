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
    public partial class AccessPermission : Form
    {
        UsersManagement um;
        string login;
        int ut;
        public AccessPermission(UsersManagement um)
        {
            this.um = um;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.CenterToScreen();
            InitializeComponent();
            this.loginBox1.KeyDown += new KeyEventHandler(loginBox_KeyDown);
            Name.Visible = false;
            AccessPerm.Visible = false;
            selectAccessPermission.Visible = false;
            typesCB.Visible = false;
            changeButton.Enabled = false;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            um.Visible = true;
            this.Close();
        }

        private void loginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeButton.Enabled = false;

                DataTable dt = UserFunctions.showUserInfo(loginBox1.Text);
                        
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("User doesn't exist");
                    return;
                }
                else
                {
                    changeButton.Enabled = true;
                    login = dt.Rows[0][0].ToString();
                    Name.Text = "Name: " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                    Name.Visible = true;
                    ut = Convert.ToInt32(dt.Rows[0][3].ToString());
                    switch (ut)
                    {
                        case 0:
                            AccessPerm.Text = "Access permission: Admin";
                            break;
                        case 1:
                            AccessPerm.Text = "Access permission: Supervisor";
                            break;
                        default:
                            AccessPerm.Text = "Access permission: Employee";
                            break;
                    }
                    AccessPerm.Visible = true;
                    selectAccessPermission.Visible = true;
                    typesCB.Visible = true;
                }

            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            UserFunctions.changeAccesPermission(login, typesCB.Text, ut);
            AccessPerm.Text = "Access permission: " + typesCB.Text;
        }
    }
}
