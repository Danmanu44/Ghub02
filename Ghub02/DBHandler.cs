using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.OleDb;

namespace Ghub02
{
    class DBHandler 
    {


        OleDbCommand command;


        SQLiteConnection sql = new SQLiteConnection();
        public void SetConnection( SQLiteConnection sql_con)
        {

             sql_con = new SQLiteConnection
                (@"Data Source=|DataDirectory|\Proj02DB.db;Version=3;New=False;Compress=True;");

        }
       // Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\HP\Desktop\qwertyui\Visual Studio 2013\Visual Studio 2013\Projects\Ghub02\Ghub02\accessDb01.mdb"

        public string cnnString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\accessDb01.mdb; Persist Security Info = true";
        
        public void setDbConnection(out OleDbCommand command, ref string query)
        {
            command = new OleDbCommand(query);

            command.Connection = new OleDbConnection(cnnString);
            command.Connection.Open();

        }


        public void accessExecuteQuery(string query)
        {


            command = new OleDbCommand(query);
            command.ExecuteReader();
            command.Connection.Close();


        }
       
    }
}
