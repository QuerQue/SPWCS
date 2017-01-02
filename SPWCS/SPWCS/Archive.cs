using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace SPWCS
{
    public partial class Archive : Form
    {
        User userWindow;
        public Archive(User userWindow)
        {
            this.userWindow = userWindow;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(552, 401);
            this.CenterToScreen();
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.userWindow.Visible = true;
            this.Close();
        }

        private void MoveToArchive_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MoveToArchive Add = new MoveToArchive(this, userWindow.userPesel);
            Add.ShowDialog();
        }

        private void showArchiveButton_Click(object sender, EventArgs e)
        {
            if (String.Equals(this.showArchiveButton.Text.ToString(), "Show Archive", StringComparison.Ordinal))
            {
                this.archiveDataGrid.Visible = true;
                this.toPDFButton.Visible = true;

                this.showArchiveButton.Text = "Hide Archive";
                this.showCurrentEventsButton.Text = "Show Current Events";
                DataTable dt = ArchiveFunctions.showArchive();
                
                this.archiveDataGrid.Refresh();
                this.archiveDataGrid.DataSource = dt;
            }
            else
            {
                this.showArchiveButton.Text = "Show Archive";
                this.showCurrentEventsButton.Text = "Show Current Events";
                this.archiveDataGrid.Visible = false;
                this.toPDFButton.Visible = false;

            }
        }

        private void ShowCurrentEvents_Click(object sender, EventArgs e)
        {
            this.archiveDataGrid.Refresh();

            if (String.Equals(this.showCurrentEventsButton.Text.ToString(), "Show Current Events", StringComparison.Ordinal))
            {
                this.archiveDataGrid.Visible = true;
                this.toPDFButton.Visible = true;
                this.showCurrentEventsButton.Text = "Hide Current Events";
                this.showArchiveButton.Text = "Show Archive";
                DataTable dt = EventFunctions.showEvents();
                this.archiveDataGrid.Refresh();
                this.archiveDataGrid.DataSource = dt;
            }
            else
            {
                this.showCurrentEventsButton.Text = "Show Current Events";
                this.showArchiveButton.Text = "Show Archive";
                this.archiveDataGrid.ClearSelection();
                this.archiveDataGrid.Visible = false;
                this.toPDFButton.Visible = false;
            }
        }

        private void toPDFButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String filename = "listOfPastEvents_" + now.ToString("dd-MM-yyyy");
            PDFConverter.exportToPDF(archiveDataGrid, filename);
        }
    }
}
