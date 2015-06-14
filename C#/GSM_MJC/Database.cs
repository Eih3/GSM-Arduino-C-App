using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace GSM_MJC
{
    class Database
    {
        SQLiteConnection DB;

        private static Database instance;

        public static Database getInstance()
        {
            if (instance == null) instance = new Database();
            return instance;
        }

        public void databaseExist()
        {
            if (Function.fileExist(Program.DATABASE_NAME)) Program.DATABASE_EXIST = true;
        }

        public void createDatabase()
        {
            if (!Program.DATABASE_EXIST)
            {
                SQLiteConnection.CreateFile(Program.DATABASE_NAME);
                Program.CONFIG_GSM = true;
            }
            File.SetAttributes(Program.DATABASE_NAME, FileAttributes.Hidden);

            databaseExist();
        }

        public void connectToDatabase()
        {
            try
            {
                DB = new SQLiteConnection("Data Source=" + Program.DATABASE_NAME 
                    + ";Version=3;New=False;Compress=True;");
                DB.Open();
            }
            catch (Exception e) { Function.showMessage(e.ToString()); }
        }

        public void createTable(string table, string column)
        {           
            string sql = "CREATE TABLE IF NOT EXISTS " + table
                + "(" + column + ")";
            SQLiteCommand command = new SQLiteCommand(sql, DB);
            command.ExecuteNonQuery();
        }

        public void insertConfigTable(string numero, string message, string date)
        {
            try
            {
                string sql = "INSERT OR REPLACE INTO " + Program.GSM_TABLE
                    + " (numero, message, date) values ('" + numero + "', '" + message + "', '" + date + "')";
                SQLiteCommand command = new SQLiteCommand(sql, DB);
                command.ExecuteNonQuery();
            }
            catch(Exception e) { Function.showMessage(e.ToString()); }
        }
    }
}
