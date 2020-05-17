namespace Ghub02
{
    partial class RemoveItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveItem));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRetailer = new System.Windows.Forms.Label();
            this.labelWhleSale = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.savebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dscr = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.TextBoxRetailer = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.TextBoxwhleSaler = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.quantitytbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pricetbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.nametbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(108, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Select Stock from this table";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(489, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 38);
            this.panel2.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "Remove item";
            // 
            // datagrid2
            // 
            this.datagrid2.BackgroundColor = System.Drawing.Color.White;
            this.datagrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.datagrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid2.Location = new System.Drawing.Point(489, 150);
            this.datagrid2.Name = "datagrid2";
            this.datagrid2.Size = new System.Drawing.Size(483, 364);
            this.datagrid2.TabIndex = 103;
            this.datagrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.label1.Location = new System.Drawing.Point(22, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 101;
            this.label1.Text = "Category";
            // 
            // labelRetailer
            // 
            this.labelRetailer.AutoSize = true;
            this.labelRetailer.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelRetailer.Location = new System.Drawing.Point(22, 377);
            this.labelRetailer.Name = "labelRetailer";
            this.labelRetailer.Size = new System.Drawing.Size(82, 26);
            this.labelRetailer.TabIndex = 94;
            this.labelRetailer.Text = "Retailer";
            // 
            // labelWhleSale
            // 
            this.labelWhleSale.AutoSize = true;
            this.labelWhleSale.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelWhleSale.Location = new System.Drawing.Point(22, 324);
            this.labelWhleSale.Name = "labelWhleSale";
            this.labelWhleSale.Size = new System.Drawing.Size(119, 26);
            this.labelWhleSale.TabIndex = 93;
            this.labelWhleSale.Text = "Whole saler";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelQty.Location = new System.Drawing.Point(22, 271);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(93, 26);
            this.labelQty.TabIndex = 92;
            this.labelQty.Text = "Quantity";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelPrice.Location = new System.Drawing.Point(22, 214);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(80, 26);
            this.labelPrice.TabIndex = 91;
            this.labelPrice.Text = "We buy";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelName.Location = new System.Drawing.Point(22, 163);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 26);
            this.labelName.TabIndex = 90;
            this.labelName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 51);
            this.panel1.TabIndex = 89;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Location = new System.Drawing.Point(167, 436);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(216, 21);
            this.comboBoxCateg.TabIndex = 88;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
            this.savebtn.ButtonText = "Delete";
            this.savebtn.ButtonTextMarginLeft = 0;
            this.savebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.savebtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.savebtn.DisabledForecolor = System.Drawing.Color.White;
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.savebtn.IconPadding = 10;
            this.savebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.savebtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.savebtn.IdleBorderRadius = 40;
            this.savebtn.IdleBorderThickness = 0;
            this.savebtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.savebtn.IdleIconLeftImage = null;
            this.savebtn.IdleIconRightImage = null;
            this.savebtn.Location = new System.Drawing.Point(851, 538);
            this.savebtn.Name = "savebtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(66)))), ((int)(((byte)(55)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.savebtn.onHoverState = stateProperties1;
            this.savebtn.Size = new System.Drawing.Size(172, 42);
            this.savebtn.TabIndex = 102;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // dscr
            // 
            this.dscr.AcceptsReturn = false;
            this.dscr.AcceptsTab = false;
            this.dscr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.dscr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.dscr.BackColor = System.Drawing.Color.Transparent;
            this.dscr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dscr.BackgroundImage")));
            this.dscr.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.dscr.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dscr.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.dscr.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.dscr.BorderRadius = 40;
            this.dscr.BorderThickness = 2;
            this.dscr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dscr.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dscr.DefaultText = "";
            this.dscr.FillColor = System.Drawing.Color.White;
            this.dscr.HideSelection = true;
            this.dscr.IconLeft = null;
            this.dscr.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.dscr.IconPadding = 10;
            this.dscr.IconRight = null;
            this.dscr.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.dscr.Location = new System.Drawing.Point(61, 484);
            this.dscr.MaxLength = 32767;
            this.dscr.MinimumSize = new System.Drawing.Size(100, 35);
            this.dscr.Modified = false;
            this.dscr.Name = "dscr";
            this.dscr.PasswordChar = '\0';
            this.dscr.ReadOnly = false;
            this.dscr.SelectedText = "";
            this.dscr.SelectionLength = 0;
            this.dscr.SelectionStart = 0;
            this.dscr.ShortcutsEnabled = true;
            this.dscr.Size = new System.Drawing.Size(322, 61);
            this.dscr.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.dscr.TabIndex = 100;
            this.dscr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dscr.TextMarginLeft = 5;
            this.dscr.TextPlaceholder = "Description";
            this.dscr.UseSystemPasswordChar = false;
            // 
            // TextBoxRetailer
            // 
            this.TextBoxRetailer.AcceptsReturn = false;
            this.TextBoxRetailer.AcceptsTab = false;
            this.TextBoxRetailer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxRetailer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxRetailer.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxRetailer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxRetailer.BackgroundImage")));
            this.TextBoxRetailer.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxRetailer.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.TextBoxRetailer.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.TextBoxRetailer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.TextBoxRetailer.BorderRadius = 40;
            this.TextBoxRetailer.BorderThickness = 2;
            this.TextBoxRetailer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxRetailer.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRetailer.DefaultText = "";
            this.TextBoxRetailer.FillColor = System.Drawing.Color.White;
            this.TextBoxRetailer.HideSelection = true;
            this.TextBoxRetailer.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBoxRetailer.IconLeft")));
            this.TextBoxRetailer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxRetailer.IconPadding = 10;
            this.TextBoxRetailer.IconRight = null;
            this.TextBoxRetailer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxRetailer.Location = new System.Drawing.Point(170, 366);
            this.TextBoxRetailer.MaxLength = 32767;
            this.TextBoxRetailer.MinimumSize = new System.Drawing.Size(100, 35);
            this.TextBoxRetailer.Modified = false;
            this.TextBoxRetailer.Name = "TextBoxRetailer";
            this.TextBoxRetailer.PasswordChar = '\0';
            this.TextBoxRetailer.ReadOnly = false;
            this.TextBoxRetailer.SelectedText = "";
            this.TextBoxRetailer.SelectionLength = 0;
            this.TextBoxRetailer.SelectionStart = 0;
            this.TextBoxRetailer.ShortcutsEnabled = true;
            this.TextBoxRetailer.Size = new System.Drawing.Size(180, 48);
            this.TextBoxRetailer.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.TextBoxRetailer.TabIndex = 99;
            this.TextBoxRetailer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxRetailer.TextMarginLeft = 5;
            this.TextBoxRetailer.TextPlaceholder = "Price";
            this.TextBoxRetailer.UseSystemPasswordChar = false;
            // 
            // TextBoxwhleSaler
            // 
            this.TextBoxwhleSaler.AcceptsReturn = false;
            this.TextBoxwhleSaler.AcceptsTab = false;
            this.TextBoxwhleSaler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxwhleSaler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxwhleSaler.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxwhleSaler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxwhleSaler.BackgroundImage")));
            this.TextBoxwhleSaler.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxwhleSaler.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.TextBoxwhleSaler.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.TextBoxwhleSaler.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.TextBoxwhleSaler.BorderRadius = 40;
            this.TextBoxwhleSaler.BorderThickness = 2;
            this.TextBoxwhleSaler.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxwhleSaler.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxwhleSaler.DefaultText = "";
            this.TextBoxwhleSaler.FillColor = System.Drawing.Color.White;
            this.TextBoxwhleSaler.HideSelection = true;
            this.TextBoxwhleSaler.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBoxwhleSaler.IconLeft")));
            this.TextBoxwhleSaler.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxwhleSaler.IconPadding = 10;
            this.TextBoxwhleSaler.IconRight = null;
            this.TextBoxwhleSaler.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxwhleSaler.Location = new System.Drawing.Point(170, 312);
            this.TextBoxwhleSaler.MaxLength = 32767;
            this.TextBoxwhleSaler.MinimumSize = new System.Drawing.Size(100, 35);
            this.TextBoxwhleSaler.Modified = false;
            this.TextBoxwhleSaler.Name = "TextBoxwhleSaler";
            this.TextBoxwhleSaler.PasswordChar = '\0';
            this.TextBoxwhleSaler.ReadOnly = false;
            this.TextBoxwhleSaler.SelectedText = "";
            this.TextBoxwhleSaler.SelectionLength = 0;
            this.TextBoxwhleSaler.SelectionStart = 0;
            this.TextBoxwhleSaler.ShortcutsEnabled = true;
            this.TextBoxwhleSaler.Size = new System.Drawing.Size(179, 48);
            this.TextBoxwhleSaler.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.TextBoxwhleSaler.TabIndex = 98;
            this.TextBoxwhleSaler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxwhleSaler.TextMarginLeft = 5;
            this.TextBoxwhleSaler.TextPlaceholder = "Price";
            this.TextBoxwhleSaler.UseSystemPasswordChar = false;
            // 
            // quantitytbox
            // 
            this.quantitytbox.AcceptsReturn = false;
            this.quantitytbox.AcceptsTab = false;
            this.quantitytbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.quantitytbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.quantitytbox.BackColor = System.Drawing.Color.Transparent;
            this.quantitytbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quantitytbox.BackgroundImage")));
            this.quantitytbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.quantitytbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.quantitytbox.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.quantitytbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.quantitytbox.BorderRadius = 40;
            this.quantitytbox.BorderThickness = 2;
            this.quantitytbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantitytbox.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytbox.DefaultText = "";
            this.quantitytbox.FillColor = System.Drawing.Color.White;
            this.quantitytbox.HideSelection = true;
            this.quantitytbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("quantitytbox.IconLeft")));
            this.quantitytbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.quantitytbox.IconPadding = 10;
            this.quantitytbox.IconRight = null;
            this.quantitytbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.quantitytbox.Location = new System.Drawing.Point(170, 258);
            this.quantitytbox.MaxLength = 32767;
            this.quantitytbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.quantitytbox.Modified = false;
            this.quantitytbox.Name = "quantitytbox";
            this.quantitytbox.PasswordChar = '\0';
            this.quantitytbox.ReadOnly = false;
            this.quantitytbox.SelectedText = "";
            this.quantitytbox.SelectionLength = 0;
            this.quantitytbox.SelectionStart = 0;
            this.quantitytbox.ShortcutsEnabled = true;
            this.quantitytbox.Size = new System.Drawing.Size(121, 48);
            this.quantitytbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.quantitytbox.TabIndex = 97;
            this.quantitytbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantitytbox.TextMarginLeft = 5;
            this.quantitytbox.TextPlaceholder = "Quantity";
            this.quantitytbox.UseSystemPasswordChar = false;
            // 
            // pricetbox
            // 
            this.pricetbox.AcceptsReturn = false;
            this.pricetbox.AcceptsTab = false;
            this.pricetbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pricetbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pricetbox.BackColor = System.Drawing.Color.Transparent;
            this.pricetbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pricetbox.BackgroundImage")));
            this.pricetbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.pricetbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pricetbox.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.pricetbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.pricetbox.BorderRadius = 40;
            this.pricetbox.BorderThickness = 2;
            this.pricetbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pricetbox.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetbox.DefaultText = "";
            this.pricetbox.FillColor = System.Drawing.Color.White;
            this.pricetbox.HideSelection = true;
            this.pricetbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("pricetbox.IconLeft")));
            this.pricetbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.pricetbox.IconPadding = 10;
            this.pricetbox.IconRight = null;
            this.pricetbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.pricetbox.Location = new System.Drawing.Point(170, 204);
            this.pricetbox.MaxLength = 32767;
            this.pricetbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.pricetbox.Modified = false;
            this.pricetbox.Name = "pricetbox";
            this.pricetbox.PasswordChar = '\0';
            this.pricetbox.ReadOnly = false;
            this.pricetbox.SelectedText = "";
            this.pricetbox.SelectionLength = 0;
            this.pricetbox.SelectionStart = 0;
            this.pricetbox.ShortcutsEnabled = true;
            this.pricetbox.Size = new System.Drawing.Size(166, 48);
            this.pricetbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.pricetbox.TabIndex = 96;
            this.pricetbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pricetbox.TextMarginLeft = 5;
            this.pricetbox.TextPlaceholder = "Price";
            this.pricetbox.UseSystemPasswordChar = false;
            // 
            // nametbox
            // 
            this.nametbox.AcceptsReturn = false;
            this.nametbox.AcceptsTab = false;
            this.nametbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nametbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nametbox.BackColor = System.Drawing.Color.Transparent;
            this.nametbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nametbox.BackgroundImage")));
            this.nametbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.nametbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.nametbox.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.nametbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.nametbox.BorderRadius = 40;
            this.nametbox.BorderThickness = 2;
            this.nametbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nametbox.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametbox.DefaultText = "";
            this.nametbox.FillColor = System.Drawing.Color.White;
            this.nametbox.HideSelection = true;
            this.nametbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("nametbox.IconLeft")));
            this.nametbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.nametbox.IconPadding = 10;
            this.nametbox.IconRight = null;
            this.nametbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.nametbox.Location = new System.Drawing.Point(170, 150);
            this.nametbox.MaxLength = 32767;
            this.nametbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.nametbox.Modified = false;
            this.nametbox.Name = "nametbox";
            this.nametbox.PasswordChar = '\0';
            this.nametbox.ReadOnly = false;
            this.nametbox.SelectedText = "";
            this.nametbox.SelectionLength = 0;
            this.nametbox.SelectionStart = 0;
            this.nametbox.ShortcutsEnabled = true;
            this.nametbox.Size = new System.Drawing.Size(228, 48);
            this.nametbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.nametbox.TabIndex = 95;
            this.nametbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nametbox.TextMarginLeft = 5;
            this.nametbox.TextPlaceholder = "Name of the item";
            this.nametbox.UseSystemPasswordChar = false;
            this.nametbox.TextChange += new System.EventHandler(this.nametbox_TextChange);
            // 
            // RemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagrid2);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dscr);
            this.Controls.Add(this.TextBoxRetailer);
            this.Controls.Add(this.TextBoxwhleSaler);
            this.Controls.Add(this.quantitytbox);
            this.Controls.Add(this.pricetbox);
            this.Controls.Add(this.nametbox);
            this.Controls.Add(this.labelRetailer);
            this.Controls.Add(this.labelWhleSale);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCateg);
            this.Location = new System.Drawing.Point(10, 0);
            this.Name = "RemoveItem";
            this.Size = new System.Drawing.Size(1116, 676);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagrid2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton savebtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox dscr;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextBoxRetailer;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextBoxwhleSaler;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox quantitytbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox pricetbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nametbox;
        private System.Windows.Forms.Label labelRetailer;
        private System.Windows.Forms.Label labelWhleSale;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCateg;
    }
}
