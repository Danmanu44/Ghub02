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
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Ghub02
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        DBHandler db = new DBHandler();
        SQLiteConnection sql = new SQLiteConnection();
        public void SetConnection()
        {

            sql_con = new SQLiteConnection
               (SetDBPath());
            
        }
        private static string SetDBPath(string id= "Default")
        {

           
            return  ConfigurationManager.ConnectionStrings[id].ConnectionString;
           
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
        private OleDbCommand command;
        AutoCompleteStringCollection names = new AutoCompleteStringCollection();
        AutoCompleteStringCollection names2 = new AutoCompleteStringCollection();
        private string datagridCateg;
        private string datagridItem_code;
        private string datagridDate;
        private string datagridName;
        private string datagridQty;
        private string datagridWhleSalerPrice;
        private string datagridRetailerPrice;
        private int datagridWeBuy;
        private string TextBoxwhleSaler;
        private int datagridId;


        struct Accessor
        {

        }

        private void AddItem(string query)
        {

            Random random = new Random();

            //  int newquantity = int.Parse(pricetbox.Text);
            string dt = theDate.ToString("yyyy-MM-dd H:mm:ss");
            itemCode = random.Next(500000);
            //MessageBox.Show(itemCode.ToString());
            //  string Query = "insert into items(name,price,quantity,Category,date_posted,items_code,Description)values('" + this.nametbox.Text + "','" + this.pricetbox.Text + "','" + this.quantitytbox.Text + "','" + this.comboBoxCateg.Text + "','" + dt + "' ,'" + itemCode + "','" + dscr.Text + "');";


            // string txtSQLQuery = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Category,Item_id,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + dscr.Text + "','" + comboBoxCateg.Text + "' ,'" + itemCode + "','" + dt + "')";
            ExecuteQuery(query);
        }
        private void LoadData()
        {
            sql_con = new SQLiteConnection
                 (@"Data Source=Proj02DB.db;Version=3;New=False;Compress=True;");
          try
          {
              sql_con.Open();
          }
          catch (Exception ec)
          {
              ec.ToString();
          }
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from items";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            if (DT.Rows.Count > 0)
            {
                //MessageBox.Show("Hey We Have Values");
                datagrid.DataSource = DT;
                sql_con.Close();
            }
            else
            {
               // MessageBox.Show("No No Values");

            }
            
        }
        private void FormStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accessDb01DataSet5.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter3.Fill(this.accessDb01DataSet5.items);
            // TODO: This line of code loads data into the 'accessDb01DataSet4.items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter2.Fill(this.accessDb01DataSet4.items);
            // TODO: This line of code loads data into the 'accessDb01DataSet3.items' table. You can move, or remove it, as needed.
            
          try
            {
                //LoadData();
              //  this.itemsTableAdapter1.Fill(this.accessDb01DataSet3.items);
                // TODO: This line of code loads data into the 'accessDb01DataSet.items' table. You can move, or remove it, as needed.
               // this.itemsTableAdapter.Fill(this.accessDb01DataSet.items);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {

        }

        private void addNewbtn_Click_1(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            datagrid.Hide();
            // formInPanel(new AddNew1());

            // addNew.Show();
            this.Controls.Add(addItem);
            addItem.BringToFront();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
           
            UpdateItem update = new UpdateItem();
 
            datagrid.Hide();
            // formInPanel(new AddNew1());

            // addNew.Show();
            this.Controls.Add(update);
            update.BringToFront();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            RemoveItem removeItem = new RemoveItem();
            this.Controls.Add(removeItem);
            removeItem.BringToFront();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBy(this.accessDb01DataSet.items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                datagridCateg = datagrid.SelectedRows[0].Cells[7].Value.ToString();
                // datagridItem_code = datagrid.SelectedRows[0].Cells[9].Value.ToString();
                // datagridDate = datagrid.SelectedRows[0].Cells[10].Value.ToString();
                datagridName = datagrid.SelectedRows[0].Cells[1].Value.ToString();
                datagridQty = datagrid.SelectedRows[0].Cells[3].Value.ToString();
                datagridWhleSalerPrice = datagrid.SelectedRows[0].Cells[5].Value.ToString();
                datagridRetailerPrice = datagrid.SelectedRows[0].Cells[6].Value.ToString();
                datagridWeBuy = Convert.ToInt32(datagrid.SelectedRows[0].Cells[2].Value);
                datagridId = Convert.ToInt32(datagrid.SelectedRows[0].Cells[0].Value);
                labelQuantity.Text = datagridQty;
                labelWprice.Text = datagridWhleSalerPrice;
                labelRprice.Text = datagridRetailerPrice;
                labelName.Text = datagridName;
                setPicture();
            }
            catch (Exception ex)
            {

            }
        }

        public void setPicture()
        {
            string sd;
            string query = "SELECT IMAGE from items where ITEM_NAME = '(" +datagridName + ")'";
            try
            {
                db.setDbConnection(out command, ref query);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                     sd = reader[0].ToString();
                    if (reader[0].ToString() != null)
                    {
                        try
                        {
                            Byte[] data = new Byte[0];
                            data = (Byte[])(reader[0]);
                            MemoryStream ms = new MemoryStream(data);
                           
                            try
                            {
                               
                                itempicture.Image = Image.FromStream(ms);
                                itempicture.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                             catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }


                            MessageBox.Show("hjkl;");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("Image is null");
                    }




                    datagrid.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[03].ToString(), reader[4].ToString(), reader[5].ToString(), (byte[])reader[7], reader[6].ToString(), reader[8].ToString(), reader[9].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
