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
    public partial class AddEvent : Form
    {

        String dateStart;
        String dateEnd;
        EventManagement eventMangWindow = null;
        ArrayList listExtras = new ArrayList();
        ArrayList listSelectedExtras = new ArrayList();
        ArrayList listSelectedClassrooms = new ArrayList();

        public AddEvent(EventManagement eventMangWindow)
        {
            this.eventMangWindow = eventMangWindow;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(556, 425);
            this.CenterToScreen();
            InitializeComponent();

            addRoomButton.Enabled = false;
            addExtrasButton.Enabled = false;

            for (int k = 0; k <= 23; k++)
            {
                string w = "0";
                if (k < 10) w = "0" + k;
                else w = "" + k;

                comboBox3.Items.Add(w);
            }

            for (int k = 0; k <= 23; k++)
            {
                string w = "0";
                if (k < 10) w = "0" + k;
                else w = "" + k;

                comboBox4.Items.Add(w);
            }

            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.eventMangWindow.Visible = true;
            this.Close();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            bool res = EventFunctions.addEvent(NameOfEventBox.Text, ShortInfoBox.Text, DescriptionBox.Text, dateStart, dateEnd, eventMangWindow.userWindow.userPesel, this.listSelectedExtras, this.listSelectedClassrooms);
            if (res)
            {
                MessageBox.Show("This event has been added ");
                clearAll();
            }
        }

        void  fillRoomsAndExtras(string dateStart, string dateEnd)
        {   
             ArrayList rooms = new ArrayList();
             rooms = EventFunctions.getAvailableClassrooms(dateStart, dateEnd);
             foreach (object room in rooms)
                 comboBox1.Items.Add(room);

            DataTable dtextras = EventFunctions.getAvailableExtras(dateStart, dateEnd);
            for (int i = 0; i < dtextras.Rows.Count; i++)
            {
                comboBox2.Items.Add(dtextras.Rows[i][1]);
                listExtras.Add(Int32.Parse(dtextras.Rows[i][0].ToString()));
            }
            addRoomButton.Enabled = true;
            addExtrasButton.Enabled = true;
        }

        private void setTime_Click(object sender, EventArgs e)
        {
            dateStart = DateStartPicker.Value.ToString("yyyy-MM-dd");
            dateEnd = DateOfEndPicker.Value.ToString("yyyy-MM-dd");
            
            dateStart = dateStart+" "+comboBox3.SelectedItem.ToString()+":00:00";
            dateEnd = dateEnd + " " + comboBox4.SelectedItem.ToString() + ":00:00";

            //MessageBox.Show(dateStart + " ;;; " + dateEnd);
            if (String.CompareOrdinal(dateStart, dateEnd) >= 0)
                MessageBox.Show("Date of end cannot be before date of start.");
            else
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                listExtras.Clear();
                listSelectedExtras.Clear();
                listSelectedClassrooms.Clear();
                fillRoomsAndExtras(dateStart, dateEnd);
            }

          //  MessageBox.Show(dateStart);
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listSelectedClassrooms.Add(comboBox1.SelectedItem);
                int a = comboBox1.SelectedIndex;
                comboBox1.Items.RemoveAt(a);
            }
        }

        private void addExtrasButton_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                listSelectedExtras.Add(listExtras[comboBox2.SelectedIndex]);
                int a = comboBox2.SelectedIndex;
                comboBox2.Items.RemoveAt(a);
                listExtras.RemoveAt(a);
            }
        }

        void clearAll()
        {
            NameOfEventBox.Clear();
            ShortInfoBox.Clear();
            DescriptionBox.Clear();
            DateStartPicker.ResetText();
            DateOfEndPicker.ResetText();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            listExtras.Clear();
            listSelectedExtras.Clear();
            listSelectedClassrooms.Clear();
            addRoomButton.Enabled = false;
            addExtrasButton.Enabled = false;
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
