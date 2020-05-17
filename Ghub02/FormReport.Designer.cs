namespace Ghub02
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.exitbtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthlybtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalSale = new System.Windows.Forms.Label();
            this.labelToatalProfit = new System.Windows.Forms.Label();
            this.panelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.Location = new System.Drawing.Point(978, 75);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(66, 38);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitbtn.TabIndex = 69;
            this.exitbtn.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 55);
            this.panel1.TabIndex = 77;
            // 
            // monthlybtn
            // 
            this.monthlybtn.BackColor = System.Drawing.Color.Transparent;
            this.monthlybtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monthlybtn.BackgroundImage")));
            this.monthlybtn.ButtonText = "Monthly Report";
            this.monthlybtn.ButtonTextMarginLeft = 0;
            this.monthlybtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.monthlybtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.monthlybtn.DisabledForecolor = System.Drawing.Color.RosyBrown;
            this.monthlybtn.ForeColor = System.Drawing.Color.White;
            this.monthlybtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.monthlybtn.IconPadding = 10;
            this.monthlybtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.monthlybtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.monthlybtn.IdleBorderRadius = 35;
            this.monthlybtn.IdleBorderThickness = 0;
            this.monthlybtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.monthlybtn.IdleIconLeftImage = null;
            this.monthlybtn.IdleIconRightImage = null;
            this.monthlybtn.Location = new System.Drawing.Point(291, 522);
            this.monthlybtn.Name = "monthlybtn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.monthlybtn.onHoverState = stateProperties2;
            this.monthlybtn.Size = new System.Drawing.Size(181, 47);
            this.monthlybtn.TabIndex = 72;
            this.monthlybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monthlybtn.Click += new System.EventHandler(this.monthlybtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 34);
            this.label1.TabIndex = 70;
            this.label1.Text = "Total Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(647, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 73;
            this.label2.Text = "Profit";
            // 
            // labelTotalSale
            // 
            this.labelTotalSale.AutoSize = true;
            this.labelTotalSale.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSale.ForeColor = System.Drawing.Color.Black;
            this.labelTotalSale.Location = new System.Drawing.Point(244, 292);
            this.labelTotalSale.Name = "labelTotalSale";
            this.labelTotalSale.Size = new System.Drawing.Size(45, 29);
            this.labelTotalSale.TabIndex = 74;
            this.labelTotalSale.Text = "nn";
            // 
            // labelToatalProfit
            // 
            this.labelToatalProfit.AutoSize = true;
            this.labelToatalProfit.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToatalProfit.ForeColor = System.Drawing.Color.Black;
            this.labelToatalProfit.Location = new System.Drawing.Point(681, 292);
            this.labelToatalProfit.Name = "labelToatalProfit";
            this.labelToatalProfit.Size = new System.Drawing.Size(45, 29);
            this.labelToatalProfit.TabIndex = 75;
            this.labelToatalProfit.Text = "nn";
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelbtn.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelbtn.ForeColor = System.Drawing.Color.White;
            this.panelbtn.Location = new System.Drawing.Point(214, 169);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(600, 53);
            this.panelbtn.TabIndex = 76;
            this.panelbtn.Text = "REPORT";
            this.panelbtn.UseVisualStyleBackColor = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbtn);
            this.Controls.Add(this.labelToatalProfit);
            this.Controls.Add(this.labelTotalSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthlybtn);
            this.Controls.Add(this.exitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 40);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton monthlybtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalSale;
        private System.Windows.Forms.Label labelToatalProfit;
        private System.Windows.Forms.Button panelbtn;

    }
}