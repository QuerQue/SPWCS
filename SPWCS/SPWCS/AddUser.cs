using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPWCS
{
    public partial class AddUser : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        UsersManagement userWindow = null;

        public AddUser(UsersManagement userWindow)
        {
            this.userWindow = userWindow;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(300, 380);
            this.CenterToScreen();
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            userWindow.Visible = true;
            this.Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserFunctions.addNewUser(peselTB.Text, nameTB.Text, surnameTB.Text, loginTB.Text, password1TB.Text, password2TB.Text, typesCB.Text);
        }
    }
}
