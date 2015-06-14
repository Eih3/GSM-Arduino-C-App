using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;


namespace GSM_MJC
{
    class Function
    {
        private static Function instance;

        public static Function getInstance()
        {
            if (instance == null) instance = new Function();
            return instance;
        }

        public static String getProjectPath()
        {
            return Regex.Replace(Path.GetDirectoryName(Assembly.GetAssembly(typeof(Function)).CodeBase) + "\\", "file:\\\\", "");
        }

        public static String getExecutablePath()
        {
            return Regex.Replace(Regex.Replace(Assembly.GetExecutingAssembly().GetName().CodeBase, "file:///", ""), "/", "\\");
        }

        public static Boolean fileExist(string file)
        {
            if (File.Exists(file)) return true;
            else return false;
        }

        public static void showMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
