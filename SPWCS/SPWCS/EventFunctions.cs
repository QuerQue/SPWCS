using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

using System.Data;

namespace SPWCS
{
    class EventFunctions
    {
        public static DataTable showEvents()
        {
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Events.Id, Events.name, Events.short_info, Events.date_start, Events.date_end  FROM Events ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static bool addEvent(String name, String short_info, String full_desc, String date_start, String date_end, String pesel, ArrayList listSelectedExtras, ArrayList listSelectedClassrooms )
        {
            SqlConnection con =Connecter.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            bool res = true;
            int nr = 0;

            try
            {

                SqlDataAdapter key = new SqlDataAdapter("SELECT MAX(Id) FROM Events", con);
                DataTable dt = new DataTable();
                key.Fill(dt);

                cmd.CommandText = "INSERT INTO [Events] VALUES(@Id, @name, @short_info, @full_description, @date_start, @date_end, @peselID)";

                DateTime datetimeStart;
                DateTime.TryParse(date_start, out datetimeStart);
                DateTime datetimeEnd;
                DateTime.TryParse(date_end, out datetimeEnd);

                try
                {
                    nr = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
                }
                catch { }

                cmd.Parameters.AddWithValue("@Id", nr);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@short_info", short_info);
                cmd.Parameters.AddWithValue("@full_description", full_desc);
                cmd.Parameters.AddWithValue("@date_start", datetimeStart);
                cmd.Parameters.AddWithValue("@date_end", datetimeEnd);
                cmd.Parameters.AddWithValue("@peselID", pesel);


                cmd.Connection = con;
                int affectedRows = cmd.ExecuteNonQuery();

                foreach (int el in listSelectedExtras)
                {
                    cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO [Events_Extras] VALUES(@eventID, @extrasID)";
                    cmd.Parameters.AddWithValue("@eventID", nr);
                    cmd.Parameters.AddWithValue("@extrasID", el);
                    cmd.Connection = con;
                    affectedRows = cmd.ExecuteNonQuery();
                }
                foreach (int el in listSelectedClassrooms)
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
                MessageBox.Show("Fill all fields.");
            }

            con.Close();

            if (res)
            {
                Log log = Log.Instance;
                log.dropLog(pesel, "Event added ID = "+nr+" Name: "+name);
            }

            return res;

        }

        public static ArrayList getAvailableClassrooms(string dateStart, string dateEnd)
        {
            ArrayList classrooms = new ArrayList();
           
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT classroomID FROM Events JOIN Events_Classrooms ON Events.Id = Events_Classrooms.EventID WHERE '" + dateStart + "'>=date_start AND '" + dateStart + "'<=date_end OR '" + dateEnd + "'>=date_start AND '" + dateEnd + "'<=date_end OR '" + dateStart + "'<=date_start AND '" + dateEnd + "'>=date_end", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Classrooms", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);



            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                Boolean flag = true;
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    if (Int32.Parse(dt2.Rows[i][0].ToString()) == Int32.Parse(dt.Rows[row][0].ToString()))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    // comboBox1.Items.Add(dt2.Rows[i][0]);
                    classrooms.Add(dt2.Rows[i][0]);
            }
            con.Close();
            return classrooms;
        }
        public static DataTable getAvailableExtras(string dateStart, string dateEnd)
        {
       
            SqlConnection con = Connecter.connect();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Events_Extras.extrasID FROM Events JOIN Events_Extras ON Events.Id = Events_Extras.eventID WHERE '" + dateStart + "'>=Events.date_start AND '" + dateStart + "'<=Events.date_end OR '" + dateEnd + "'>=Events.date_start AND '" + dateEnd + "'<=Events.date_end OR '" + dateStart + "'<=Events.date_start AND '" + dateEnd + "'>=Events.date_end", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Extras", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            DataTable dtextas = new DataTable();

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                Boolean flag = false;
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    if (Int32.Parse(dt2.Rows[i][0].ToString()) == Int32.Parse(dt.Rows[row][0].ToString()))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    dt2.Rows.RemoveAt(i);
            }
            con.Close();
            return dt2;
        }

        public static void deleteEvent( int id, String pesel)
        {
            bool res = true;
            SqlConnection con = Connecter.connect();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            string del1 = "DELETE FROM Events_Classrooms WHERE eventID = " + id;
            string del2 = "DELETE FROM Events_Extras WHERE eventID = " + id;
            string del3 = "DELETE FROM Events WHERE ID = " + id;
            //string del3 = "DELETE FROM Events WHERE ID = @evid";
            cmd.Parameters.AddWithValue("@evid", id);
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
                res = false;
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
                res = false;
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // deleting from Events table
            try
            {
                cmd.CommandText = del3;
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Event deleted.", Application.ProductName, MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                res = false;
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if( res)
            {
                Log log = Log.Instance;
                log.dropLog(pesel, "Event removed ID = " + id );
            }
            con.Close();
        }
    }



}
