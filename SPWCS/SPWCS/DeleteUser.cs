using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPWCS
{
    public partial class DeleteUser : Form
    {
        UsersManagement u;
        public DeleteUser(UsersManagement um)
        {
            this.u = um;
            this.CenterToScreen();
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            u.Visible = true;
            this.Close();
        }

        private void ConfirmDelete_Click(object sender, EventArgs e)
        {
            UserFunctions.deleteUser(logintbox.Text);
            
        }
    }
}
