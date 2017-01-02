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
    public partial class ModifyEvent : Form
    {
        String dateStart;
        String dateEnd;

        string peselID_temp;
        string name_temp;

        ArrayList listExtras = new ArrayList();
        ArrayList listSelectedExtras = new ArrayList();
        ArrayList listSelectedClassrooms = new ArrayList();

        int[] idtab;
        EventManagement window = null;
        public ModifyEvent(EventManagement window)
        {
            this.window = window;
            this.BackgroundImage = FormPrepare.ConvertToBitmap(@"background.jpg");
            this.Size = new Size(556, 425);
            this.CenterToScreen();
            InitializeComponent();

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

            startupcombobox();
        }

        private void startupcombobox()
        {
            /*
            string startuppath = (Application.StartupPath).Replace(@"\bin\Debug", "");
            string tempstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + startuppath + @"\DB.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(tempstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name, Id FROM Events", con);
            */
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT name, Id FROM Events", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            modifyComboBox.Items.Clear();
            modifyComboBox.Text = "";
            idtab = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                modifyComboBox.Items.Add(dt.Rows[i][0]);
                idtab[i] = Int32.Parse(dt.Rows[i][1].ToString());
            }

            con.Close();
            modifyComboBox.SelectedIndex = -1;
            ModifyButton.Enabled = false;
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            this.window.Visible = true;
            this.Close();
        }

        private void modifyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifyComboBox.SelectedIndex < 0)
            {
                ModifyButton.Enabled = false;
            }
            else
            {
                ModifyButton.Enabled = true;
                filleventdata();
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            /*
            string startuppath = (Application.StartupPath).Replace(@"\bin\Debug", "");
            string tempstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + startuppath + @"\DB.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection();
            */
            SqlConnection con = Connecter.connect();
            //con.ConnectionString = tempstr;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            bool res = true;
            int nr = 0;
            deleteEvent(con);

            try
            {

                SqlDataAdapter key = new SqlDataAdapter("SELECT MAX(Id) FROM Events", con);
                DataTable dt = new DataTable();
                key.Fill(dt);

                cmd.CommandText = "INSERT INTO [Events] VALUES(@Id, @name, @short_info, @full_description, @date_start, @date_end, @peselID)";
                //int nr = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
                nr = idtab[modifyComboBox.SelectedIndex];
                cmd.Parameters.AddWithValue("@Id", nr);
                cmd.Parameters.AddWithValue("@name", name_temp);
                cmd.Parameters.AddWithValue("@short_info", shortinfotbox.Text);
                cmd.Parameters.AddWithValue("@full_description", desctbox.Text);
                cmd.Parameters.AddWithValue("@date_start", dateStart);
                cmd.Parameters.AddWithValue("@date_end", dateEnd);
                cmd.Parameters.AddWithValue("@peselID", peselID_temp);


                cmd.Connection = con;
                int affectedRows = cmd.ExecuteNonQuery();

                foreach (int el in this.listSelectedExtras)
                {
                    cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO [Events_Extras] VALUES(@eventID, @extrasID)";
                    cmd.Parameters.AddWithValue("@eventID", nr);
                    cmd.Parameters.AddWithValue("@extrasID", el);
                    cmd.Connection = con;
                    affectedRows = cmd.ExecuteNonQuery();
                }
                foreach (int el in this.listSelectedClassrooms)
                {
                    cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO [Events_Classrooms] VALUES(@eventID, @classroomID)";
                    cmd.Parameters.AddWithValue("@eventID", nr);
                    cmd.Parameters.AddWithValue("@classroomID", el);
                    cmd.Connection = con;
                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                res = false;
                
                MessageBox.Show(ex.ToString());
            }

            if (res)
            {
                Log log = Log.Instance;
                log.dropLog(peselID_temp, "Event modified ID = " + nr);
                MessageBox.Show("This event has been modified ");
                clearAll();

            }
            startupcombobox();
        }

        private void deleteEvent(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand();
            string del1 = "DELETE FROM Events_Classrooms WHERE eventID = " + idtab[modifyComboBox.SelectedIndex];
            string del2 = "DELETE FROM Events_Extras WHERE eventID = " + idtab[modifyComboBox.SelectedIndex];
            string del3 = "DELETE FROM Events WHERE ID = " + idtab[modifyComboBox.SelectedIndex];
            //string del3 = "DELETE FROM Events WHERE ID = @evid";
            cmd.Parameters.AddWithValue("@evid", idtab[modifyComboBox.SelectedIndex]);
            cmd.Connection = con;


            // Three step deletion for three tables in database
            // delete the connections between Events and Events_Classrooms
            try
            {
                cmd.CommandText = del1;
                int affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // delete the connections between Events and Events_Extras
            try
            {
                cmd.CommandText = del2;
                int affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // deleting from Events table
            try
            {
                cmd.CommandText = del3;
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    //MessageBox.Show("Event deleted.", Application.ProductName, MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void clearAll()
        {
            //.Clear();
            modifyComboBox.SelectedIndex = -1;
            shortinfotbox.Clear();
            desctbox.Clear();
            DateStartPicker.ResetText();
            DateOfEndPicker.ResetText();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            listExtras.Clear();
            listSelectedExtras.Clear();
            listSelectedClassrooms.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        void filleventdata()
        {
            /*
            string startuppath = (Application.StartupPath).Replace(@"\bin\Debug", "");
            string tempstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + startuppath + @"\DB.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(tempstr);
            */
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT date_start, date_end, short_info, full_description, name, peselID FROM Events WHERE Id = " + idtab[modifyComboBox.SelectedIndex] + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            name_temp = dt.Rows[0][4].ToString();
            peselID_temp = dt.Rows[0][5].ToString();

            string A = dt.Rows[0][0].ToString();
            string B = dt.Rows[0][1].ToString();

            dateStart = A;
            dateEnd = B;

            string hourA;
            string hourB;

            Console.WriteLine(A);
            Console.WriteLine(B);

            string[] dayA = null;
            dayA = A.Split(' ');
            hourA = dayA[1];
            dayA = dayA[0].Split('-');

            string[] dayB = null;
            dayB = B.Split(' ');
            hourB = dayB[1];
            
            dayB = dayB[0].Split('-');


            DateStartPicker.Value = new DateTime(Int32.Parse(dayA[0]), Int32.Parse(dayA[1]), Int32.Parse(dayA[2]));
            DateOfEndPicker.Value = new DateTime(Int32.Parse(dayB[0]), Int32.Parse(dayB[1]), Int32.Parse(dayB[2]));

            comboBox3.SelectedIndex = Int32.Parse(hourA.Split(':')[0]);
            comboBox4.SelectedIndex = Int32.Parse(hourB.Split(':')[0]);

            shortinfotbox.Text = dt.Rows[0][2].ToString();
            desctbox.Text = dt.Rows[0][3].ToString();

            con.Close();
        }

        private void setTime_Click(object sender, EventArgs e)
        {
            dateStart = DateStartPicker.Value.ToString("yyyy-MM-dd");
            dateEnd = DateOfEndPicker.Value.ToString("yyyy-MM-dd");

            dateStart = dateStart + " " + comboBox3.SelectedItem.ToString() + ":00:00";
            dateEnd = dateEnd + " " + comboBox4.SelectedItem.ToString() + ":00:00";

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

        void fillRoomsAndExtras(string dateStart, string dateEnd)
        {
            /*
            string startuppath = (Application.StartupPath).Replace(@"\bin\Debug", "");
            string tempstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + startuppath + @"\DB.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(tempstr);
            */
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT classroomID, Id FROM Events JOIN Events_Classrooms ON Events.Id = Events_Classrooms.EventID WHERE '" + dateStart + "'>=date_start AND '" + dateStart + "'<=date_end OR '" + dateEnd + "'>=date_start AND '" + dateEnd + "'<=date_end OR '" + dateStart + "'<=date_start AND '" + dateEnd + "'>=date_end", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Classrooms", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            int evidx = idtab[modifyComboBox.SelectedIndex];

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                Boolean flag = true;
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    Int32 a = Int32.Parse(dt2.Rows[i][0].ToString());
                    Int32 b = Int32.Parse(dt.Rows[row][0].ToString());
                    int dbeventid = Int32.Parse(dt.Rows[row][1].ToString());
                    if ((a == b) && (evidx != dbeventid) )
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    comboBox1.Items.Add(dt2.Rows[i][0]);
            }

            //sda = new SqlDataAdapter("SELECT * FROM Extras", con);  //TODO check available extras after time is choosen
            sda = new SqlDataAdapter("SELECT Events_Extras.extrasID, Id FROM Events JOIN Events_Extras ON Events.Id = Events_Extras.eventID WHERE '" + dateStart + "'>=Events.date_start AND '" + dateStart + "'<=Events.date_end OR '" + dateEnd + "'>=Events.date_start AND '" + dateEnd + "'<=Events.date_end OR '" + dateStart + "'<=Events.date_start AND '" + dateEnd + "'>=Events.date_end", con);
            dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);


            sda2 = new SqlDataAdapter("SELECT * FROM Extras", con);
            dt2.Clear();
            sda2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                Boolean flag = true;
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    Int32 a = Int32.Parse(dt2.Rows[i][0].ToString());
                    Int32 b = Int32.Parse(dt.Rows[row][0].ToString());
                    int dbeventid = Int32.Parse(dt.Rows[row][1].ToString());
                    if ((a == b) && (evidx != dbeventid))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    comboBox2.Items.Add(dt2.Rows[i][2]);
                    listExtras.Add(Int32.Parse(dt2.Rows[i][0].ToString()));
                }
            }

            button1.Enabled = true;
            button2.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listSelectedClassrooms.Add(comboBox1.SelectedItem);
                int a = comboBox1.SelectedIndex;
                comboBox1.Items.RemoveAt(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                listSelectedExtras.Add(listExtras[comboBox2.SelectedIndex]);
                int a = comboBox2.SelectedIndex;
                comboBox2.Items.RemoveAt(a);
                listExtras.RemoveAt(a);
            }
        }
    }
}
