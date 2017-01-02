using System;
using System.Windows.Forms;


namespace SPWCS
{
    public partial class MoveToArchive : Form
    {
        Archive archiveWindow;
        String pesel = null;
        public MoveToArchive(Archive archiveWindow, String pesel)
        {
            this.archiveWindow = archiveWindow;
            this.pesel = pesel;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.archiveWindow.Visible = true;
            this.Close();
        }

        private void archive_Click(object sender, EventArgs e)
        { 
            string eventID = EventsID.Text;
            ArchiveFunctions.archiveEvent(eventID, pesel);

            ArchiveFunctions.removeEvent(eventID);
            EventsID.Clear();
        }

    }
}
