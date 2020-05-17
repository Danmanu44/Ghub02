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
    public partial class Sell : UserControl
    {
        public Sell()
        {
            InitializeComponent();
        }
          DataTable dTable = new DataTable();
        AutoCompleteStringCollection names = new AutoCompleteStringCollection();
        AutoCompleteStringCollection clients = new AutoCompleteStringCollection();

        int order = 1;
        int total;

        DBHandler db = new DBHandler();
        OleDbCommand command;
        OleDbConnection con;
        OleDbDataAdapter accessAdapter;

        

        public void clearTextbox()
        {
            nametbox1.Clear();
            nametbox1.Focus();
            TextBoxwhleSaler.Clear();
            quantitytbox1.Clear();
            TextBoxwhleSaler.Clear();
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
        
        


        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private string datagrid2Categ;
        private string datagrid2Item_code;
        private string datagrid2Date;
        private string datagrid2Name;
        private string datagrid2Qty;
        private string datagrid2WhleSalerPrice;
        private string datagrid2RetailerPrice;
        private string datagridWe_buy;
        private int cost;
        private string datagrid3Name;
        private int datagrid3Qty;
        private int datagrid3Price;
        private int datagrid3Amount;
        private int tranxid;
        private string datagrid2clientId;
        private int dbqty;
        private int dbId;
        private string categName;
        private int dbItemqty;
        private int qtycateg;
        private int costcateg;
        private int profit;
        private int debt;
        private int cashPayed;
        private string clientName;
        private string clientPhone;
        private string clientAddress;
        private int weBuy;
        private int datagridWeBuy;
        private int dbDebt;
        private int Debt;
        private string paymentType;
        



        public void QuerySearch(string query,DataGridView dt){
            
            try{

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
            }catch(Exception ex){
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
            datagrid2.DataSource = DT;
            sql_con.Close();
        }


        public void AutoComp()
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

                
                nametbox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                nametbox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                nametbox1.AutoCompleteCustomSource = names;
                sql_con.Close(); ;



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }


        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
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
                textBoxClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxClients.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxClients.AutoCompleteCustomSource = clients;

                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        names.Add(DT.Rows[i]["ITEM_NAME"].ToString());


                    }

                    nametbox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    nametbox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    nametbox1.AutoCompleteCustomSource = names;


                }
                else
                {
                    MessageBox.Show("No record found");
                }


                // int quantity =Convert.ToString(QReader[0]);                



                //comboBoxCateg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //category.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //category.AutoCompleteCustomSource = names2;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public void accessAutoCompletClient()
        {
            try
            {




                string qupdate = "Select CLIENT_NAME from client";

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
                        clients.Add(DT.Rows[i]["CLIENT_NAME"].ToString());


                    }

                   
                    textBoxClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    textBoxClients.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    textBoxClients.AutoCompleteCustomSource = clients;


                }
                else
                {
                    MessageBox.Show("No record found");
                }


                // int quantity =Convert.ToString(QReader[0]);                



                //comboBoxCateg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //category.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //category.AutoCompleteCustomSource = names2;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

       public void  accessLoadData()
       {
            string query = "select * from items";
            con = new OleDbConnection(db.cnnString);
            con.Open();
            accessAdapter = new OleDbDataAdapter(query,con);
            accessAdapter.Fill(DS);
            DT = DS.Tables[0];
            if (DT.Rows.Count > 0)
            {
                datagrid2.DataSource = DT;
            }
        }
        private void Sell_Load(object sender, EventArgs e)
        {
             //panel2.Hide();0riginal
           //AutoComp();
           accessLoadData();

           accessAutoCompletItems();
           accessAutoCompletClient();
           savebtn.Visible = true;
           printbtn.Visible = true;



        }

      


        void getCategQty()
        {

            // getting Quantity from Category table


        }

        
           
        

        private void savebtn1_Click(object sender, EventArgs e)
        {
         
        }


        public void searchData(string valueToSearch)
        {

        }



        public void labelNotSave()
        {
            labelStatus.Text = "Invoice not save";
            labelStatus.ForeColor = Color.FromArgb(20,60,0,0);
        }
        

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void orderTable(int price)
        {
            total += cost;
           
            datagrid3.Rows.Add(datagrid2Name, quantitytbox1.Text, price, cost,profit);
            label3.Text = string.Format("{0}N", total);
            clearTextbox();
        }
        void resetTboxes()
        {
            nametbox1.Text = string.Empty;
            TextBoxwhleSaler.Text = string.Empty;
            quantitytbox1.Text = string.Empty;
        }
      
        private void datagrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removedtbtn_Click(object sender, EventArgs e)
        {/*
            try
            {
                //int selectedRowCount = datagrid3.Rows.GetRowCount(DataGridViewElementStates.Selected);
                //    int selectedRowCount = datagrid3.CurrentCell.RowIndex;

                //if (selectedRowCount > -1)
                //{

                //        //datagrid3.Rows.RemoveAt(datagrid3.SelectedRows[0].Index);
                //         datagrid3.Rows.RemoveAt(selectedRowCount);
                //        datagrid3.Refresh();

                //}

                Resipt obj = resiptBindingSource.Current as Resipt;
                if (obj != null)
                {
                    total -= obj.price * obj.Quantity;
                    label3.Text = string.Format("{0}$", total);
                }
                resiptBindingSource.RemoveCurrent();

            }
            catch (Exception ec)
            {
                MessageBox.Show("errorrrs");
            }
          * */
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RichTextBox richtbox = new RichTextBox();
            // Panel panel = new Panel();
            // panel.Height = 40;
            // panel.Width = 50;
            ////panel.BackColor = ;
            //// panel.Container.Add( richtbox);
            // this.Controls.Add(panel);
            // panel.BringToFront();
            // panel.Show();

        }
        /*"id"	INTEGER,
	"name"	TEXT UNIQUE,
	"price"	REAL,
	"quantity"	INTEGER,
	"tranx_date"	INTEGER,
	"tranx_id"	INTEGER,
	"client_id"	INTEGER,
	"amount"
          
         */
        private void getClientDebt(ref int dbDebt)
        {
         SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from client where name ='"+clientName+"'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            if (DT.Rows.Count > 0)
            {
                string dbDbt = DT.Rows[0]["debt"].ToString();
                if (dbDbt == null)
                {
                    dbDebt = 0;
                    MessageBox.Show("Hey Iam null");
                }
                else
                {
                    MessageBox.Show("Hey Iam not null");
                    dbDebt = Convert.ToInt32(dbDbt);
                }

            }
            sql_con.Close();
        }
        public void updateDebt(int dbDebt, int Debt)
        {
            
            int cumlativeDebt = dbDebt + Debt;
            string update = "update client set debt = '" + cumlativeDebt + "' where name = '" + clientName + "'";
            try 
            {
                ExecuteQuery(update);
                MessageBox.Show("debt updated successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void insertInvoice(int tranxId)
        {


            int dbDebt = 0, Debt;
            string tranx_date = theDate.ToString("yyyy-MM-dd H:mm:ss");
           
             int dbId = 0, dbItemqty=0,weBuy = 0, qtycateg = 0;
            
            
            for (int i = 0; i < datagrid3.Rows.Count-1 ; i++)
            {
                try
                {

                    datagrid3Name = datagrid3.Rows[i].Cells[0].Value.ToString();
                    datagrid3Qty =  Convert.ToInt32(datagrid3.Rows[i].Cells[1].Value);
                    datagrid3Price = Convert.ToInt32(datagrid3.Rows[i].Cells[2].Value);
                    datagrid3Amount = Convert.ToInt32(datagrid3.Rows[i].Cells[3].Value);
                    

                    MessageBox.Show(datagrid3Qty.ToString());

                    LoadValues( ref dbId,ref dbItemqty,ref weBuy);// setting database id,database qty,category name
                    dbItemqty -= datagrid3Qty;
                   
                    updateItemQty(dbId,dbItemqty);
                    getCategQty1(ref qtycateg);
                    MessageBox.Show("after getting categIfo " + qtycateg);
                    
                    qtycateg -=  datagrid3Qty;
                  
                    // costcateg -= datagrid3Amount;

                    updateCategQty(qtycateg);
                   
                    profit = cost - datagridWeBuy * datagrid3Qty;
                   
                    MessageBox.Show(datagridWeBuy.ToString() + " " + datagrid3Qty.ToString());
                    
                    if (tboxDiscount.Text == "")
                        tboxDiscount.Text = "Null";

                     Debt = total-Convert.ToInt32(cashtbox1.Text);

                     string query = "insert into sell (TRANX_DATE, TRANX_ID, CLIENT_ID, ITEM_NAME, QUANTITY, PRICE, AMOUNT, STAFF_ID, PAY_TYPE, PROFIT,DISCOUNT ) values('" + tranx_date + "','"+ tranxId + "','" + datagrid2clientId + "','" + datagrid3Name + "','" + datagrid3Qty + "','" + datagrid3Price + "','" + datagrid3Amount + "','USR01','CASH','" + profit + "','"+tboxDiscount.Text+"')";
                     db.setDbConnection(out command, ref query);
                     command.ExecuteReader();
                     command.Connection.Close();
                    
                    //update client set debt = '30' where name = 'Uche';
                     getClientDebt(ref dbDebt);

                     updateDebt(dbDebt, Debt);


                    MessageBox.Show(dbDebt.ToString());
                    
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
        }

      

      
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagrid3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void autoFillTxtBox()
        {
        }
        public Boolean clienttboxCehecker()
        {
            string txt = textBoxClients.Text;
            if (txt != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TextBoxwhleSaler_TextChange(object sender, EventArgs e)
        {

        }

        private void datagrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void LoadValues(ref int dbId,ref int dbItemqty,ref int weBuy) //done
        {
            con = new OleDbConnection(db.cnnString);
            con.Open();
           
            string CommandText = "select * from items where ITEM_NAME ='"+datagrid3Name+"'";
            accessAdapter = new OleDbDataAdapter(CommandText, con); ;
            DS.Reset();
            accessAdapter.Fill(DS);
            DT = DS.Tables[0];
            datagrid2.DataSource = DT;
            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                  dbItemqty =Convert.ToInt32(DT.Rows[i]["QUANTITY"]);
                  dbId = Convert.ToInt32(DT.Rows[i]["ITEM_CODE"]);
                  weBuy = Convert.ToInt32(DT.Rows[i]["WE_BUY"])*datagrid3Qty;
                  
                  categName = DT.Rows[i]["CATEGORY"].ToString();

                }


            }
            else
            {
                MessageBox.Show("No record found");
            }
            textBoxClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxClients.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxClients.AutoCompleteCustomSource = clients;

            con.Close();
        }
        public void updateItemQty(int dbId,int dbItemqty)
        {
            string setqty = "update items set QUANTITY = '" + dbItemqty + "' where ITEM_CODE ='" + dbId+ "'";
            try
            {
                db.setDbConnection(out command, ref setqty);
                command.ExecuteReader();

                

            }
            catch (Exception ec)
            {
                MessageBox.Show("unable to set item  quantity ");
            }
            finally
            {
                command.Connection.Close();
                datagrid2.Update();
            }
        }
        SQLiteConnection sql = new SQLiteConnection();
        public void SetConnection()
        {

            sql_con = new SQLiteConnection
               (@"Data Source=|DataDirectory|\Proj02DB.db;Version=3;New=False;Compress=True;");

        }
        public void getCategQty1(ref int qtycateg)
        {

            try
            {
                string setCategQty = "select QUANTITY from category  where CATEGORY ='" + categName + "'";


                con = new OleDbConnection(db.cnnString);
                con.Open();
                
                accessAdapter = new OleDbDataAdapter(setCategQty, con);
                DS.Reset();
                accessAdapter.Fill(DS);

                DT = DS.Tables[0];


                if (DT.Rows.Count > 0)
                {
                    qtycateg = Convert.ToInt32(DT.Rows[0]["QUANTITY"]);
                   
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
                con.Close();
            }

        }



        public void updateCategQty(int qtycateg)
        {
            try
            {
                MessageBox.Show("categ :" + categName + " " + "quantity :" + qtycateg);
                string updateCateg = "UPDATE category  SET QUANTITY  = " + qtycateg + " where CATEGORY  =" + categName ;
                db.setDbConnection(out command, ref updateCateg);
                command.ExecuteReader();
               

                //to remove letter
                

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
       

     

       

        private void cashtbox1_TextChange(object sender, EventArgs e)
        {

        }

        private void datagridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void datagridClient_Click(object sender, EventArgs e)
        {

        }

        private void datagridClient_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void removeOderbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridView rows in datagridClient.SelectedRows)
            {
                
            }
        }

        private void textBoxClients_TextChange_1(object sender, EventArgs e)
        {
            labelNotSave();
            try
            {


              //QuerySearch(CommandText, datagridClient);

                AccesssearchClient();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void AccesssearchData()
        {


            try
            {


              //  string CommandText = " SELECT * FROM client WHERE  `CIENT_NAME` LIKE '" + textBoxClients.Text + "%'";






                //tring Query = "select * from items;";

                //Query = "SELECT * FROM items WHERE CONCAT( `ITEM_NAME`, `CATEGORY`, `QUANTITY`,`DATE_POSTED`) like '%" + valueToSearch + "%' ";
                string CommandText = " SELECT * FROM items WHERE  ITEM_NAME LIKE '" + nametbox1.Text + "%'  ";


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
                datagridClient.DataSource = DT;
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
        
        

        private void nametbox1_TextChange_1(object sender, EventArgs e)
        {
            //Auto(); error when trying to change the text
            labelNotSave();
            //string CommandText = " SELECT * FROM items WHERE  `Name` LIKE '" + nametbox1.Text + "%' OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

           // QuerySearch(CommandText, datagrid2);
            AccesssearchData();
        }

        private void addOder_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (radioBtnWhlSeller1.Checked == true)
                {
                    cost = Convert.ToInt32(datagrid2WhleSalerPrice) * Convert.ToInt32(quantitytbox1.Text);
                    orderTable(Convert.ToInt32(datagrid2WhleSalerPrice));
                }
                else
                {
                    cost = Convert.ToInt32(datagrid2RetailerPrice) * Convert.ToInt32(quantitytbox1.Text);
                    orderTable(Convert.ToInt32(datagrid2RetailerPrice));
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            tranxid = random.Next(500000);
            if (cashtbox1.Text == "")
            {
                // cashtbox1.Text = "0";
                MessageBox.Show("Please enter the cash paid by the client");

            }
            else
            {
                try
                {

                    if (labelClientName.Text != "Not selected")
                    {
                        if (datagrid3.Rows.Count > 1)
                        {

                            insertInvoice(tranxid);
                            
                            //insertTranxaction(tranxid);
                            labelStatus.ForeColor = Color.FromArgb(50, 0, 50, 0);



                            labelStatus.Text = "Invoice saved successfully";
                        }
                        else
                        {
                            MessageBox.Show("Please click \"Add order\" before save");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select Client from the above");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error adding invoice");
                    MessageBox.Show(ex.ToString());


                }

            }
        }

        private void printbtn_Click_1(object sender, EventArgs e)
        {
            if (cashtbox1.Text == "")
            {
                MessageBox.Show("please enter the \"Cash paid\"");
                cashtbox1.Focus();
            }
            else if (labelStatus.Text == "Invoice not save")
            {
                MessageBox.Show("Please click \"Save\" before Print ");

            }
            else
            {
                cashPayed = Convert.ToInt32(cashtbox1.Text);
                if (tboxDiscount.Text == "")
                {
                    debt = total - cashPayed;
                }
                else
                {
                    debt = total - cashPayed - Convert.ToInt32(tboxDiscount.Text);
                }
               







                /* string CurrentDate = DateTime.Now.ToString("yyyyMMdd");
                datagrid3.Rows.Clear();
                using (PrintForm frm = new PrintForm(resiptBindingSource.DataSource as List<Resipt>, string.Format("{0}", total), string.Format("{0}$", cashtbox1.Text), string.Format("{0:0.00}$", Convert.ToDouble(cashtbox1.Text) - total), CurrentDate))
                {
                    frm.ShowDialog();
                }
                * */
                easyHTMLReports1.Clear();
                // easyHTMLReports1.AddImage(Image.FromFile(null), "wisth= 100, style= 'float:right'");
                easyHTMLReports1.AddString("<h1>Invoice</h1>");
                easyHTMLReports1.AddString("<h3><i>INV#</i></h3>");
                DataTable dt = new DataTable();
                dt.Columns.Add("FROM");
                dt.Columns.Add("FOR");
                dt.Rows.Add(new object[] { "G-HUB", clientName });
                dt.Rows.Add(new object[] { "090000002", clientPhone });
                dt.Rows.Add(new object[] { "GARKI ABUJA TINIBU PLAZA SHOP NO.33", clientAddress });

                easyHTMLReports1.AddDataTable(dt);
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddDatagridView(datagrid3);
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddString("TOTAL :" + total.ToString());
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddString("CASH PAID :" + cashPayed.ToString());
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddString("DEBT :" + debt.ToString());
                datagrid3.Rows.Clear();
                easyHTMLReports1.ShowPrintPreviewDialog();





            }
            
           
        }

        private void datagridClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            datagrid2clientId = datagridClient.Rows[0].Cells[0].Value.ToString();

            clientName = datagridClient.Rows[0].Cells[1].Value.ToString();
            clientPhone = datagridClient.Rows[0].Cells[2].Value.ToString();
            clientAddress = datagridClient.Rows[0].Cells[3].Value.ToString();
            labelClientName.Text = clientName;
            //textBoxClients.Clear();
        }

        private void datagrid2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


            try
            {

                datagrid2Categ = datagrid2.SelectedRows[0].Cells[7].Value.ToString();
                datagrid2Item_code = datagrid2.SelectedRows[0].Cells[9].Value.ToString();
                datagrid2Date = datagrid2.SelectedRows[0].Cells[10].Value.ToString();
                datagrid2Name = datagrid2.SelectedRows[0].Cells[1].Value.ToString();
                datagrid2Qty = datagrid2.SelectedRows[0].Cells[3].Value.ToString();
                datagrid2WhleSalerPrice = datagrid2.SelectedRows[0].Cells[5].Value.ToString();
                datagrid2RetailerPrice = datagrid2.SelectedRows[0].Cells[6].Value.ToString();
                datagridWeBuy = Convert.ToInt32(datagrid2.SelectedRows[0].Cells[2].Value);
                TextBoxwhleSaler.Text = datagrid2.SelectedRows[0].Cells[0].Value.ToString();
                quantitytbox1.Text = datagrid2Qty;
                TextBoxwhleSaler.Text = datagrid2WhleSalerPrice;
                TextBoxRetailer.Text = datagrid2RetailerPrice;
                nametbox1.Text = datagrid2Name;


            }
            catch (Exception ex)
            {

            }
        




           

        }

        private void quantitytbox1_TextChange(object sender, EventArgs e)
        {

        }
        

       
    }
}
