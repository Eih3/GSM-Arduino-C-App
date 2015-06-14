using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSM_MJC
{
    static class Program
    {
        public static bool DATABASE_EXIST;
        public static bool CONFIG_GSM;

        public static string DATABASE_NAME = "GSM.sqlite";
        public static string GSM_TABLE = "Messages";

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GSM());
        }
    }
}
