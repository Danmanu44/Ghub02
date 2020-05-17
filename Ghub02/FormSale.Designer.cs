namespace Ghub02
{
    partial class FormSale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSale));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.salebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.updatebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.deletebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.accessDb01DataSet6 = new Ghub02.accessDb01DataSet6();
            this.sellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellTableAdapter = new Ghub02.accessDb01DataSet6TableAdapters.sellTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANXDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANXIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPOSITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wITHDRAWALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDb01DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(106, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 53);
            this.panel1.TabIndex = 24;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sold stock";
            // 
            // datagrid
            // 
            this.datagrid.AutoGenerateColumns = false;
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tRANXDATEDataGridViewTextBoxColumn,
            this.tRANXIDDataGridViewTextBoxColumn,
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.iTEMNAMEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.pROFITDataGridViewTextBoxColumn,
            this.sTAFFIDDataGridViewTextBoxColumn,
            this.pAYTYPEDataGridViewTextBoxColumn,
            this.dEPOSITDataGridViewTextBoxColumn,
            this.wITHDRAWALDataGridViewTextBoxColumn,
            this.bALANCEDataGridViewTextBoxColumn});
            this.datagrid.DataSource = this.sellBindingSource;
            this.datagrid.Location = new System.Drawing.Point(106, 149);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(838, 339);
            this.datagrid.TabIndex = 23;
            // 
            // salebtn
            // 
            this.salebtn.BackColor = System.Drawing.Color.Transparent;
            this.salebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salebtn.BackgroundImage")));
            this.salebtn.ButtonText = "Sale item";
            this.salebtn.ButtonTextMarginLeft = 0;
            this.salebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.salebtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.salebtn.DisabledForecolor = System.Drawing.Color.White;
            this.salebtn.ForeColor = System.Drawing.Color.White;
            this.salebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.salebtn.IconPadding = 10;
            this.salebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.salebtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.salebtn.IdleBorderRadius = 40;
            this.salebtn.IdleBorderThickness = 0;
            this.salebtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.salebtn.IdleIconLeftImage = null;
            this.salebtn.IdleIconRightImage = null;
            this.salebtn.Location = new System.Drawing.Point(106, 545);
            this.salebtn.Name = "salebtn";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.salebtn.onHoverState = stateProperties4;
            this.salebtn.Size = new System.Drawing.Size(172, 42);
            this.salebtn.TabIndex = 68;
            this.salebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.salebtn.Click += new System.EventHandler(this.salebtn_Click_1);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Transparent;
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.ButtonText = "Update sales";
            this.updatebtn.ButtonTextMarginLeft = 0;
            this.updatebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.updatebtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.updatebtn.DisabledForecolor = System.Drawing.Color.White;
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.updatebtn.IconPadding = 10;
            this.updatebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.updatebtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.updatebtn.IdleBorderRadius = 40;
            this.updatebtn.IdleBorderThickness = 0;
            this.updatebtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.updatebtn.IdleIconLeftImage = null;
            this.updatebtn.IdleIconRightImage = null;
            this.updatebtn.Location = new System.Drawing.Point(425, 540);
            this.updatebtn.Name = "updatebtn";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.updatebtn.onHoverState = stateProperties5;
            this.updatebtn.Size = new System.Drawing.Size(172, 42);
            this.updatebtn.TabIndex = 69;
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.ButtonText = "Remove Sales";
            this.deletebtn.ButtonTextMarginLeft = 0;
            this.deletebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.deletebtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.deletebtn.DisabledForecolor = System.Drawing.Color.White;
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deletebtn.IconPadding = 10;
            this.deletebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.deletebtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.IdleBorderRadius = 40;
            this.deletebtn.IdleBorderThickness = 0;
            this.deletebtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.IdleIconLeftImage = null;
            this.deletebtn.IdleIconRightImage = null;
            this.deletebtn.Location = new System.Drawing.Point(777, 540);
            this.deletebtn.Name = "deletebtn";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.deletebtn.onHoverState = stateProperties6;
            this.deletebtn.Size = new System.Drawing.Size(151, 42);
            this.deletebtn.TabIndex = 70;
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // accessDb01DataSet6
            // 
            this.accessDb01DataSet6.DataSetName = "accessDb01DataSet6";
            this.accessDb01DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "sell";
            this.sellBindingSource.DataSource = this.accessDb01DataSet6;
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tRANXDATEDataGridViewTextBoxColumn
            // 
            this.tRANXDATEDataGridViewTextBoxColumn.DataPropertyName = "TRANX_DATE";
            this.tRANXDATEDataGridViewTextBoxColumn.HeaderText = "TRANX_DATE";
            this.tRANXDATEDataGridViewTextBoxColumn.Name = "tRANXDATEDataGridViewTextBoxColumn";
            // 
            // tRANXIDDataGridViewTextBoxColumn
            // 
            this.tRANXIDDataGridViewTextBoxColumn.DataPropertyName = "TRANX_ID";
            this.tRANXIDDataGridViewTextBoxColumn.HeaderText = "TRANX_ID";
            this.tRANXIDDataGridViewTextBoxColumn.Name = "tRANXIDDataGridViewTextBoxColumn";
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            // 
            // iTEMNAMEDataGridViewTextBoxColumn
            // 
            this.iTEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_NAME";
            this.iTEMNAMEDataGridViewTextBoxColumn.HeaderText = "ITEM_NAME";
            this.iTEMNAMEDataGridViewTextBoxColumn.Name = "iTEMNAMEDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            // 
            // pROFITDataGridViewTextBoxColumn
            // 
            this.pROFITDataGridViewTextBoxColumn.DataPropertyName = "PROFIT";
            this.pROFITDataGridViewTextBoxColumn.HeaderText = "PROFIT";
            this.pROFITDataGridViewTextBoxColumn.Name = "pROFITDataGridViewTextBoxColumn";
            // 
            // sTAFFIDDataGridViewTextBoxColumn
            // 
            this.sTAFFIDDataGridViewTextBoxColumn.DataPropertyName = "STAFF_ID";
            this.sTAFFIDDataGridViewTextBoxColumn.HeaderText = "STAFF_ID";
            this.sTAFFIDDataGridViewTextBoxColumn.Name = "sTAFFIDDataGridViewTextBoxColumn";
            // 
            // pAYTYPEDataGridViewTextBoxColumn
            // 
            this.pAYTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAY_TYPE";
            this.pAYTYPEDataGridViewTextBoxColumn.HeaderText = "PAY_TYPE";
            this.pAYTYPEDataGridViewTextBoxColumn.Name = "pAYTYPEDataGridViewTextBoxColumn";
            // 
            // dEPOSITDataGridViewTextBoxColumn
            // 
            this.dEPOSITDataGridViewTextBoxColumn.DataPropertyName = "DEPOSIT";
            this.dEPOSITDataGridViewTextBoxColumn.HeaderText = "DEPOSIT";
            this.dEPOSITDataGridViewTextBoxColumn.Name = "dEPOSITDataGridViewTextBoxColumn";
            // 
            // wITHDRAWALDataGridViewTextBoxColumn
            // 
            this.wITHDRAWALDataGridViewTextBoxColumn.DataPropertyName = "WITHDRAWAL";
            this.wITHDRAWALDataGridViewTextBoxColumn.HeaderText = "WITHDRAWAL";
            this.wITHDRAWALDataGridViewTextBoxColumn.Name = "wITHDRAWALDataGridViewTextBoxColumn";
            // 
            // bALANCEDataGridViewTextBoxColumn
            // 
            this.bALANCEDataGridViewTextBoxColumn.DataPropertyName = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.HeaderText = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.Name = "bALANCEDataGridViewTextBoxColumn";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 764);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.salebtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSale";
            this.Text = "FormSale";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDb01DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagrid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton salebtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updatebtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deletebtn;
        private accessDb01DataSet6 accessDb01DataSet6;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private accessDb01DataSet6TableAdapters.sellTableAdapter sellTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANXDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANXIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPOSITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wITHDRAWALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEDataGridViewTextBoxColumn;
    }
}