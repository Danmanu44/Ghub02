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
    public partial class FormSale : Form
    {
        public FormSale()
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
               (@"Data Source=C:\app\Sys32\data\Intel\empt\Intel\empt\Proj01DB.db;Version=3;New=False;Compress=True;");

        }
        private void LoadData()
        {
            string CommandText = "select * from sell";
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





        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accessDb01DataSet6.sell' table. You can move, or remove it, as needed.
            this.sellTableAdapter.Fill(this.accessDb01DataSet6.sell);
            LoadData();
            //org
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void salebtn_Click_1(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            this.Controls.Add(sell);
            sell.BringToFront();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            UpdateSale updateSale = new UpdateSale();
            this.Controls.Add(updateSale);
            updateSale.BringToFront();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            RemoveInvoice removeInvoice = new RemoveInvoice();
            this.Controls.Add(removeInvoice);
            removeInvoice.BringToFront();
        }
    }
}
