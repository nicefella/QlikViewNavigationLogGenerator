using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Globalization;
using System.Security.Cryptography;
using System.Configuration;

namespace AuditLog
{

    class Do
    {

        public static void WriteLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                string logfilelocation = ConfigurationManager.AppSettings["logfilelocation"]; // AppDomain.CurrentDomain.BaseDirectory 
                sw = new StreamWriter(logfilelocation + "\\AuditNavigationLog_" + DateTime.Today.ToString("yyyyMMdd") + ".txt", true);
                sw.WriteLine(Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }


    }
}
