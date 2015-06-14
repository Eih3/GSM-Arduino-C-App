using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_MJC
{
    class Configuration
    {
        private static Configuration instance;

        Database sqlite = Database.getInstance();

        public static Configuration getInstance()
        {
            if (instance == null) instance = new Configuration();
            return instance;
        }

        public void configDatabase()
        {
            sqlite.databaseExist();

            sqlite.createDatabase();
            sqlite.connectToDatabase();
            sqlite.createTable(Program.GSM_TABLE, 
                "numero VARCHAR(30), message VARCHAR(100), date VARCHAR(30)");
        }
    }
}
