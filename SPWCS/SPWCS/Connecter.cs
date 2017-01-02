using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPWCS
{
    class Connecter
    {
        public static SqlConnection connect()
        {
            string startuppath = (Application.StartupPath).Replace(@"\bin\Debug", "");
            string tempstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + startuppath + @"\DB.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(tempstr);
            ArchiveFunctions.moveOldEventsToArchive(con);

            return new SqlConnection(tempstr);
        }

    }
}
