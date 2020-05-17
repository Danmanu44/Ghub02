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
    public partial class RemoveInvoice : UserControl
    {
        public RemoveInvoice()
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

        public void getInvoice(){
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
                MessageBox.Show("Allargies");
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
                datagridProfit = Convert.ToInt32(datagrid3.SelectedRows[0].Cells[8].Value);
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
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (pricetbox.Text != "" && pricetbox.Text != "")
            {
                try
                {
                    string query = "delete from invoice where id= '" + datagrid3ID + "'";
                    ExecuteQuery(query);
                    MessageBox.Show(datagridName + " Deleted succsessfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Select Item from the above table");
            }
           
        }

        private void deleteAllbtn_Click(object sender, EventArgs e)
        {
            if (searchtbox.Text !="")
            {
                try
                {
                    string query = "delete from invoice where tranx_id= '" + searchtbox.Text + "'";
                    ExecuteQuery(query);
                    MessageBox.Show(datagridName + "All Transaction with ID " + searchtbox.Text + " Deleted succsessfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Please enter the \" Tranxaction ID \" ");
            }
        }
    }
}
