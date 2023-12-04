namespace tjp_tester
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startInitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInitBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInitStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.setbarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDocumentBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDocumentFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDocumentStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookletFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(557, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bookletToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem.Text = "&Save Output..";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.selectAllToolStripMenuItem.Text = "Copy &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startInitToolStripMenuItem,
            this.loadInitBitmapToolStripMenuItem,
            this.getInitStringToolStripMenuItem,
            this.toolStripSeparator3,
            this.setbarcodeToolStripMenuItem,
            this.startDocumentToolStripMenuItem,
            this.loadDocumentBarcodeToolStripMenuItem,
            this.loadDocumentFieldToolStripMenuItem,
            this.getDocumentStringToolStripMenuItem,
            this.toolStripSeparator2,
            this.getToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.toolStripMenuItem1.Text = "Test &Methods";
            // 
            // startInitToolStripMenuItem
            // 
            this.startInitToolStripMenuItem.Name = "startInitToolStripMenuItem";
            this.startInitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.startInitToolStripMenuItem.Text = "Start&Init";
            this.startInitToolStripMenuItem.Click += new System.EventHandler(this.startInitToolStripMenuItem_Click);
            // 
            // loadInitBitmapToolStripMenuItem
            // 
            this.loadInitBitmapToolStripMenuItem.Name = "loadInitBitmapToolStripMenuItem";
            this.loadInitBitmapToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.loadInitBitmapToolStripMenuItem.Text = "LoadInit&Bitmap..";
            this.loadInitBitmapToolStripMenuItem.Click += new System.EventHandler(this.loadInitBitmapToolStripMenuItem_Click);
            // 
            // getInitStringToolStripMenuItem
            // 
            this.getInitStringToolStripMenuItem.Name = "getInitStringToolStripMenuItem";
            this.getInitStringToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.getInitStringToolStripMenuItem.Text = "&EndInit..";
            this.getInitStringToolStripMenuItem.Click += new System.EventHandler(this.getInitStringToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // setbarcodeToolStripMenuItem
            // 
            this.setbarcodeToolStripMenuItem.Name = "setbarcodeToolStripMenuItem";
            this.setbarcodeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.setbarcodeToolStripMenuItem.Text = "&SetBarcode..";
            this.setbarcodeToolStripMenuItem.Click += new System.EventHandler(this.setbarcodeToolStripMenuItem_Click);
            // 
            // startDocumentToolStripMenuItem
            // 
            this.startDocumentToolStripMenuItem.Name = "startDocumentToolStripMenuItem";
            this.startDocumentToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.startDocumentToolStripMenuItem.Text = "Start&Document";
            this.startDocumentToolStripMenuItem.Click += new System.EventHandler(this.startDocumentToolStripMenuItem_Click);
            // 
            // loadDocumentBarcodeToolStripMenuItem
            // 
            this.loadDocumentBarcodeToolStripMenuItem.Name = "loadDocumentBarcodeToolStripMenuItem";
            this.loadDocumentBarcodeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.loadDocumentBarcodeToolStripMenuItem.Text = "LoadDocument&Barcode..";
            this.loadDocumentBarcodeToolStripMenuItem.Click += new System.EventHandler(this.loadDocumentBarcodeToolStripMenuItem_Click);
            // 
            // loadDocumentFieldToolStripMenuItem
            // 
            this.loadDocumentFieldToolStripMenuItem.Name = "loadDocumentFieldToolStripMenuItem";
            this.loadDocumentFieldToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.loadDocumentFieldToolStripMenuItem.Text = "LoadDocument&Field..";
            this.loadDocumentFieldToolStripMenuItem.Click += new System.EventHandler(this.loadDocumentFieldToolStripMenuItem_Click);
            // 
            // getDocumentStringToolStripMenuItem
            // 
            this.getDocumentStringToolStripMenuItem.Name = "getDocumentStringToolStripMenuItem";
            this.getDocumentStringToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.getDocumentStringToolStripMenuItem.Text = "E&ndDocument..";
            this.getDocumentStringToolStripMenuItem.Click += new System.EventHandler(this.getDocumentStringToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.getToolStripMenuItem.Text = "&GetDimensions";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // bookletToolStripMenuItem
            // 
            this.bookletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBookletFromCSVToolStripMenuItem,
            this.toolStripComboBox1});
            this.bookletToolStripMenuItem.Name = "bookletToolStripMenuItem";
            this.bookletToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.bookletToolStripMenuItem.Text = "Build &Booklet";
            // 
            // makeBookletFromCSVToolStripMenuItem
            // 
            this.makeBookletFromCSVToolStripMenuItem.Name = "makeBookletFromCSVToolStripMenuItem";
            this.makeBookletFromCSVToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.makeBookletFromCSVToolStripMenuItem.Text = "&Make Bold from CSV..";
            this.makeBookletFromCSVToolStripMenuItem.Click += new System.EventHandler(this.makeBookletFromCSVToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "&?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem.Text = "&About..";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(557, 507);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Auto",
            "Zoom 1",
            "Zoom 2",
            "Zoom 3",
            "Zoom 4",
            "Zoom 5"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 553);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TJP Tester";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadInitBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInitStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadDocumentBarcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDocumentFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDocumentStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBookletFromCSVToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startInitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem setbarcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

