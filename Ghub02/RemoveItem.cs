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
    public partial class RemoveItem : UserControl
    {
        public RemoveItem()
        {
            InitializeComponent();
        }

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
        public void clearTextbox()
        {
            nametbox.Clear();
            nametbox.Focus();
            pricetbox.Clear();
            quantitytbox.Clear();
            TextBoxRetailer.Clear();
            TextBoxwhleSaler.Clear();
        }
        public void ExecuteQuery(string txtQuery)
        {
         
    ;
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
        private string datagrid2Categ;
        private string datagrid2Item_code;
        private string datagrid2Name;
        private string datagrid2Date;
        private string datagrid2Qty;
        private string datagrid2WhleSalerPrice;
        private string datagrid2RetailerPrice;
        private int datagridWeBuy;
        private int datagrid2Id;
        public void AccesssearchData()
        {


            try
            {








                //tring Query = "select * from items;";

                //Query = "SELECT * FROM items WHERE CONCAT( `ITEM_NAME`, `CATEGORY`, `QUANTITY`,`DATE_POSTED`) like '%" + valueToSearch + "%' ";
                string CommandText = " SELECT * FROM items WHERE  ITEM_NAME LIKE '" + nametbox.Text + "%'  ";


                //Display query



                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(CommandText, con);

                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];

                if (DT.Rows.Count > 0)
                {

                    datagrid2.DataSource = DT;

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
        
        



        private void nametbox_TextChange(object sender, EventArgs e)
        {
            //string CommandText = " SELECT * FROM items WHERE  `Name` LIKE '" + nametbox.Text + "%' OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

           // QuerySearch(CommandText, datagrid2);
            AccesssearchData();
        }

        private void QuerySearch(string CommandText, DataGridView datagrid)
        {
            try
            {

                // string CommandText = " SELECT * FROM client WHERE  `Name` LIKE '" + textBoxClients.Text + "%' OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

             SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                //CommandText = query;
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                datagrid.DataSource = DT;
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void datagrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                datagrid2Id =Convert.ToInt32(datagrid2.SelectedRows[0].Cells[0].Value);
                datagrid2Categ = datagrid2.SelectedRows[0].Cells[7].Value.ToString();
                datagrid2Item_code = datagrid2.SelectedRows[0].Cells[9].Value.ToString();
                datagrid2Date = datagrid2.SelectedRows[0].Cells[10].Value.ToString();
                datagrid2Name = datagrid2.SelectedRows[0].Cells[1].Value.ToString();
                datagrid2Qty = datagrid2.SelectedRows[0].Cells[3].Value.ToString();
                datagrid2WhleSalerPrice = datagrid2.SelectedRows[0].Cells[5].Value.ToString();
                datagrid2RetailerPrice = datagrid2.SelectedRows[0].Cells[6].Value.ToString();
                datagridWeBuy = Convert.ToInt32(datagrid2.SelectedRows[0].Cells[2].Value);
                TextBoxwhleSaler.Text = datagrid2.SelectedRows[0].Cells[0].Value.ToString();
                quantitytbox.Text = datagrid2Qty;
                pricetbox.Text = datagridWeBuy.ToString();
                TextBoxwhleSaler.Text = datagrid2WhleSalerPrice;
                TextBoxRetailer.Text = datagrid2RetailerPrice;
                nametbox.Text = datagrid2Name;
                comboBoxCateg.Text = datagrid2Categ;



            }
            catch (Exception ex)
            {

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE '" + datagrid2Name + "' ", "YOU ARE NOT ABLE TO GET IT BACK", MessageBoxButtons.YesNo);


                if (dr == DialogResult.Yes)
                {
                    remove_Item();
                }
                else if (dr == DialogResult.No)
                {
                    
                }

               

            }
            catch (Exception ec)
            {

            }
            finally
            {
                clearTextbox();
            }

        }

        private void remove_Item()
        {
            string query = "delete from items where ID = " + datagrid2Id ;
            try
            {
                if (nametbox.Text != "" && pricetbox.Text != "" && TextBoxRetailer.Text != "" && TextBoxwhleSaler.Text != "" && quantitytbox.Text != "")
                {
                    //ExecuteQuery(query);
                    db.setDbConnection(out command, ref query);
                    command.ExecuteReader();
                    command.Connection.Close();
                    MessageBox.Show("ITEM DELETED SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("PLEASE ENTER VALUE IN ALL THE FIELD WITH RED *");
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show("unable to delete item");
                MessageBox.Show(ec.ToString());
            }
            finally
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
