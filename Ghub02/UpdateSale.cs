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

namespace Ghub02
{
    public partial class UpdateSale : UserControl
    {
        public UpdateSale()
        {
            InitializeComponent();
        }



        DBHandler db = new DBHandler();
        SQLiteConnection sql = new SQLiteConnection();
        public void SetConnection()
        {

            sql_con = new SQLiteConnection
               (@"Data Source=|DataDirectory|\Proj02DB.db;Version=3;New=False;Compress=True;");

        }

        public void clearTextbox()
        {
            nametbox1.Clear();
            nametbox1.Focus();
            pricetbox.Clear();
            quantitytbox1.Clear();
            
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
        
        private string datagrid2Qty;
       
        private string datagrid3ID;
        private string datagridPrice;
        private string datagridName;
        private int datagridProfit;
        private int datagridAmount;


        private void quantitytbox1_TextChange(object sender, EventArgs e)
        {

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
        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            
            string CommandText = " SELECT * FROM items WHERE  `Name` LIKE '" + nametbox1.Text + "%' OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

            QuerySearch(CommandText, datagrid3);
        }
     

        private void UpdateSale_Load(object sender, EventArgs e)
        {

        }

        private void datagrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void getInvoice()
        {
            string query = "select * from invoice where tranx_id = '" + searchtbox.Text + "'";
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
                if (DT.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid \" Invoice ID\"");
                }
                datagrid3.DataSource = DT;
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchtbox.Text != "")
            {
                getInvoice();
            }
            else
            {
                MessageBox.Show("Please enter \" Invoice ID \"");
            }
        }

        private void datagrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {

                datagrid3ID = datagrid3.SelectedRows[0].Cells[0].Value.ToString();
                //datagrid2Item_code = datagrid3.SelectedRows[0].Cells[9].Value.ToString();
               // datagrid2Date = datagrid3.SelectedRows[0].Cells[10].Value.ToString();
                datagridName = datagrid3.SelectedRows[0].Cells[1].Value.ToString();
                datagrid2Qty = datagrid3.SelectedRows[0].Cells[3].Value.ToString();
               datagridProfit =Convert.ToInt32( datagrid3.SelectedRows[0].Cells[8].Value);
                datagridPrice = datagrid3.SelectedRows[0].Cells[2].Value.ToString();
               datagridAmount = Convert.ToInt32(datagrid3.SelectedRows[0].Cells[7].Value);
            
                quantitytbox1.Text = datagrid2Qty;
                
                pricetbox.Text = datagridPrice;
                nametbox1.Text = datagridName;

                
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
        




        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
          int  amount = Convert.ToInt32(pricetbox.Text) * Convert.ToInt32(quantitytbox1.Text);
          int weBuy = (datagridAmount - datagridProfit) / Convert.ToInt32(datagrid2Qty);
          //MessageBox.Show("We buy = "+ weBuy);
          int newprofit = amount - (weBuy * Convert.ToInt32(quantitytbox1.Text));
          //MessageBox.Show("new profit = " + newprofit);

          string query = "update invoice set quantity = '"+quantitytbox1.Text+"', price = '"+pricetbox.Text+"', amount = '"+amount+"', profit = '"+newprofit+"' where id = '"+datagrid3ID+"'";
          if (pricetbox.Text != "" && pricetbox.Text != "")
          {
              try
              {
                  ExecuteQuery(query);
                  MessageBox.Show(datagridName + " Updated succsessfully!");
              }
              catch (Exception ex)
              {

              }

          }
          else
          {
              MessageBox.Show("Select Item from the above table");
          }
        }
    }
}
