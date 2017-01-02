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
    public partial class CheckReservation : Form
    {

        private User userWindow;

        public string StartDate { get; private set; }
        public string EndDate { get; private set; }

        public CheckReservation(User user)
        {
            this.userWindow = user;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(570, 461);
            this.CenterToScreen();
            InitializeComponent();
            StartDate = StartDatePicker.Value.ToString("yyyy-MM-dd");
            EndDate = EndDatePicker.Value.ToString("yyyy-MM-dd");
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDate = StartDatePicker.Value.ToString("yyyy-MM-dd");
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDate = EndDatePicker.Value.ToString("yyyy-MM-dd");
        }

        private void ShowReservationButton_Click(object sender, EventArgs e)
        {
            if (String.Equals(this.ShowReservationButton.Text.ToString(), "Show these events", StringComparison.Ordinal))
            {
                this.ShowReservationButton.Text = "Hide these events";
                this.DataGridOfCheckReservation.Visible = true;
                this.pdfButton.Visible = true;
                SqlConnection con = Connecter.connect();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Events.Id, Events.name, Events.short_info, Events.date_start, Events.date_end  FROM Events ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                this.DataGridOfCheckReservation.Refresh();
                this.DataGridOfCheckReservation.DataSource = dt;
            }
            else
            {
                this.ShowReservationButton.Text = "Show these events";
                this.DataGridOfCheckReservation.ClearSelection();
                this.DataGridOfCheckReservation.Visible = false;
                this.pdfButton.Visible = false;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.userWindow.Visible = true;
            this.Close();
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            String filename = "reservation_" + StartDate + "_" + EndDate;
            PDFConverter.exportToPDF(DataGridOfCheckReservation, filename);
        }
    }
}
