using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SPWCS
{
    class ArchiveFunctions
    {

        public static DataTable showArchive()
        {
            SqlConnection con = Connecter.connect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT EventsArchive.Id, EventsArchive.name, EventsArchive.short_info, EventsArchive.date_start, EventsArchive.date_end  FROM EventsArchive ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public static void archiveEvent(string eventID,String pesel, bool show = true, SqlConnection con = null)
        {
            bool shouldClose = false;
            if (con == null)
            {
                shouldClose = true;
                con = Connecter.connect();
            }

            if (con.State == ConnectionState.Closed)
                con.Open();

            int id = 0;
            bool res = true;
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmdArch = new SqlCommand();
            string getClassrooms = "SELECT * FROM Events_Classrooms WHERE eventID = '" + eventID + "'";
            string getExtras = "SELECT * FROM Events_Extras WHERE eventID = '" + eventID + "'";
            string getEvent = "SELECT * FROM Events WHERE ID = '" + eventID + "'";

            cmd.Connection = con;
            cmdArch.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(Id) FROM EventsArchive", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                id = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
            }
            catch { }

            sda = new SqlDataAdapter(getEvent, con);
            dt.Reset();
            sda.Fill(dt);


            DateTime datetimeStart;
            DateTime datetimeEnd;

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DateTime.TryParse(dr.ItemArray[4].ToString(), out datetimeStart);
                    DateTime.TryParse(dr.ItemArray[5].ToString(), out datetimeEnd);
                    cmdArch.CommandText = "INSERT INTO [EventsArchive] VALUES( '" + id + "','" + dr.ItemArray[1] + "','" + dr.ItemArray[2] + "','" + dr.ItemArray[3] + "','" + datetimeStart.ToString("yyyy-MM-dd") + "','" + datetimeEnd.ToString("yyyy-MM-dd") + "','" + dr.ItemArray[6] + "')";

                    try
                    {
                        int affectedRows = cmdArch.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {

                        }
                        else
                        {
                            res = false;
                            MessageBox.Show("Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                sda = new SqlDataAdapter(getExtras, con);
                dt.Reset();
                sda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmdArch.CommandText = "INSERT INTO [Events_ExtrasArch] VALUES( '" + id + "','" + dr.ItemArray[1] + "')";

                        try
                        {
                            int affectedRows = cmdArch.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {

                            }
                            else
                            {
                                res = false;
                                MessageBox.Show("Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                sda = new SqlDataAdapter(getClassrooms, con);
                dt.Reset();
                sda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmdArch.CommandText = "INSERT INTO [Events_ClassroomsArch] VALUES( '" + id + "','" + dr.ItemArray[1] + "')";

                        try
                        {
                            int affectedRows = cmdArch.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {

                            }
                            else
                            {
                                res = false;
                                MessageBox.Show("Error!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (res)
                {
                    if(show)
                        MessageBox.Show("Event has been moved to archive");
                    Log log = Log.Instance;
                    log.dropLog(pesel, "Event moved to archive ID = " + id);

                }
                else
                {
                    MessageBox.Show("some errors");
                }
            }
            else
            {
                MessageBox.Show("There is no event with this ID");
            }

            if (shouldClose)
                con.Close();


        }

        public static void moveOldEventsToArchive(SqlConnection con, String pesel = null)
        {
            DateTime now = new DateTime();
            now = DateTime.Now;

            //SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, date_end FROM Events WHERE '" + now.ToString() + "'>Events.date_end", con);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, date_end FROM Events WHERE getdate() >Events.date_end", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                archiveEvent(dt.Rows[i][0].ToString(), pesel, false, con);
                removeEvent(dt.Rows[i][0].ToString(), con);
            }

        }
        public static void removeEvent(string eventID, SqlConnection con = null)
        {
            bool shouldClose = false;
            if (con == null)
            {
                shouldClose = true;
                con = Connecter.connect();
                con.Open();
            }
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            string del1 = "DELETE FROM Events_Classrooms WHERE eventID = '" + eventID + "'";
            string del2 = "DELETE FROM Events_Extras WHERE eventID = '" + eventID + "'";
            string del3 = "DELETE FROM Events WHERE ID = '" + eventID + "'";
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
                    // MessageBox.Show("Event deleted.", Application.ProductName, MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (shouldClose)
                con.Close();
        }

    }
}
