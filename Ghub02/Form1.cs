using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ghub02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int wlparam);


      

      

       

      
        private void formInPanel(object forminpanel)
        {
            if (this.panelContainer.Controls.Count > 0)
            {

                this.panelContainer.Controls.RemoveAt(0);
            }
            Form form = forminpanel as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(form);
            this.panelContainer.Tag = form;
            form.Show();
            // form.BringToFront();


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
       
        private void productbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
           
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void maximizbtn_Click_1(object sender, EventArgs e)
        {
           
        }

        private void nomalizerbtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void minimizbtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void TittleInfo_MouseDown_1(object sender, MouseEventArgs e)
        {
           
        }

        private void salebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nomalizerbtn.Visible = false;
           // DBHandler db = new DBHandler();
           // panelContainer.BackColor = Color.FromArgb(100, 200, 200, 200);
        }

        private void TittleInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productbtn_Click_1(object sender, EventArgs e)
        {
            formInPanel(new FormStock());
        }

        private void salebtn_Click_1(object sender, EventArgs e)
        {
            formInPanel(new FormSale());
        }

        private void clientbtn_Click_1(object sender, EventArgs e)
        {
            formInPanel(new FormClient());
        }

        private void btnstore_Click(object sender, EventArgs e)
        {

        }

        private void btnreport_Click_1(object sender, EventArgs e)
        {
            formInPanel(new FormReport());
        }

        private void btnslide_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 252)
            {
                MenuVertical.Width = 106;
            }
            else
            {
                MenuVertical.Width = 252;
            }
        }

        private void maximizbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizbtn.Hide();
            nomalizerbtn.Show();
        }

        private void nomalizerbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            nomalizerbtn.Hide();
            maximizbtn.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TittleInfo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
