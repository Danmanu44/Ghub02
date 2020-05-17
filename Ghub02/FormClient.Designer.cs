namespace Ghub02
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.addClientbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxClients = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.updateClientbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.removeClientbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.accountbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(55, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 53);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Clients";
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(55, 220);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(408, 295);
            this.datagrid.TabIndex = 58;
            // 
            // addClientbtn
            // 
            this.addClientbtn.BackColor = System.Drawing.Color.Transparent;
            this.addClientbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addClientbtn.BackgroundImage")));
            this.addClientbtn.ButtonText = "Add Client";
            this.addClientbtn.ButtonTextMarginLeft = 0;
            this.addClientbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.addClientbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.addClientbtn.DisabledForecolor = System.Drawing.Color.RosyBrown;
            this.addClientbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addClientbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addClientbtn.IconPadding = 10;
            this.addClientbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addClientbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.addClientbtn.IdleBorderRadius = 35;
            this.addClientbtn.IdleBorderThickness = 0;
            this.addClientbtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.addClientbtn.IdleIconLeftImage = null;
            this.addClientbtn.IdleIconRightImage = null;
            this.addClientbtn.Location = new System.Drawing.Point(568, 279);
            this.addClientbtn.Name = "addClientbtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.addClientbtn.onHoverState = stateProperties1;
            this.addClientbtn.Size = new System.Drawing.Size(292, 42);
            this.addClientbtn.TabIndex = 59;
            this.addClientbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addClientbtn.Click += new System.EventHandler(this.addClientbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(370, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxClients
            // 
            this.textBoxClients.AcceptsReturn = false;
            this.textBoxClients.AcceptsTab = false;
            this.textBoxClients.AutoCompleteCustomSource.AddRange(new string[] {
            "hafiz",
            "h",
            "jam",
            "host"});
            this.textBoxClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxClients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxClients.BackColor = System.Drawing.Color.Transparent;
            this.textBoxClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxClients.BackgroundImage")));
            this.textBoxClients.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.textBoxClients.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.textBoxClients.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.textBoxClients.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.textBoxClients.BorderRadius = 40;
            this.textBoxClients.BorderThickness = 2;
            this.textBoxClients.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxClients.DefaultFont = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClients.DefaultText = "";
            this.textBoxClients.FillColor = System.Drawing.Color.White;
            this.textBoxClients.HideSelection = true;
            this.textBoxClients.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxClients.IconLeft")));
            this.textBoxClients.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxClients.IconPadding = 10;
            this.textBoxClients.IconRight = null;
            this.textBoxClients.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxClients.Location = new System.Drawing.Point(55, 89);
            this.textBoxClients.MaxLength = 32767;
            this.textBoxClients.MinimumSize = new System.Drawing.Size(100, 35);
            this.textBoxClients.Modified = false;
            this.textBoxClients.Name = "textBoxClients";
            this.textBoxClients.PasswordChar = '\0';
            this.textBoxClients.ReadOnly = false;
            this.textBoxClients.SelectedText = "";
            this.textBoxClients.SelectionLength = 0;
            this.textBoxClients.SelectionStart = 0;
            this.textBoxClients.ShortcutsEnabled = true;
            this.textBoxClients.Size = new System.Drawing.Size(298, 45);
            this.textBoxClients.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.textBoxClients.TabIndex = 63;
            this.textBoxClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxClients.TextMarginLeft = 5;
            this.textBoxClients.TextPlaceholder = "Client name";
            this.textBoxClients.UseSystemPasswordChar = false;
            this.textBoxClients.TextChange += new System.EventHandler(this.textBoxClients_TextChange);
            // 
            // updateClientbtn
            // 
            this.updateClientbtn.BackColor = System.Drawing.Color.Transparent;
            this.updateClientbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateClientbtn.BackgroundImage")));
            this.updateClientbtn.ButtonText = "Update Cient";
            this.updateClientbtn.ButtonTextMarginLeft = 0;
            this.updateClientbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.updateClientbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.updateClientbtn.DisabledForecolor = System.Drawing.Color.RosyBrown;
            this.updateClientbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateClientbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.updateClientbtn.IconPadding = 10;
            this.updateClientbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.updateClientbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.updateClientbtn.IdleBorderRadius = 35;
            this.updateClientbtn.IdleBorderThickness = 0;
            this.updateClientbtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.updateClientbtn.IdleIconLeftImage = null;
            this.updateClientbtn.IdleIconRightImage = null;
            this.updateClientbtn.Location = new System.Drawing.Point(568, 473);
            this.updateClientbtn.Name = "updateClientbtn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.updateClientbtn.onHoverState = stateProperties2;
            this.updateClientbtn.Size = new System.Drawing.Size(292, 42);
            this.updateClientbtn.TabIndex = 62;
            this.updateClientbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeClientbtn
            // 
            this.removeClientbtn.BackColor = System.Drawing.Color.Transparent;
            this.removeClientbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeClientbtn.BackgroundImage")));
            this.removeClientbtn.ButtonText = "Remove Client";
            this.removeClientbtn.ButtonTextMarginLeft = 0;
            this.removeClientbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.removeClientbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.removeClientbtn.DisabledForecolor = System.Drawing.Color.RosyBrown;
            this.removeClientbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeClientbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.removeClientbtn.IconPadding = 10;
            this.removeClientbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.removeClientbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.removeClientbtn.IdleBorderRadius = 35;
            this.removeClientbtn.IdleBorderThickness = 0;
            this.removeClientbtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.removeClientbtn.IdleIconLeftImage = null;
            this.removeClientbtn.IdleIconRightImage = null;
            this.removeClientbtn.Location = new System.Drawing.Point(568, 372);
            this.removeClientbtn.Name = "removeClientbtn";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.removeClientbtn.onHoverState = stateProperties3;
            this.removeClientbtn.Size = new System.Drawing.Size(292, 42);
            this.removeClientbtn.TabIndex = 61;
            this.removeClientbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountbtn
            // 
            this.accountbtn.BackColor = System.Drawing.Color.Transparent;
            this.accountbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountbtn.BackgroundImage")));
            this.accountbtn.ButtonText = "Client Account";
            this.accountbtn.ButtonTextMarginLeft = 0;
            this.accountbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.accountbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.accountbtn.DisabledForecolor = System.Drawing.Color.RosyBrown;
            this.accountbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accountbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.accountbtn.IconPadding = 10;
            this.accountbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.accountbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.accountbtn.IdleBorderRadius = 35;
            this.accountbtn.IdleBorderThickness = 0;
            this.accountbtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.accountbtn.IdleIconLeftImage = null;
            this.accountbtn.IdleIconRightImage = null;
            this.accountbtn.Location = new System.Drawing.Point(568, 198);
            this.accountbtn.Name = "accountbtn";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.accountbtn.onHoverState = stateProperties4;
            this.accountbtn.Size = new System.Drawing.Size(292, 42);
            this.accountbtn.TabIndex = 64;
            this.accountbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountbtn.Click += new System.EventHandler(this.accountbtn_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 687);
            this.Controls.Add(this.accountbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addClientbtn);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxClients);
            this.Controls.Add(this.updateClientbtn);
            this.Controls.Add(this.removeClientbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 40);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addClientbtn;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox textBoxClients;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updateClientbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton removeClientbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton accountbtn;
    }
}