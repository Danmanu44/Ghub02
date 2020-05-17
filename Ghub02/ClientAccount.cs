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
    public partial class ClientAccount : UserControl
    {
        public ClientAccount()
        {
            InitializeComponent();
        }

        DBHandler db = new DBHandler();
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        AutoCompleteStringCollection names = new AutoCompleteStringCollection();
        AutoCompleteStringCollection names2 = new AutoCompleteStringCollection();
        private string datagrid2ID;
        private string datagrid2Name;
        private string datagrid2Phone;
        private string datagrid2Address;
        private string datagrid2Debt;
        private int cost;
        private int TranxAmount = 0;



        SQLiteConnection sql = new SQLiteConnection();
        public void SetConnection()
        {

            sql_con = new SQLiteConnection
               (@"Data Source=|DataDirectory|\Proj02DB.db;Version=3;New=False;Compress=True;");

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
        private void LoadData()
        {
         SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = " SELECT * FROM invoice WHERE  client_id = '" + datagrid2ID + "'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
           // datagrid2.DataSource = DT;
            string curDate  = "date";
            string prevDate = "prevDate";
            string dscr = "";
            string init = "\nTRANSACTION : \n [Tranx#";
            DateTime date;
            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    
                     if (curDate == "date")
                     {
                         
                         date = DateTime.Parse(DT.Rows[i]["tranx_date"].ToString());
                         curDate = date.ToString("dd/MM/yyyy");
                         prevDate = curDate;
                         dscr += init + DT.Rows[i]["tranx_id"].ToString() + "] \n" + DT.Rows[i]["name"].ToString() + " X " + DT.Rows[i]["quantity"].ToString() + "(" + DT.Rows[i]["amount"].ToString() + ") \n";

                     }
                     else
                     {
                         date = DateTime.Parse(DT.Rows[i]["tranx_date"].ToString());
                         curDate = date.ToString("dd/MM/yyyy");
                         if (prevDate == curDate)
                         {
                             dscr += DT.Rows[i]["name"].ToString() + "x" + DT.Rows[i]["quantity"].ToString() + "(" + DT.Rows[i]["amount"].ToString() + ") \n";

                            
                         }
                         else
                         {


                             try
                             {
                                 datagrid3.Rows.Add(prevDate, dscr);
                             }
                             catch (Exception ec)
                             {
                                 MessageBox.Show(ec.ToString());
                             }
                             prevDate = curDate;
                             dscr += init + DT.Rows[i]["tranx_id"].ToString() + "] \n" + DT.Rows[i]["name"].ToString() + " X " + DT.Rows[i]["quantity"].ToString() + "(" + DT.Rows[i]["amount"].ToString() + ") \n";


                         }

                     }

                   
                }
                MessageBox.Show(dscr);
               /// datagrid2.Rows.Add(dscr);
                
            }
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


                searchtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                searchtbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                searchtbox.AutoCompleteCustomSource = names;
                sql_con.Close(); ;



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }


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

        private void searchtbox_TextChange(object sender, EventArgs e)
        {

            string CommandText = " SELECT * FROM client WHERE `Name`  LIKE '" + searchtbox.Text + "%'   or  `id`  LIKE '" +searchtbox.Text +"%'  OR Name GLOB '*[^a-zA-Z][mM][iI][xX]*' ";

            QuerySearch(CommandText, datagrid2);
        }

        private void datagrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                datagrid2ID = datagrid2.SelectedRows[0].Cells[0].Value.ToString();
                datagrid2Debt = datagrid2.SelectedRows[0].Cells[4].Value.ToString();
                datagrid2Address = datagrid2.SelectedRows[0].Cells[3].Value.ToString();
                datagrid2Name = datagrid2.SelectedRows[0].Cells[1].Value.ToString();
                datagrid2Phone = datagrid2.SelectedRows[0].Cells[2].Value.ToString();
                
                labelName1.Text = datagrid2Name;
                labelPhone1.Text = datagrid2Phone;
                labelAddress1.Text = datagrid2Address;
                labelDebt.Text = datagrid2Debt;
                //getTranx(datagrid2ID);
                LoadData();
                labelTranxAmount.Text = TranxAmount.ToString();



            }
            catch (Exception ex)
            {

            }
        
        }

        private void getTranx(string ClientId)
        {

            try
            {

                 string query = " SELECT * FROM invoice WHERE  client_id = '"+datagrid2ID+"'";

             SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                //CommandText = query;
                DB = new SQLiteDataAdapter(query, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                datagrid3.DataSource = DT;
                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                       int amount = Convert.ToInt32(DT.Rows[i]["amount"]);
                       TranxAmount += amount;
                    }
                }
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void printTranx_Click(object sender, EventArgs e)
        {
            if (searchtbox.Text == "")
            {
                MessageBox.Show("please enter the \"Client ID/Name \"");
                searchtbox.Focus();
            }
            
            else
            {
                







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
                easyHTMLReports1.AddString("<c><h3><i>Client Transaction</i></h3></c>");
                DataTable dt = new DataTable();
                dt.Columns.Add("FROM");
                dt.Columns.Add("FOR");
                dt.Rows.Add(new object[] { "G-HUB", labelName1.Text });
                dt.Rows.Add(new object[] { "090000002", labelPhone1.Text });
                dt.Rows.Add(new object[] { "GARKI ABUJA TINIBU PLAZA SHOP NO.33", labelAddress1.Text });

                easyHTMLReports1.AddDataTable(dt);
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddDatagridView(datagrid3);
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddString("TOTAL TRANSACTION AMOUNT :" + labelTranxAmount.Text);
                easyHTMLReports1.AddLineBreak();
            
                easyHTMLReports1.AddString("DEBT :" +labelDebt.Text);
               
                easyHTMLReports1.ShowPrintPreviewDialog();





            }
            
           
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClientAccount_Load(object sender, EventArgs e)
        {
           // LoadData();
        }
    }
}
