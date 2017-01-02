using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPWCS
{
    public sealed class Log
    {
        private static Log m_oInstance = null;

        public static Log Instance
        {
            get
            {
                if (m_oInstance == null)
                {
                    m_oInstance = new Log();
                }
                return m_oInstance;
            }
        }

        public void dropLog(String pesel, String text )
        {
            DateTime now = new DateTime();
            now = DateTime.Now;

            string startuppath = (Application.StartupPath).Replace(@"\bin\Debug", "");
            string folderpath = startuppath + "" + @"\..\Logs\";
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(startuppath + "" + @"\..\Logs\");
            }
            StreamWriter sw = new StreamWriter((folderpath + "logs.txt"), true);
            sw.WriteLine(now.ToString("dd-MM-yyyy hh:mm:ss")+ " | " + pesel +" | "+ text);
            sw.Flush();
            sw.Close();


        }
    }
}
