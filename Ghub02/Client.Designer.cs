namespace Ghub02
{
    partial class Client
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addresstbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.savebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.phonetbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.nametbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.closebtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(481, 138);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(465, 366);
            this.datagrid.TabIndex = 85;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelQty.Location = new System.Drawing.Point(17, 375);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(86, 26);
            this.labelQty.TabIndex = 84;
            this.labelQty.Text = "Address";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelP.Location = new System.Drawing.Point(22, 290);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(69, 26);
            this.labelP.TabIndex = 83;
            this.labelP.Text = "Phone";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.labelName.Location = new System.Drawing.Point(17, 228);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 26);
            this.labelName.TabIndex = 82;
            this.labelName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "Add new client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 51);
            this.panel1.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ghub02.Properties.Resources.icone_cadastro_cliente_png;
            this.pictureBox1.Location = new System.Drawing.Point(250, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // addresstbox
            // 
            this.addresstbox.AcceptsReturn = false;
            this.addresstbox.AcceptsTab = false;
            this.addresstbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addresstbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addresstbox.BackColor = System.Drawing.Color.Transparent;
            this.addresstbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addresstbox.BackgroundImage")));
            this.addresstbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.addresstbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.addresstbox.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.addresstbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.addresstbox.BorderRadius = 40;
            this.addresstbox.BorderThickness = 2;
            this.addresstbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addresstbox.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstbox.DefaultText = "";
            this.addresstbox.FillColor = System.Drawing.Color.White;
            this.addresstbox.HideSelection = true;
            this.addresstbox.IconLeft = null;
            this.addresstbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addresstbox.IconPadding = 10;
            this.addresstbox.IconRight = null;
            this.addresstbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addresstbox.Location = new System.Drawing.Point(109, 352);
            this.addresstbox.MaxLength = 32767;
            this.addresstbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.addresstbox.Modified = false;
            this.addresstbox.Name = "addresstbox";
            this.addresstbox.PasswordChar = '\0';
            this.addresstbox.ReadOnly = false;
            this.addresstbox.SelectedText = "";
            this.addresstbox.SelectionLength = 0;
            this.addresstbox.SelectionStart = 0;
            this.addresstbox.ShortcutsEnabled = true;
            this.addresstbox.Size = new System.Drawing.Size(303, 76);
            this.addresstbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.addresstbox.TabIndex = 78;
            this.addresstbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addresstbox.TextMarginLeft = 5;
            this.addresstbox.TextPlaceholder = "Address";
            this.addresstbox.UseSystemPasswordChar = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
            this.savebtn.ButtonText = "Save";
            this.savebtn.ButtonTextMarginLeft = 0;
            this.savebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.savebtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.savebtn.DisabledForecolor = System.Drawing.Color.RosyBrown;
            this.savebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.savebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.savebtn.IconPadding = 10;
            this.savebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.savebtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.savebtn.IdleBorderRadius = 35;
            this.savebtn.IdleBorderThickness = 0;
            this.savebtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.savebtn.IdleIconLeftImage = null;
            this.savebtn.IdleIconRightImage = null;
            this.savebtn.Location = new System.Drawing.Point(87, 462);
            this.savebtn.Name = "savebtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.savebtn.onHoverState = stateProperties1;
            this.savebtn.Size = new System.Drawing.Size(348, 42);
            this.savebtn.TabIndex = 79;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click_2);
            // 
            // phonetbox
            // 
            this.phonetbox.AcceptsReturn = false;
            this.phonetbox.AcceptsTab = false;
            this.phonetbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.phonetbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.phonetbox.BackColor = System.Drawing.Color.Transparent;
            this.phonetbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phonetbox.BackgroundImage")));
            this.phonetbox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.phonetbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.phonetbox.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.phonetbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.phonetbox.BorderRadius = 40;
            this.phonetbox.BorderThickness = 2;
            this.phonetbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phonetbox.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetbox.DefaultText = "";
            this.phonetbox.FillColor = System.Drawing.Color.White;
            this.phonetbox.HideSelection = true;
            this.phonetbox.IconLeft = null;
            this.phonetbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.phonetbox.IconPadding = 10;
            this.phonetbox.IconRight = null;
            this.phonetbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.phonetbox.Location = new System.Drawing.Point(109, 280);
            this.phonetbox.MaxLength = 32767;
            this.phonetbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.phonetbox.Modified = false;
            this.phonetbox.Name = "phonetbox";
            this.phonetbox.PasswordChar = '\0';
            this.phonetbox.ReadOnly = false;
            this.phonetbox.SelectedText = "";
            this.phonetbox.SelectionLength = 0;
            this.phonetbox.SelectionStart = 0;
            this.phonetbox.ShortcutsEnabled = true;
            this.phonetbox.Size = new System.Drawing.Size(303, 45);
            this.phonetbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.phonetbox.TabIndex = 80;
            this.phonetbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phonetbox.TextMarginLeft = 5;
            this.phonetbox.TextPlaceholder = "Phone number";
            this.phonetbox.UseSystemPasswordChar = false;
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
            this.nametbox.IconLeft = global::Ghub02.Properties.Resources.icone_cadastro_cliente_png;
            this.nametbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.nametbox.IconPadding = 10;
            this.nametbox.IconRight = null;
            this.nametbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.nametbox.Location = new System.Drawing.Point(109, 218);
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
            this.nametbox.Size = new System.Drawing.Size(303, 45);
            this.nametbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.nametbox.TabIndex = 77;
            this.nametbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nametbox.TextMarginLeft = 5;
            this.nametbox.TextPlaceholder = "Client name";
            this.nametbox.UseSystemPasswordChar = false;
            this.nametbox.TextChange += new System.EventHandler(this.nametbox_TextChange);
            // 
            // closebtn
            // 
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(944, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(60, 51);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebtn.TabIndex = 86;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.addresstbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.phonetbox);
            this.Controls.Add(this.nametbox);
            this.Location = new System.Drawing.Point(10, 0);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(1007, 763);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox addresstbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton savebtn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox phonetbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nametbox;
        private System.Windows.Forms.PictureBox closebtn;
    }
}
