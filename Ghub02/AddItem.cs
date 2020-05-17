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
    public partial class AddItem : UserControl
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            //auto2();
           // Auto();
            accessAutoCompletItems();
            accessAutoCompleteCateg();
            populateDatagrid();
        }
        //instance declaration
        DBHandler db = new DBHandler();
        OleDbCommand command;
        OleDbDataAdapter accessAdapter;
        OleDbConnection con;
        OpenFileDialog ofd = new OpenFileDialog();

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
        private string accesitemcode;
        private int accessCategquantity;
        private Int32 accessCategCost;
        private int Cost;

       

        struct Accessor
        {

        }

        private void AddNewItem(string query)
        {
           
          /*  Random random = new Random();
            
            //  int newquantity = int.Parse(pricetbox.Text);
            string dt = theDate.ToString("yyyy-MM-dd H:mm:ss");
            itemCode = random.Next(500000);
            //MessageBox.Show(itemCode.ToString());
            string Query = "insert into items(name,price,quantity,Category,date_posted,items_code,Description)values('" + this.nametbox.Text + "','" + this.pricetbox.Text + "','" + this.quantitytbox.Text + "','" + this.comboBoxCateg.Text + "','" + dt + "' ,'" + itemCode + "','" + dscr.Text + "');";


            string txtSQLQuery = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Category,Item_id,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + dscr.Text + "','" + comboBoxCateg.Text + "' ,'" + itemCode + "','" + dt + "')";
            ExecuteQuery(query);


            */

            AddAccessdb();


        }

        public void AddAccessdb()
        {

            Random random = new Random();

            //  int newquantity = int.Parse(pricetbox.Text);
            string dt = theDate.ToString();
            itemCode = random.Next(500000);
           // string path = ofd.FileName;
            //byte[] imageData;
            //imageData = System.IO.File.ReadAllBytes(@path);

            try
            {

                MessageBox.Show(dt);
                string query = "insert into  items (ITEM_NAME, WE_BUY, QUANTITY, DESCRIPTION, WHOLE_SELLER_PRICE, RETAILER_PRICE, ITEM_CODE, DATE_POSTED,CATEGORY,COST) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + dscr.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + itemCode + "','" + dt + "','" + categName + "','" + Cost + "')";
                
                /*command.Parameters.AddWithValue("@name", tboxName.Text);
                command.Parameters.AddWithValue("@age", tboxAge.Text);
                command.Parameters.AddWithValue("@level", tboxLevel.Text);
                command.Parameters.AddWithValue("@phone", tboxPhone.Text);*/
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
            //this.cSTableTableAdapter1.Fill(this.studentDataSet1.CSTable);
            
           // this.itemsTableAdapter.Fill(this.accessDb01DataSet1.items);
           // datagrid.DataSource = this.accessDb01DataSet1.items;
            populateDatagrid();
           // datagrid.Update();
            
        }

        public void populateDatagrid()
        {

            string query = "select * from items";
            
            try
            {
                
                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(query, con);



                DS.Reset();

                accessAdapter.Fill(DS);
                this.itemsTableAdapter3.Fill(this.accessDb01DataSet5.items);

               // DT = DS.Tables[0];
                DT = this.accessDb01DataSet5.items;

               // MessageBox.Show(DT.Rows.Count.ToString());

                if (DT.Rows.Count > 0)
                {
                    datagrid.Rows.Clear();
                    DateTime date;
                    foreach (DataRow dr in DT.Rows)
                    {
                       
                        
                        date = DateTime.Parse(dr["DATE_POSTED"].ToString());

                        datagrid.Rows.Add(dr["ITEM_NAME"].ToString(), dr["WE_BUY"].ToString(), dr["QUANTITY"].ToString(), dr["COST"].ToString(), dr["CATEGORY"].ToString(), dr["DESCRIPTION"].ToString(), dr["WHOLE_SELLER_PRICE"].ToString(), dr["RETAILER_PRICE"].ToString(), dr["ITEM_CODE"].ToString(), date.ToString("dddd dd MMMM yyyy, HH : mm "));

                        //datagrid.DataSource = DT;
                    }

                    







                  
                }
           

            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
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
            datagrid.DataSource = DT;
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
                datagrid.DataSource = DT;


                sql_con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AccesssearchData(string valueToSearch)
        {


            try
            {





                string Query;


                //tring Query = "select * from items;";

                Query = "SELECT * FROM items WHERE CONCAT( `ITEM_NAME`, `CATEGORY`, `QUANTITY`,`DATE_POSTED`) like '%" + valueToSearch + "%' ";
                            string CommandText = " SELECT * FROM items WHERE  `ITEM_NAME` LIKE '" + nametbox.Text + "%'  ";


                //Display query



                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(CommandText, con);
               
                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];

                if (DT.Rows.Count > 0)
                {

                    foreach (DataRow dr in DT.Rows)
                    {
                        datagrid.Rows.Clear();
                        DateTime date;
                        date = DateTime.Parse(dr["DATE_POSTED"].ToString());

                        datagrid.Rows.Add(dr["ITEM_NAME"].ToString(), dr["WE_BUY"].ToString(), dr["QUANTITY"].ToString(), dr["COST"].ToString(), dr["CATEGORY"].ToString(), dr["DESCRIPTION"].ToString(), dr["WHOLE_SELLER_PRICE"].ToString(), dr["RETAILER_PRICE"].ToString(), dr["ITEM_CODE"].ToString(), date.ToString("dddd dd MMMM yyyy, HH : mm tt"));

                        //datagrid.DataSource = DT;
                    }




                }
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
            //auto2();
           // Auto();

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


        public void addItem_CategQty(){
             try
            {
                string qupdate = "Select quantity,items_code,Category from items Where name = '" + this.nametbox.Text + "'";

             SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = qupdate;
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                if (DT.Rows.Count > 0)
                {
                    foreach (DataRow dr in DT.Rows)
                    {

                        comboBoxCateg.Items.Add(dr["Category"].ToString());
                        dbquantity1 = Convert.ToInt32(dr["quantity"]);
                        itemcode = Convert.ToInt32(dr["items_code"]);
                        categName = dr["Category"].ToString();

                        qtytbox = Convert.ToInt32(quantitytbox.Text);
                        dbquantity = dbquantity1 + qtytbox;


                    }
                    updateItemQty();
                    getCategQty();
                    updateCategQty();




                }
                else
                {
                    MessageBox.Show("No category found");
                   
                }
                sql_con.Close();
             }catch(Exception ex){
                MessageBox.Show(ex.ToString());
             }

        }

        public void accessAddItem_CategQty()
        {
            try
            {
                string qupdate = "Select QUANTITY,ITEM_CODE,CATEGORY from items Where name = '" + this.nametbox.Text + "'";

                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(qupdate, con);

                
                DS.Reset();
                accessAdapter.Fill(DS);
                accessAdapter.Dispose();
                DT = DS.Tables[0];
                if (DT.Rows.Count > 0)
                {
                    foreach (DataRow dr in DT.Rows)
                    {

                       // comboBoxCateg.Items.Add(dr["CATEG_ID"].ToString());
                        dbquantity1 = Convert.ToInt32(dr["QUANTITY"]);
                        accesitemcode = dr["ITEM_CODE"].ToString();
                        categName = dr["CATEGORY"].ToString();

                        /*adding 
                         * adding the resultant quantity of a current category
                         * */
                        qtytbox = Convert.ToInt32(quantitytbox.Text);
                        dbquantity = dbquantity1 + qtytbox;


                    }
                   
                   // AccessupdateItemQty();
                    AccessgetCategQty();
                    AccessupdateCategQty();




                }
                else
                {
                    MessageBox.Show("No category found");

                }
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void insertNewCategory()
        {
            // inserting  new category with its quantity


            
                try
                {
                    string Query8 = "insert into category(`Category`,`Quantity`,`cost`) values('" + this.comboBoxCateg.Text + "','" + this.quantitytbox.Text + "','" + this.pricetbox.Text + "')";
                    ExecuteQuery(Query8);
                    MessageBox.Show("New category added ");
                    

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

        public void AccessinsertNewCategory()
        {
            // inserting  new category with its quantity



            try
            {
                string Query8 = "insert into category(`CATEGORY`,`QUANTITY`,`COST`) values('" + this.comboBoxCateg.Text + "','" + this.quantitytbox.Text + "','" + accessCategCost + "')";
                
                db.setDbConnection(out command, ref Query8);
                
                command.ExecuteReader();
                
                MessageBox.Show("New category added ");


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
      

        public void updateItemQty(){
            string setqty = "update items set quantity = '" + dbquantity + "' where name ='" + this.nametbox.Text + "'";
            try
            {
                ExecuteQuery(setqty);
                MessageBox.Show("The Quantity  Added Successfull");

            }
            catch (Exception ec)
            {
                MessageBox.Show("unable to set item  quantity ");
            }
            finally
            {
                datagrid.Update();
            }
        }
        public void AccessupdateItemQty()
        {
            string setqty = "update items set quantity = '" + dbquantity + "' where name ='" + this.nametbox.Text + "'";
            try
            {
                db.setDbConnection(out command,ref setqty);
                command.ExecuteReader();
                MessageBox.Show("The Quantity  Added Successfull");

            }
            catch (Exception ec)
            {
                MessageBox.Show("unable to set item  quantity ");
            }
            finally
            {
                datagrid.Update();                                          
            }
        }

        public void getCategQty()
        {
            try
            {
                string setCategQty = "select Quantity, cost from category  where category ='" + categName + "'";
                ExecuteQuery(setCategQty);

             SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                DB = new SQLiteDataAdapter(setCategQty, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];


                if (DT.Rows.Count > 0)
                {
                    qtycateg = Convert.ToInt32(DT.Rows[0]["Quantity"]);
                    costcateg = Convert.ToInt32(DT.Rows[0]["cost"]);
                    qtycateg += qtytbox;
                    costcateg += Convert.ToInt32(pricetbox.Text);
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
                sql_con.Close();
            }

        }

        public void AccessgetCategQty()
        {
            try
            {
                string setCategQty = "select QUANTITY, COST from category  where CATEGORY ='" + categName + "'";
                con = new OleDbConnection(db.cnnString);
                con.Open();
                accessAdapter = new OleDbDataAdapter(setCategQty, con);
                DS.Reset();
                accessAdapter.Fill(DS);
                DT = DS.Tables[0];


                if (DT.Rows.Count > 0)
                {
                    qtycateg = Convert.ToInt32(DT.Rows[0]["QUANTITY"]);
                    costcateg = Convert.ToInt32(DT.Rows[0]["COST"]);
                    qtycateg += qtytbox;
                    costcateg += Convert.ToInt32(pricetbox.Text);
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
                sql_con.Close();
            }

        }


        public void updateCategQty()
        {
            try
            {

                string updateCateg = "update category set `Quantity` = '" + qtycateg + "', cost = '"+costcateg+"' where `category` ='" + categName + "' ";
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

        public void AccessupdateCategQty()
        {
            try
            {

                string updateCateg = "update category set `QUANTITY` = '" + accessCategquantity + "', COST = '" + accessCategCost + "' where `category` ='" + categName + "' ";
                db.setDbConnection(out command, ref updateCateg);
                command.ExecuteReader();
               

                //to remove letter
                
                MessageBox.Show("Categ qty updated successfully");

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

        public void insertNew()
        {
            Random random = new Random();

            //  int newquantity = int.Parse(pricetbox.Text);
            string dt = theDate.ToString("yyyy-MM-dd H:mm:ss");
            itemCode = random.Next(500000);
            //MessageBox.Show(itemCode.ToString());
            //string Query = "insert into items(name,price,quantity,Category,date_posted,items_code,Description)values('" + this.nametbox.Text + "','" + this.pricetbox.Text + "','" + this.quantitytbox.Text + "','" + this.comboBoxCateg.Text + "','" + dt + "' ,'" + itemCode + "','" + dscr.Text + "');";
            string txtQueryCateg = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Category,Items_code,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + dscr.Text + "','" + comboBoxCateg.Text + "' ,'" + itemCode + "','" + dt + "')";
            string txtQueryNoCateg = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Items_code,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + dscr.Text + "' ,'" + itemCode + "','" + dt + "')";

         SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select  `Category` from items where `Category`  ='" + comboBoxCateg.Text + "'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            MessageBox.Show(DT.Rows.Count.ToString());

            if (DT.Rows.Count > 0)
            {
                AddNewItem(txtQueryCateg);
                addItem_CategQty();



                MessageBox.Show("New item has been added  successfully and no category added ");




                // MessageBox.S how(dbquantity);  m  
            }
            else
            {

                try
                {

                   
                    AddNewItem(txtQueryCateg);
                    insertNewCategory();
                    MessageBox.Show("New item has been added wih new category successfully");




                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                sql_con.Close();



                clearTextbox();


            }

        }

        public void AccessinsertNew()
        {
            Random random = new Random();

            //  int newquantity = int.Parse(pricetbox.Text);
            string dt = theDate.ToString("yyyy-MM-dd H:mm:ss");
            itemCode = random.Next(500000);
            //MessageBox.Show(itemCode.ToString());
            //string Query = "insert into items(name,price,quantity,Category,date_posted,items_code,Description)values('" + this.nametbox.Text + "','" + this.pricetbox.Text + "','" + this.quantitytbox.Text + "','" + this.comboBoxCateg.Text + "','" + dt + "' ,'" + itemCode + "','" + dscr.Text + "');";
            string txtQueryCateg = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Category,Items_code,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + dscr.Text + "','" + comboBoxCateg.Text + "' ,'" + itemCode + "','" + dt + "')";
            string txtQueryNoCateg = "insert into  items (Name,We_buy,Quantity,Whole_saler_price,Retailer_price,Description,Items_code,Date_Posted) values ('" + nametbox.Text + "','" + pricetbox.Text + "','" + quantitytbox.Text + "','" + TextBoxwhleSaler.Text + "','" + TextBoxRetailer.Text + "','" + dscr.Text + "' ,'" + itemCode + "','" + dt + "')";
            string CommandText = "select  * from category where `CATEGORY`  ='" + comboBoxCateg.Text + "'";
            con = new OleDbConnection(db.cnnString);
            con.Open();
            accessAdapter = new OleDbDataAdapter(CommandText, con);
            

            
            DS.Reset();

            accessAdapter.Fill(DS);

            DT = DS.Tables[0];

            MessageBox.Show(DT.Rows.Count.ToString());

            if (DT.Rows.Count > 0)
            {
                
                foreach (DataRow dr in DT.Rows)
                {

                   // comboBoxCateg.Items.Add(dr["CATEG_ID"].ToString());
                    accessCategquantity = Convert.ToInt32(dr["QUANTITY"]);
                    accessCategCost = Convert.ToInt32(dr["COST"]);
                    categName = comboBoxCateg.Text;

                    /*adding 
                     * adding the resultant quantity of a current category
                     * */
                    qtytbox = Convert.ToInt32(quantitytbox.Text);
                    accessCategquantity = accessCategquantity + qtytbox;
                    accessCategCost = accessCategCost + (qtytbox * Convert.ToInt32(pricetbox.Text));

                    Cost = (qtytbox * Convert.ToInt32(pricetbox.Text));


                }

                // AccessupdateItemQty();
                AccessupdateCategQty();
                AddNewItem(txtQueryCateg);
                //AccessgetCategQty();
               


                 



                MessageBox.Show("New item has been added  successfully and no category added ");




                // MessageBox.S how(dbquantity);  m  
            }
            else
            {

                try
                {
                    accessCategCost = (Convert.ToInt32(quantitytbox.Text) * Convert.ToInt32(pricetbox.Text));
                    Cost = accessCategCost;
                    categName = comboBoxCateg.Text;
                    AddNewItem(txtQueryCateg);
                    AccessinsertNewCategory();
                    MessageBox.Show("New item has been added wih new category successfully");




                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                command.Connection.Close();



                clearTextbox();


            }

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

            AccesssearchData(ValueToSearch);
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {

            try
            {

                AccessinsertNew();
               // AddAccessdb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            clearTextbox();



        }

        public void convertImage()
        {
            string path = ofd.FileName;
            byte[] imageData;
            imageData = System.IO.File.ReadAllBytes(@path);
        }
        private void btnbrowse_Click_1(object sender, EventArgs e)
        {
            getImage();
        }

        public void getImage()
        {
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "jpg";
            ofd.DereferenceLinks = true;

            ofd.FileName = ".jpg";

            ofd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*";
            ofd.Multiselect = false;

            ofd.RestoreDirectory = true;
            ofd.Title = "Select the file to open";
            ofd.ValidateNames = true;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
               // itemImage.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBy(this.accessDb01DataSet1.items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
