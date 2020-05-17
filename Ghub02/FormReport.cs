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

namespace Ghub02
{
    public partial class FormReport : Form
    {
        public FormReport()
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

        private void monthlybtn_Click(object sender, EventArgs e)
        {
            totalAmount = 0;
            totalprofit = 0;

            Monthly();
            // labelHeader.Text = "DAILY REPORT";
            panelbtn.Text = "Monthly REPORT";
            labelTotalSale.Text = totalAmount.ToString();
            labelToatalProfit.Text = totalprofit.ToString();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            string Query1 = "SELECT name , quantity, Category ,date_posted FROM items WHERE date_posted  between '2019-08-18' and LAST_DAY('2019-08-19')";

        }


        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int totalAmount = 0;
        private int totalprofit;


        private void Monthly()
        {
            DateTime curDate = DateTime.Now;
            DateTime queryDate = curDate.AddMonths(-1);

            MessageBox.Show(queryDate.ToShortDateString());
         
            ;
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT amount,profit FROM invoice WHERE tranx_date  between '" + queryDate.ToShortDateString() + "' and '" + curDate.ToShortDateString() + "'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            

            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    // string date = DT.Rows[i]["tranx_date"].ToString();
                    //MessageBox.Show(date);
                    int amount = Convert.ToInt32(DT.Rows[i]["amount"]);
                    totalAmount = totalAmount + amount;
                    int profit = Convert.ToInt32(DT.Rows[i]["profit"]);
                    totalprofit = totalprofit + profit;
                }

            }
            sql_con.Close();
        }
        private void Daily()
        {
            try
            {

                DateTime curDate = DateTime.Now;
                DateTime queryDate = curDate.AddDays(1);
                MessageBox.Show(curDate.ToString("yyyy - MM - dd"));
                MessageBox.Show(queryDate.ToString("yyyy - MM - dd"));
             SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "SELECT amount,profit FROM invoice WHERE tranx_date  between '" + queryDate.ToString("yyyy - MM - dd") + "' and '" + curDate.ToString("yyyy - MM - dd") + "'";
                // "SELECT amount,profit FROM invoice WHERE tranx_date  between '2020-03-20' and '2020-03-21'";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);

                DT = DS.Tables[0];
               
                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        // string date = DT.Rows[i]["tranx_date"].ToString();
                        //MessageBox.Show(date);
                        int amount = Convert.ToInt32(DT.Rows[i]["amount"]);
                        totalAmount = totalAmount + amount;
                        int profit = Convert.ToInt32(DT.Rows[i]["profit"]);
                        totalprofit = totalprofit + profit;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            sql_con.Close();
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

      


        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dailybtn_Click(object sender, EventArgs e)
        {
            try
            {
                totalAmount = 0;
                totalprofit = 0;

                Daily();
                // labelHeader.Text = "DAILY REPORT";
                panelbtn.Text = "DAILY REPORT";
                labelTotalSale.Text = totalAmount.ToString();
                labelToatalProfit.Text = totalprofit.ToString();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

       

    }
}
