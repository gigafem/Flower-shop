using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.AboutUs;

namespace WpfApp1.Core
{
    public static class Logger
    {
        private static readonly string LogFilePath = "logs/user_actions.log";

        public static void Log(string message)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(LogFilePath)!);

                string logEntry = $"{DateTime.Now:G} | {SessionManager.CurrentUsername ?? "Guest"} | {message}";
                File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while trying to log: " + ex.Message);
            }
        }
    }
}
