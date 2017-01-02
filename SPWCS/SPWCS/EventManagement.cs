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
    public partial class EventManagement : Form
    {
        //int user_type = -1;
        public User userWindow=null;
        public EventManagement( User userWindow )
        {
            //user_type = i;
            this.userWindow = userWindow;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(469, 363);
            this.CenterToScreen();
            InitializeComponent();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddEvent Add = new AddEvent(this);
            Add.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.userWindow.Visible = true;
            this.Close();
        }

        private void DeleteEventButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DeleteEvent Del = new DeleteEvent(this);
            Del.ShowDialog();
        }

        private void ModifyEventButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModifyEvent modifyEvent = new ModifyEvent(this);
            modifyEvent.ShowDialog();

        }

        private void showEventButton_Click(object sender, EventArgs e)
        {
            if (String.Equals(this.showEventButton.Text.ToString(), "Show Events", StringComparison.Ordinal))
            {
                this.showEventButton.Text = "Hide Events";
                this.eventsDataGrid.Visible = true;
                this.toPDFButton.Visible = true;
                DataTable dt = EventFunctions.showEvents();
                this.eventsDataGrid.Refresh();
                this.eventsDataGrid.DataSource = dt;
            }
            else
            {
                this.showEventButton.Text = "Show Events";
                this.eventsDataGrid.Visible = false;
                this.toPDFButton.Visible = false;
            }
        }

        private void toPDFButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String filename = "listOfActualEvents_" + now.ToString("dd-MM-yyyy");
            PDFConverter.exportToPDF(eventsDataGrid, filename);
        }
    }
}
