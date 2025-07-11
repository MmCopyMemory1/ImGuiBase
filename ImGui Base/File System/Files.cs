using SharpGen.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImGuiFiles
{
    public class Files
    {
        public static void WriteLog(string Message, string LogName)
        {
            StreamWriter writer = new StreamWriter(LogName);
            {
                if(string.IsNullOrEmpty(Message) || string.IsNullOrEmpty(LogName))
                {
                    throw new InvalidOperationException("Error");
                }
                else
                {
                    writer.WriteLine(Message + "\n");
                }
            }
        }

        public static void DeleteBaseLog(string LogName)
        {
            if (File.Exists(LogName))
            {
                File.Delete(LogName);
            }
        }

        public static void CleanUp()
        {
            //todo
        }
    }
}
