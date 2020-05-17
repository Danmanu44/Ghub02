namespace Ghub02
{
    partial class AddItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRetailer = new System.Windows.Forms.Label();
            this.labelWhleSale = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dscr = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.TextBoxRetailer = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.TextBoxwhleSaler = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.unittbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.quantitytbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pricetbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.nametbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnbrowse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessDb01DataSet1 = new Ghub02.accessDb01DataSet1();
            this.itemsTableAdapter = new Ghub02.accessDb01DataSet1TableAdapters.itemsTableAdapter();
            this.accessDb01DataSet5 = new Ghub02.accessDb01DataSet5();
            this.itemsTableAdapter3 = new Ghub02.accessDb01DataSet5TableAdapters.itemsTableAdapter();
            this.clname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colweBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDb01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDb01DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clname,
            this.colweBuy,
            this.qty,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column1,
            this.Column2,
            this.ColId,
            this.Column3,
            this.ColImage});
            this.datagrid.Location = new System.Drawing.Point(513, 201);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(516, 369);
            this.datagrid.TabIndex = 58;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "Add new item";
            // 
            // labelRetailer
            // 
            this.labelRetailer.AutoSize = true;
            this.labelRetailer.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelRetailer.Location = new System.Drawing.Point(22, 364);
            this.labelRetailer.Name = "labelRetailer";
            this.labelRetailer.Size = new System.Drawing.Size(82, 26);
            this.labelRetailer.TabIndex = 57;
            this.labelRetailer.Text = "Retailer";
            // 
            // labelWhleSale
            // 
            this.labelWhleSale.AutoSize = true;
            this.labelWhleSale.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelWhleSale.Location = new System.Drawing.Point(22, 311);
            this.labelWhleSale.Name = "labelWhleSale";
            this.labelWhleSale.Size = new System.Drawing.Size(119, 26);
            this.labelWhleSale.TabIndex = 56;
            this.labelWhleSale.Text = "Whole saler";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelQty.Location = new System.Drawing.Point(22, 258);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(93, 26);
            this.labelQty.TabIndex = 55;
            this.labelQty.Text = "Quantity";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelPrice.Location = new System.Drawing.Point(22, 201);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(80, 26);
            this.labelPrice.TabIndex = 54;
            this.labelPrice.Text = "We buy";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelName.Location = new System.Drawing.Point(22, 150);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 26);
            this.labelName.TabIndex = 53;
            this.labelName.Text = "Name";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelUnit.Location = new System.Drawing.Point(306, 258);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(53, 26);
            this.labelUnit.TabIndex = 52;
            this.labelUnit.Text = "Unit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 51);
            this.panel1.TabIndex = 51;
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
            this.comboBoxCateg.Location = new System.Drawing.Point(155, 423);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(216, 21);
            this.comboBoxCateg.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.label1.Location = new System.Drawing.Point(22, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 66;
            this.label1.Text = "Category";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
            this.savebtn.ButtonText = "Save";
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
            this.savebtn.Location = new System.Drawing.Point(49, 547);
            this.savebtn.Name = "savebtn";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.savebtn.onHoverState = stateProperties3;
            this.savebtn.Size = new System.Drawing.Size(322, 49);
            this.savebtn.TabIndex = 67;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click_1);
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
            this.dscr.Location = new System.Drawing.Point(49, 480);
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
            this.dscr.TabIndex = 65;
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
            this.TextBoxRetailer.Location = new System.Drawing.Point(155, 353);
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
            this.TextBoxRetailer.TabIndex = 64;
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
            this.TextBoxwhleSaler.Location = new System.Drawing.Point(155, 299);
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
            this.TextBoxwhleSaler.TabIndex = 63;
            this.TextBoxwhleSaler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxwhleSaler.TextMarginLeft = 5;
            this.TextBoxwhleSaler.TextPlaceholder = "Price";
            this.TextBoxwhleSaler.UseSystemPasswordChar = false;
            // 
            // unittbox
            // 
            this.unittbox.AcceptsReturn = false;
            this.unittbox.AcceptsTab = false;
            this.unittbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.unittbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.unittbox.BackColor = System.Drawing.Color.Transparent;
            this.unittbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unittbox.BackgroundImage")));
            this.unittbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.unittbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.unittbox.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.unittbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.unittbox.BorderRadius = 40;
            this.unittbox.BorderThickness = 2;
            this.unittbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.unittbox.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unittbox.DefaultText = "";
            this.unittbox.FillColor = System.Drawing.Color.White;
            this.unittbox.HideSelection = true;
            this.unittbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("unittbox.IconLeft")));
            this.unittbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.unittbox.IconPadding = 10;
            this.unittbox.IconRight = null;
            this.unittbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.unittbox.Location = new System.Drawing.Point(374, 245);
            this.unittbox.MaxLength = 32767;
            this.unittbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.unittbox.Modified = false;
            this.unittbox.Name = "unittbox";
            this.unittbox.PasswordChar = '\0';
            this.unittbox.ReadOnly = false;
            this.unittbox.SelectedText = "";
            this.unittbox.SelectionLength = 0;
            this.unittbox.SelectionStart = 0;
            this.unittbox.ShortcutsEnabled = true;
            this.unittbox.Size = new System.Drawing.Size(121, 48);
            this.unittbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.unittbox.TabIndex = 62;
            this.unittbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.unittbox.TextMarginLeft = 5;
            this.unittbox.TextPlaceholder = "eg Bag...";
            this.unittbox.UseSystemPasswordChar = false;
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
            this.quantitytbox.Location = new System.Drawing.Point(155, 245);
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
            this.quantitytbox.TabIndex = 61;
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
            this.pricetbox.Location = new System.Drawing.Point(155, 191);
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
            this.pricetbox.TabIndex = 60;
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
            this.nametbox.Location = new System.Drawing.Point(155, 137);
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
            this.nametbox.TabIndex = 59;
            this.nametbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nametbox.TextMarginLeft = 5;
            this.nametbox.TextPlaceholder = "Name of the item";
            this.nametbox.UseSystemPasswordChar = false;
            this.nametbox.TextChange += new System.EventHandler(this.nametbox_TextChange_1);
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnbrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbrowse.BackgroundImage")));
            this.btnbrowse.ButtonText = "Browse image";
            this.btnbrowse.ButtonTextMarginLeft = 0;
            this.btnbrowse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnbrowse.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnbrowse.DisabledForecolor = System.Drawing.Color.White;
            this.btnbrowse.ForeColor = System.Drawing.Color.White;
            this.btnbrowse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnbrowse.IconPadding = 10;
            this.btnbrowse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnbrowse.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnbrowse.IdleBorderRadius = 10;
            this.btnbrowse.IdleBorderThickness = 0;
            this.btnbrowse.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnbrowse.IdleIconLeftImage = null;
            this.btnbrowse.IdleIconRightImage = null;
            this.btnbrowse.Location = new System.Drawing.Point(374, 453);
            this.btnbrowse.Name = "btnbrowse";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnbrowse.onHoverState = stateProperties4;
            this.btnbrowse.Size = new System.Drawing.Size(121, 42);
            this.btnbrowse.TabIndex = 67;
            this.btnbrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click_1);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.accessDb01DataSet1;
            // 
            // accessDb01DataSet1
            // 
            this.accessDb01DataSet1.DataSetName = "accessDb01DataSet1";
            this.accessDb01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // accessDb01DataSet5
            // 
            this.accessDb01DataSet5.DataSetName = "accessDb01DataSet5";
            this.accessDb01DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter3
            // 
            this.itemsTableAdapter3.ClearBeforeFill = true;
            // 
            // clname
            // 
            this.clname.HeaderText = "NAME";
            this.clname.Name = "clname";
            // 
            // colweBuy
            // 
            this.colweBuy.HeaderText = "WE BUY";
            this.colweBuy.Name = "colweBuy";
            // 
            // qty
            // 
            this.qty.HeaderText = "QUANTITY";
            this.qty.Name = "qty";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "COST";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CATEGORY";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DESCRIPTION";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "WHOLE SELLER PRICE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RETAILER PRICE";
            this.Column2.Name = "Column2";
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ITEM CODE";
            this.ColId.Name = "ColId";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DATE POSTED";
            this.Column3.Name = "Column3";
            // 
            // ColImage
            // 
            this.ColImage.HeaderText = "IMAGE";
            this.ColImage.Name = "ColImage";
            this.ColImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColImage.Visible = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dscr);
            this.Controls.Add(this.TextBoxRetailer);
            this.Controls.Add(this.TextBoxwhleSaler);
            this.Controls.Add(this.unittbox);
            this.Controls.Add(this.quantitytbox);
            this.Controls.Add(this.pricetbox);
            this.Controls.Add(this.nametbox);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.labelRetailer);
            this.Controls.Add(this.labelWhleSale);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCateg);
            this.Location = new System.Drawing.Point(10, 0);
            this.Name = "AddItem";
            this.Size = new System.Drawing.Size(1255, 757);
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDb01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDb01DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRetailer;
        private System.Windows.Forms.Label labelWhleSale;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCateg;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nametbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox pricetbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox quantitytbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox unittbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextBoxwhleSaler;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextBoxRetailer;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox dscr;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton savebtn;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private accessDb01DataSet1 accessDb01DataSet1;
        private accessDb01DataSet1TableAdapters.itemsTableAdapter itemsTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnbrowse;
        private accessDb01DataSet5 accessDb01DataSet5;
        private accessDb01DataSet5TableAdapters.itemsTableAdapter itemsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colweBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn ColImage;

    }
}
