using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPWCS
{

    public partial class User : Form
    {
 
        public string userPesel;

      /*  public Admin()
        {
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(552, 401);
            this.CenterToScreen();
            InitializeComponent();

        }*/

        public User( string pesel)
        {
        
            userPesel = pesel;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(552, 401);
            this.CenterToScreen();
            InitializeComponent();

            int type = UserFunctions.getType(pesel);
            switch (type)
            {
                case 0:   //Admin
                    break;
                case 1:    //Zarządca
                    Users.Visible = false;
                    break;
                default:  //Plebs
                    Users.Visible = false;
                    Archive.Visible = false;
                    break;
            }

          
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            Log log = Log.Instance;
            log.dropLog(userPesel, "Logged out" );
            this.Visible = false;
            Login Lg= new Login();
            Lg.ShowDialog();
            this.Close();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UsersManagement Um = new UsersManagement(this);
            Um.ShowDialog();
        }

        private void Events_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EventManagement Ev = new EventManagement(this);
            Ev.ShowDialog();
           // this.Close();
        }

        private void Archive_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Archive Um = new Archive(this);
            Um.ShowDialog();
        }

        private void CheckReservation_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CheckReservation Check = new CheckReservation(this);
            Check.ShowDialog();
        }
    }
}
