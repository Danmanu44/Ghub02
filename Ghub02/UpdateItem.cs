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
    public partial class UpdateItem : UserControl
    {
        public UpdateItem()
        {
            InitializeComponent();
        }
        DBHandler db = new DBHandler();
        OleDbConnection con;
        OleDbCommand command;
        OleDbDataAdapter accessAdapter;
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


        private void nametbox_TextChange(object sender, EventArgs e)
        {
            //string CommandText = " SELECT * FROM items WHERE  `Name` LIKE '" + nametbox.Text + "%' OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

            //QuerySearch(CommandText, datagrid2);

            AccesssearchData();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            auto2();
            Auto();
        }
        //instance declaration
       


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
        string categName;
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
        private string datagrid2Id;



        struct Accessor
        {

        }

        private void AddNewItem(string query)
        {

            Random random = new Random();

            //  int newquantity = int.Parse(pricetbox.Text);
            string dt = theDate.ToString("yyyy-MM-dd H:mm:ss");
            itemCode = random.Next(500000);
            //MessageBox.Show(itemCode.ToString());
            string Query = "insert into items(name,price,quantity,Category,date_posted,items_code,Description)values('" + this.nametbox.Text + "','" + this.pricetbox.Text + "','" + this.quantitytbox.Text + "','" + this.comboBoxCateg.Text + "','" + dt + "' ,'" + itemCode + "','" + dscr.Text + "');";


            string txtSQLQuery = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Category,Item_id,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + dscr.Text + "','" + comboBoxCateg.Text + "' ,'" + itemCode + "','" + dt + "')";
            ExecuteQuery(query);
        }

        private void LoadData()
        {
        SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from items";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            
            sql_con.Close();
        }


        public void Auto()
        {

            try
            {

                string qupdate = "Select name from items";
            SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select Name from items";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
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
                    MessageBox.Show("No record found");
                }


                // int quantity =Convert.ToString(QReader[0]);                  }


                nametbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                nametbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                nametbox.AutoCompleteCustomSource = names;
                sql_con.Close(); ;



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }


        }

        public void auto2()
        {

            try
            {

                string qupdate = "select category from category";

            SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = qupdate;
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];

                // MySqlDataReader QReader;

                //QReader = Qcommand.ExecuteReader();


                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        comboBoxCateg.Items.Add(DT.Rows[i]["Category"].ToString());


                    }


                }
                else
                {
                    MessageBox.Show("No record found");
                }


                // int quantity =Convert.ToString(QReader[0]);                



                comboBoxCateg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //category.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //category.AutoCompleteCustomSource = names2;

                sql_con.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }


        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {

        }

        public void searchData(string valueToSearch)
        {


            try
            {





                string Query;


                //tring Query = "select * from items;";

                Query = "SELECT Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Category,Item_id,Date_Posted FROM items WHERE CONCAT( `Name`, `Category`, `Quantity`,`Date_Posted`) like '%" + valueToSearch + "%' ";


                //Display query



                string qupdate = "Select name from items";
            SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from items";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
               


                sql_con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }










        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //    if (datagrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //    {
            //        nametbox.Text = datagrid1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            //        pricetbox.Text = datagrid1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            //        quantitytbox.Text = datagrid1.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString();
            //    }
            //    datagrid1.Update();
        }
        public void dropDown()
        {

            auto2();

        }

        private void Addnew_Load(object sender, EventArgs e)
        {
            auto2();
            Auto();

        }







        public string QueryResult(string query)
        {
            string result = "";
            SQLiteConnection sqlite = new SQLiteConnection("Data Source=/path/to/file.db");
            try
            {
                sqlite.Open();  //Initiate connection to the db
                SQLiteCommand cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                result = cmd.ExecuteScalar().ToString();
            }
            finally
            {
                sqlite.Close();
            }
            return result;
        }


      
        public void update_Item()
        {
            string txtQueryCateg = "update  items SET ITEM_NAME ='" + this.nametbox.Text + "',WE_BUY ='" + pricetbox.Text + "',QUANTITY = '" + quantitytbox.Text + "',WHOLE_SELLER_PRICE = '" + TextBoxwhleSaler.Text + "',RETAILER_PRICE = '" + TextBoxRetailer.Text + "',DESCRIPTION= '" + dscr.Text + "',CATEGORY = '" + comboBoxCateg.Text + "' where ID = "+Convert.ToInt32(datagrid2Id);
             
            try
            {
                if (nametbox.Text != "" && pricetbox.Text != "" && TextBoxRetailer.Text != "" && TextBoxwhleSaler.Text != "" && quantitytbox.Text != "")
                {
                    db.setDbConnection(out command, ref txtQueryCateg);
                    command.ExecuteReader();
                    command.Connection.Close();
                    //ExecuteQuery(txtQueryCateg);
                    MessageBox.Show("Item   updated successfull");
                }
                else
                {
                    MessageBox.Show("Please enter value in all the fields with red *");
                }

                

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString()+"unable to update item");
            }
            finally
            {
                
            }
        }

      
        public void updateCateg()
        {

            categName = comboBoxCateg.Text;
            try
            {
                string setCategQty = "select QUANTITY, COST from category  where CATEGORY ='" + categName + "'";
                //ExecuteQuery(setCategQty);

           /* SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                DB = new SQLiteDataAdapter(setCategQty, sql_con);*/

                // iam to change this query to oledbquery '"""""
                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(setCategQty, con);
                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];

                qtytbox = Convert.ToInt32(quantitytbox.Text);
                if (DT.Rows.Count > 0)
                {
                    qtycateg = Convert.ToInt32(DT.Rows[0]["QUANTITY"]);
                    costcateg = Convert.ToInt32(DT.Rows[0]["COST"]);
                    qtycateg += qtytbox;
                    costcateg += Convert.ToInt32(pricetbox.Text)*qtytbox;
                    con.Close();
                    string query = "UPDATE category SET QUANTITY = '" + qtycateg.ToString() + "' and COST = '" + costcateg.ToString() + "'";
                    try
                    {
                        db.setDbConnection(out command, ref query);
                        command.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        command.Connection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("No item found");
                }



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            finally
            {
                //sql_con.Close();
                con.Close();
            }

        }



        public void updateCategQty()
        {
            try
            {

                string updateCateg = "update category set `Quantity` = '" + qtycateg + "', cost = '" + costcateg + "' where `category` ='" + categName + "' ";
                ExecuteQuery(updateCateg);

                //to remove letter
                MessageBox.Show("Categ qty updated successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                sql_con.Close();
            }


        }
        public void twoQueries()
        {






            /* while (QReader.Read())
             {
                 // int quantity =Convert.ToString(QReader[0]);                  }
                 dbquantity1 = (int)QReader[0];
                 itemcode = (int)QReader["items_code"];
               categName = (string)QReader["Category"];

               //int oldqty = int.Parse(dbquantity);
                 qtytbox = Convert.ToInt32(quantitytbox.Text);
                 dbquantity =dbquantity1 + qtytbox;
                 //dbquantity1 += oldqty;
               //  MessageBox.Show(dbquantity.ToString());
                // MessageBox.Show(itemcode.ToString());
                    
             }
             */







            //updating categ quantity




        }

      

        private void category_TextChange(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //   // OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //    openFileDialog1.Filter = "Image files | *.jpg";
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        txtImage.Text = openFileDialog1.FileName;
            //        pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //this.txtImage.Click += new System.EventHandler(this.pictureBox3_Click);
            //this.txtImage.Enter += new System.EventHandler(this.pictureBox3_Click); 

        }

        private void addOder_Click(object sender, EventArgs e)
        {
            // datagrid2.Rows[0].Cells[0].Value = "hafiz";
        }

        private void labelQty_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nametbox_TextChange_1(object sender, EventArgs e)
        {
            string ValueToSearch = nametbox.Text.ToString();

            searchData(ValueToSearch);
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void accessAutoCompletItems()
        {
            try
            {




                string qupdate = "Select ITEM_NAME from items";

                db.setDbConnection(out command, ref qupdate);
                OleDbDataReader reader = command.ExecuteReader();
                con = new OleDbConnection(db.cnnString);

                con.Open();
                accessAdapter = new OleDbDataAdapter(qupdate, con);
                DS.Reset();
                accessAdapter.Fill(DS);
                accessAdapter.Dispose();
                con.Close();
                DT = DS.Tables[0];
                // MySqlDataReader QReader;

                //QReader = Qcommand.ExecuteReader();


                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        names.Add(DT.Rows[i]["ITEM_NAME"].ToString());


                    }

                    nametbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    nametbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    nametbox.AutoCompleteCustomSource = names;


                }
                else
                {
                    MessageBox.Show("No record found");
                }


                // int quantity =Convert.ToString(QReader[0]);                



                comboBoxCateg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //category.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //category.AutoCompleteCustomSource = names2;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
        public void accessAutoCompleteCateg()
        {
            try
            {




                string qupdate = "select CATEGORY from category";

                db.setDbConnection(out command, ref qupdate);
                OleDbDataReader reader = command.ExecuteReader();
                con = new OleDbConnection(db.cnnString);

                con.Open();
                accessAdapter = new OleDbDataAdapter(qupdate, con);
                DS.Reset();
                accessAdapter.Fill(DS);
                accessAdapter.Dispose();
                con.Close();
                DT = DS.Tables[0];
                // MySqlDataReader QReader;

                //QReader = Qcommand.ExecuteReader();


                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        comboBoxCateg.Items.Add(DT.Rows[i]["Category"].ToString());


                    }


                }
                else
                {
                    MessageBox.Show("No record found");
                }


                // int quantity =Convert.ToString(QReader[0]);                



                comboBoxCateg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //category.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //category.AutoCompleteCustomSource = names2;













            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }


        }


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
        
        

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            accessAutoCompleteCateg();
            accessAutoCompletItems();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                update_Item();
                updateCateg();

            }
            catch (Exception ec)
            {

            }
            finally
            {
                clearTextbox();
            }


        }

        private void datagrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                datagrid2Id = datagrid2.SelectedRows[0].Cells[0].Value.ToString();
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
                dscr.Text = datagrid2.SelectedRows[0].Cells[4].Value.ToString(); ;
                comboBoxCateg.Text = datagrid2Categ;
                


            }
            catch (Exception ex)
            {

            }
        }

        private void labelRetailer_Click(object sender, EventArgs e)
        {

        }

        private void labelWhleSale_Click(object sender, EventArgs e)
        {

        }

        private void labelQty_Click_1(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxCateg_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void datagrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dscr_TextChange(object sender, EventArgs e)
        {

        }

        private void TextBoxRetailer_TextChange(object sender, EventArgs e)
        {

        }

        private void TextBoxwhleSaler_TextChange(object sender, EventArgs e)
        {

        }

        private void quantitytbox_TextChange(object sender, EventArgs e)
        {

        }

        private void pricetbox_TextChange(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
