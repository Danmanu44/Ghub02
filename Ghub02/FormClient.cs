using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.OleDb;

namespace Ghub02
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            //LoadData();
            AccessLoadClient();
        }

        DBHandler db = new DBHandler();
        OleDbCommand command;
        OleDbConnection con;
        OleDbDataAdapter accessAdapter;


        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        AutoCompleteStringCollection names = new AutoCompleteStringCollection();
        AutoCompleteStringCollection names2 = new AutoCompleteStringCollection();

      /*  public voiddb.SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=Proj01DB.db;Version=3;New=False;Compress=True;");
        }
        */


        public void AccessLoadClient()
        {


            try
            {


                string CommandText = " SELECT * FROM client ";







                //Display query



                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(CommandText, con);

                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];
                datagrid.DataSource = DT;
                if (DT.Rows.Count > 0)
                {



                    /*  foreach (DataRow dr in DT.Rows)
                      {
                          datagrid2.Rows.Clear();
                          DateTime date;
                          date = DateTime.Parse(dr["DATE_POSTED"].ToString());

                          datagrid2.Rows.Add(dr["ITEM_NAME"].ToString(), dr["WE_BUY"].ToString(), dr["QUANTITY"].ToString(), dr["COST"].ToString(), dr["CATEGORY"].ToString(), dr["DESCRIPTION"].ToString(), dr["WHOLE_SELLER_PRICE"].ToString(), dr["RETAILER_PRICE"].ToString(), dr["ITEM_CODE"].ToString(), date.ToString("dddd dd MMMM yyyy, HH : mm tt"));

                          //datagrid.DataSource = DT;
                      }*/




                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void AccesssearchClient()
        {


            try
            {


                string CommandText = " SELECT * FROM client WHERE  `CLIENT_NAME` LIKE '" + textBoxClients.Text + "%'";







                //Display query



                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(CommandText, con);

                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];
                datagrid.DataSource = DT;
                if (DT.Rows.Count > 0)
                {



                    /*  foreach (DataRow dr in DT.Rows)
                      {
                          datagrid2.Rows.Clear();
                          DateTime date;
                          date = DateTime.Parse(dr["DATE_POSTED"].ToString());

                          datagrid2.Rows.Add(dr["ITEM_NAME"].ToString(), dr["WE_BUY"].ToString(), dr["QUANTITY"].ToString(), dr["COST"].ToString(), dr["CATEGORY"].ToString(), dr["DESCRIPTION"].ToString(), dr["WHOLE_SELLER_PRICE"].ToString(), dr["RETAILER_PRICE"].ToString(), dr["ITEM_CODE"].ToString(), date.ToString("dddd dd MMMM yyyy, HH : mm tt"));

                          //datagrid.DataSource = DT;
                      }*/




                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        
        
        private void LoadData()
        {
         SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from client";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            datagrid.DataSource = DT;
            sql_con.Close();
        }

        public void clearTextbox()
        {


        }
        public void ExecuteQuery(string txtQuery)
        {
         SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {

        }

      
        private void savebtn_Click(object sender, EventArgs e)
        {

            
        }

        private void textBoxClients_TextChange(object sender, EventArgs e)
        {

            string CommandText = " SELECT * FROM items WHERE  `Name` LIKE '" + textBoxClients.Text + "%' OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

            QuerySearch(CommandText, datagrid);
        }
        SQLiteConnection sql = new SQLiteConnection();
        public void SetConnection()
        {

            sql_con = new SQLiteConnection
               (@"Data Source=|DataDirectory|\Proj02DB.db;Version=3;New=False;Compress=True;");

        }
        public void QuerySearch(string query, DataGridView dt)
        {

            try
            {

                // string CommandText = " SELECT * FROM client WHERE  `Name` LIKE '" + textBoxClients.Text + "%' OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

             SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                //CommandText = query;
                DB = new SQLiteDataAdapter(query, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dt.DataSource = DT;
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void addClientbtn_Click(object sender, EventArgs e)
        {
            Client addClient = new Client();
            this.Controls.Add(addClient);
            addClient.BringToFront();
        }

        private void accountbtn_Click(object sender, EventArgs e)
        {
            ClientAccount account = new ClientAccount();
            this.Controls.Add(account);
            account.BringToFront();
        }

    }
}
