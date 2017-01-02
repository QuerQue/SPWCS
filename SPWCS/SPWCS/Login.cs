using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SPWCS
{
    public partial class Login : Form
    {
        public Login()
        {
            string a = @"\bin\Debug";
            string res = (Application.StartupPath).Replace(a, "");
            System.Console.Write(Application.StartupPath);
            System.Console.Write(res);
            this.CenterToScreen();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            log();
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                log();
        }
        private void log()
        {
            String pesel = UserFunctions.checkPassword(loginTB.Text, passwordTB.Text);
            if (pesel != null)
            {
                this.Visible = false;
                User Adm = new User(pesel);

                Log log = Log.Instance;
                log.dropLog(pesel, "Logged in");

                Adm.ShowDialog();
                this.Close();
                
            }
    
        }

 
    }
}
