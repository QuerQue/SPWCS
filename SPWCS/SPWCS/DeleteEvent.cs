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
using System.Collections;

namespace SPWCS
{
    public partial class DeleteEvent : Form
    {
        EventManagement evmWindow = null;
        int[] idtab;

        public DeleteEvent(EventManagement evmWindow)
        {
            this.evmWindow = evmWindow;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(556, 425);
            this.CenterToScreen();
            InitializeComponent();

            startupcombobox();
        }

        private void startupcombobox()
        {
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name, Id FROM Events", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            eventcomboBox.Items.Clear();
            eventcomboBox.Text = "";
            idtab = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                eventcomboBox.Items.Add(dt.Rows[i][0]);
                idtab[i] = Int32.Parse(dt.Rows[i][1].ToString());
            }

            con.Close();

            eventcomboBox.SelectedIndex = -1;
            DeleteButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.evmWindow.Visible = true;
            this.Close();
        }

        private void eventcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(eventcomboBox.SelectedIndex < 0)
            {
                DeleteButton.Enabled = false;
            }
            else
            {
                DeleteButton.Enabled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EventFunctions.deleteEvent(idtab[eventcomboBox.SelectedIndex], evmWindow.userWindow.userPesel);
            startupcombobox();
        }
    }
}
