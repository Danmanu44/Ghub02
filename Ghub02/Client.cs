using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.OleDb;

namespace Ghub02
{
    public partial class Client : UserControl
    {



        DBHandler db = new DBHandler();
        OleDbCommand command;
        OleDbConnection con;
        OleDbDataAdapter accessAdapter;
        
        SQLiteConnection sql = new SQLiteConnection();
        public void SetConnection()
        {

            sql_con = new SQLiteConnection
               (@"Data Source=|DataDirectory|\Proj02DB.db;Version=3;New=False;Compress=True;");

        }
        public Client()
        {
            InitializeComponent();
        }   

        private void Client_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        

        private void LoadData()
        {
            string CommandText = "select * from client";
            con = new OleDbConnection(db.cnnString);
            con.Open();
            accessAdapter = new OleDbDataAdapter(CommandText, con);
           
           
           
           
            DS.Reset();
            accessAdapter.Fill(DS);
            DT = DS.Tables[0];
            datagrid.DataSource = DT;
            con.Close();
        }

        public void clearTextbox()
        {
            nametbox.Clear();
            nametbox.Focus();
            phonetbox.Clear();
            addresstbox.Clear();

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


        DateTime theDate = DateTime.Now;
        int dbquantity1;
        int dbquantity, qtytbox, qtycateg;
        string dbquantity2, categName, ccateg;
        int itemCode, itemcode;


        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        AutoCompleteStringCollection names = new AutoCompleteStringCollection();
        AutoCompleteStringCollection names2 = new AutoCompleteStringCollection();
        private int costcateg;




        private void AddItem(string query)
        {

            Random random = new Random();

            //  int newquantity = int.Parse(pricetbox.Text);
            string dt = theDate.ToString("yyyy-MM-dd H:mm:ss");
            itemCode = random.Next(500000);
            //MessageBox.Show(itemCode.ToString());
            //  string Query = "insert into client(name,price,quantity,Category,date_posted,items_code,Description)values('" + this.nametbox.Text + "','" + this.pricetbox.Text + "','" + this.quantitytbox.Text + "','" + this.comboBoxCateg.Text + "','" + dt + "' ,'" + itemCode + "','" + addresstbox.Text + "');";


            // string txtSQLQuery = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Category,Item_id,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + addresstbox.Text + "','" + comboBoxCateg.Text + "' ,'" + itemCode + "','" + dt + "')";
            ExecuteQuery(query);
        }



        public void Auto()
        {

            try
            {
                string CommandText = "select ITEM_NAME from items where ITEM_NAME LIKE '"+nametbox.Text+"%' ";

                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(CommandText, con);
             
               
                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];




                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        names.Add(DT.Rows[i]["name"].ToString());

                    }


                }
                else
                {
                    MessageBox.Show("NO RECORD FOUND");
                }


                // int quantity =Convert.ToString(QReader[0]);                  }


                nametbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                nametbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                nametbox.AutoCompleteCustomSource = names;


                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }


        }



        private void pricetbox_TextChange(object sender, EventArgs e)
        {

        }

        private void labelP_Click(object sender, EventArgs e)
        {

        }

        public Boolean checkClient()
        {
            try
            {
             SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from client where CLIENT_NAME = '" + nametbox.Text + "'";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                datagrid.DataSource = DT;
                sql_con.Close();
            }
            catch (Exception ex)
            {

            }
            if (DT.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public bool AccesscheckClient()
        {
            try
            {
                con = new OleDbConnection(db.cnnString);
                con.Open();
                
                //sql_cmd = sql_con.CreateCommand();
                MessageBox.Show(nametbox.Text);
                string CommandText = "select * from client WHERE CLIENT_NAME = '" + nametbox.Text + "'";
                accessAdapter = new OleDbDataAdapter(CommandText, con);
               
                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];
                datagrid.DataSource = DT;
                
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (DT.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }


        private void dscr_TextChange(object sender, EventArgs e)
        {

        }

      

       

       

        private void nametbox_TextChange(object sender, EventArgs e)
        {
            //Auto();
        }

        private void savebtn_Click_2(object sender, EventArgs e)
        {

           
            
            string Query = "insert into client(CLIENT_NAME,PHONE,ADDRESS)values('" + this.nametbox.Text + "','" + this.phonetbox.Text + "','" + this.addresstbox.Text + "');";
            if (nametbox.Text == "" || phonetbox.Text == "")
            {
                MessageBox.Show("INVALID NAME OR PHONE NUMBER");
            }
            else
            {


                if (AccesscheckClient())
                {
                    MessageBox.Show("PLEASE MAKE SOME CHANGES IF ITS A NEW NAME", "THE NAME ALREADY EXIST  ");

                }
                else
                {
                    try
                    {
                        db.setDbConnection(out command, ref Query);
                        //command.Connection.Open();
                        command.ExecuteReader();
                        command.Connection.Close();
                        MessageBox.Show("NEW CLIENT ADDED SUCCESSFULLY");

                        LoadData();

                        clearTextbox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
            }
           


        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
