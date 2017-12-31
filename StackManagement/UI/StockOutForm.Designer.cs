namespace StackManagement.UI
{
    partial class StockOutForm
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
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.quentityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.avilableQuentiyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.recorderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.itemComboBox = new MetroFramework.Controls.MetroComboBox();
            this.companyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.stockOutListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.demageButton = new MetroFramework.Controls.MetroButton();
            this.lostButton = new MetroFramework.Controls.MetroButton();
            this.sellButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.setupCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchAndViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnk_Prev = new MetroFramework.Controls.MetroLink();
            this.deshbordButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Maroon;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(272, 223);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 33);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseCustomBackColor = true;
            this.saveButton.UseCustomForeColor = true;
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // quentityTextBox
            // 
            // 
            // 
            // 
            this.quentityTextBox.CustomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quentityTextBox.CustomButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.quentityTextBox.CustomButton.Image = null;
            this.quentityTextBox.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quentityTextBox.CustomButton.Location = new System.Drawing.Point(144, 2);
            this.quentityTextBox.CustomButton.Name = "";
            this.quentityTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.quentityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quentityTextBox.CustomButton.TabIndex = 1;
            this.quentityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quentityTextBox.CustomButton.UseSelectable = true;
            this.quentityTextBox.CustomButton.Visible = false;
            this.quentityTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.quentityTextBox.Lines = new string[0];
            this.quentityTextBox.Location = new System.Drawing.Point(175, 180);
            this.quentityTextBox.MaxLength = 32767;
            this.quentityTextBox.Name = "quentityTextBox";
            this.quentityTextBox.PasswordChar = '\0';
            this.quentityTextBox.PromptText = "Stock-In Quentity";
            this.quentityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quentityTextBox.SelectedText = "";
            this.quentityTextBox.SelectionLength = 0;
            this.quentityTextBox.SelectionStart = 0;
            this.quentityTextBox.ShortcutsEnabled = true;
            this.quentityTextBox.Size = new System.Drawing.Size(172, 30);
            this.quentityTextBox.TabIndex = 26;
            this.quentityTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quentityTextBox.UseSelectable = true;
            this.quentityTextBox.WaterMark = "Stock-In Quentity";
            this.quentityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quentityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.quentityTextBox.TextChanged += new System.EventHandler(this.quentityTextBox_TextChanged);
            // 
            // avilableQuentiyTextBox
            // 
            // 
            // 
            // 
            this.avilableQuentiyTextBox.CustomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avilableQuentiyTextBox.CustomButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.avilableQuentiyTextBox.CustomButton.Image = null;
            this.avilableQuentiyTextBox.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.avilableQuentiyTextBox.CustomButton.Location = new System.Drawing.Point(144, 2);
            this.avilableQuentiyTextBox.CustomButton.Name = "";
            this.avilableQuentiyTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.avilableQuentiyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.avilableQuentiyTextBox.CustomButton.TabIndex = 1;
            this.avilableQuentiyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.avilableQuentiyTextBox.CustomButton.UseSelectable = true;
            this.avilableQuentiyTextBox.CustomButton.Visible = false;
            this.avilableQuentiyTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.avilableQuentiyTextBox.Lines = new string[0];
            this.avilableQuentiyTextBox.Location = new System.Drawing.Point(175, 140);
            this.avilableQuentiyTextBox.MaxLength = 32767;
            this.avilableQuentiyTextBox.Name = "avilableQuentiyTextBox";
            this.avilableQuentiyTextBox.PasswordChar = '\0';
            this.avilableQuentiyTextBox.PromptText = "Avialable Quentity";
            this.avilableQuentiyTextBox.ReadOnly = true;
            this.avilableQuentiyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.avilableQuentiyTextBox.SelectedText = "";
            this.avilableQuentiyTextBox.SelectionLength = 0;
            this.avilableQuentiyTextBox.SelectionStart = 0;
            this.avilableQuentiyTextBox.ShortcutsEnabled = true;
            this.avilableQuentiyTextBox.Size = new System.Drawing.Size(172, 30);
            this.avilableQuentiyTextBox.TabIndex = 27;
            this.avilableQuentiyTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.avilableQuentiyTextBox.UseSelectable = true;
            this.avilableQuentiyTextBox.WaterMark = "Avialable Quentity";
            this.avilableQuentiyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.avilableQuentiyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // recorderTextBox
            // 
            // 
            // 
            // 
            this.recorderTextBox.CustomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recorderTextBox.CustomButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.recorderTextBox.CustomButton.Image = null;
            this.recorderTextBox.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recorderTextBox.CustomButton.Location = new System.Drawing.Point(144, 2);
            this.recorderTextBox.CustomButton.Name = "";
            this.recorderTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.recorderTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.recorderTextBox.CustomButton.TabIndex = 1;
            this.recorderTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recorderTextBox.CustomButton.UseSelectable = true;
            this.recorderTextBox.CustomButton.Visible = false;
            this.recorderTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.recorderTextBox.Lines = new string[0];
            this.recorderTextBox.Location = new System.Drawing.Point(175, 99);
            this.recorderTextBox.MaxLength = 32767;
            this.recorderTextBox.Name = "recorderTextBox";
            this.recorderTextBox.PasswordChar = '\0';
            this.recorderTextBox.PromptText = "Reorder Lavel";
            this.recorderTextBox.ReadOnly = true;
            this.recorderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recorderTextBox.SelectedText = "";
            this.recorderTextBox.SelectionLength = 0;
            this.recorderTextBox.SelectionStart = 0;
            this.recorderTextBox.ShortcutsEnabled = true;
            this.recorderTextBox.Size = new System.Drawing.Size(172, 30);
            this.recorderTextBox.TabIndex = 28;
            this.recorderTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recorderTextBox.UseSelectable = true;
            this.recorderTextBox.WaterMark = "Reorder Lavel";
            this.recorderTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.recorderTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(36, 184);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = " Quantity";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(36, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Avialable Quentity";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Record Lavel";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Item";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Company";
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.ItemHeight = 23;
            this.itemComboBox.Location = new System.Drawing.Point(175, 55);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.PromptText = "--SELECT--";
            this.itemComboBox.Size = new System.Drawing.Size(172, 29);
            this.itemComboBox.TabIndex = 19;
            this.itemComboBox.UseSelectable = true;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.ItemHeight = 23;
            this.companyComboBox.Location = new System.Drawing.Point(175, 11);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.PromptText = "--SELECT--";
            this.companyComboBox.Size = new System.Drawing.Size(172, 29);
            this.companyComboBox.TabIndex = 20;
            this.companyComboBox.UseSelectable = true;
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // stockOutListView
            // 
            this.stockOutListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.stockOutListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stockOutListView.FullRowSelect = true;
            this.stockOutListView.GridLines = true;
            this.stockOutListView.Location = new System.Drawing.Point(32, 326);
            this.stockOutListView.Name = "stockOutListView";
            this.stockOutListView.OwnerDraw = true;
            this.stockOutListView.Size = new System.Drawing.Size(674, 214);
            this.stockOutListView.TabIndex = 30;
            this.stockOutListView.UseCompatibleStateImageBehavior = false;
            this.stockOutListView.UseSelectable = true;
            this.stockOutListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.Width = 201;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quentity";
            this.columnHeader4.Width = 242;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "cmpId";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "itemId";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "AvQ";
            this.columnHeader7.Width = 0;
            // 
            // demageButton
            // 
            this.demageButton.Location = new System.Drawing.Point(305, 546);
            this.demageButton.Name = "demageButton";
            this.demageButton.Size = new System.Drawing.Size(75, 32);
            this.demageButton.TabIndex = 31;
            this.demageButton.Text = "Demage";
            this.demageButton.UseSelectable = true;
            this.demageButton.Click += new System.EventHandler(this.demageButton_Click);
            // 
            // lostButton
            // 
            this.lostButton.Location = new System.Drawing.Point(518, 546);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(75, 32);
            this.lostButton.TabIndex = 32;
            this.lostButton.Text = "Lost";
            this.lostButton.UseSelectable = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(114, 546);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 32);
            this.sellButton.TabIndex = 33;
            this.sellButton.Text = "Sell";
            this.sellButton.UseSelectable = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupCategoryToolStripMenuItem,
            this.setupCompanyToolStripMenuItem,
            this.setupItemToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.serchAndViewToolStripMenuItem,
            this.sellViewToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(160, 136);
            // 
            // setupCategoryToolStripMenuItem
            // 
            this.setupCategoryToolStripMenuItem.Name = "setupCategoryToolStripMenuItem";
            this.setupCategoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.setupCategoryToolStripMenuItem.Text = "Setup Category";
            this.setupCategoryToolStripMenuItem.Click += new System.EventHandler(this.setupCategoryToolStripMenuItem_Click);
            // 
            // setupCompanyToolStripMenuItem
            // 
            this.setupCompanyToolStripMenuItem.Name = "setupCompanyToolStripMenuItem";
            this.setupCompanyToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.setupCompanyToolStripMenuItem.Text = "Setup Company";
            this.setupCompanyToolStripMenuItem.Click += new System.EventHandler(this.setupCompanyToolStripMenuItem_Click);
            // 
            // setupItemToolStripMenuItem
            // 
            this.setupItemToolStripMenuItem.Name = "setupItemToolStripMenuItem";
            this.setupItemToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.setupItemToolStripMenuItem.Text = "Setup Item";
            this.setupItemToolStripMenuItem.Click += new System.EventHandler(this.setupItemToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // serchAndViewToolStripMenuItem
            // 
            this.serchAndViewToolStripMenuItem.Name = "serchAndViewToolStripMenuItem";
            this.serchAndViewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.serchAndViewToolStripMenuItem.Text = "Serch And View";
            this.serchAndViewToolStripMenuItem.Click += new System.EventHandler(this.serchAndViewToolStripMenuItem_Click);
            // 
            // sellViewToolStripMenuItem
            // 
            this.sellViewToolStripMenuItem.Name = "sellViewToolStripMenuItem";
            this.sellViewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sellViewToolStripMenuItem.Text = "Sell View";
            this.sellViewToolStripMenuItem.Click += new System.EventHandler(this.sellViewToolStripMenuItem_Click);
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.BackgroundImage = global::StackManagement.Properties.Resources.settings_png_image_51342;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.Location = new System.Drawing.Point(663, 44);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(54, 53);
            this.menuButton.Style = MetroFramework.MetroColorStyle.Black;
            this.menuButton.TabIndex = 34;
            this.menuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.quentityTextBox);
            this.groupBox1.Controls.Add(this.avilableQuentiyTextBox);
            this.groupBox1.Controls.Add(this.recorderTextBox);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.itemComboBox);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(180, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 268);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Out";
            // 
            // lnk_Prev
            // 
            this.lnk_Prev.BackColor = System.Drawing.Color.Black;
            this.lnk_Prev.Image = global::StackManagement.Properties.Resources.back_left_arrow_botton_32;
            this.lnk_Prev.ImageSize = 32;
            this.lnk_Prev.Location = new System.Drawing.Point(23, 29);
            this.lnk_Prev.Name = "lnk_Prev";
            this.lnk_Prev.Size = new System.Drawing.Size(44, 35);
            this.lnk_Prev.TabIndex = 36;
            this.lnk_Prev.UseSelectable = true;
            this.lnk_Prev.Click += new System.EventHandler(this.lnk_Prev_Click);
            // 
            // deshbordButton
            // 
            this.deshbordButton.Location = new System.Drawing.Point(563, 23);
            this.deshbordButton.Name = "deshbordButton";
            this.deshbordButton.Size = new System.Drawing.Size(75, 41);
            this.deshbordButton.TabIndex = 37;
            this.deshbordButton.Text = "DeshBord";
            this.deshbordButton.UseSelectable = true;
            this.deshbordButton.Click += new System.EventHandler(this.deshbordButton_Click);
            // 
            // StockOutForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(729, 590);
            this.Controls.Add(this.deshbordButton);
            this.Controls.Add(this.lnk_Prev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.lostButton);
            this.Controls.Add(this.demageButton);
            this.Controls.Add(this.stockOutListView);
            this.MaximizeBox = false;
            this.Name = "StockOutForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Stock Out";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.StockOutForm_Load);
            this.metroContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroTextBox quentityTextBox;
        private MetroFramework.Controls.MetroTextBox avilableQuentiyTextBox;
        private MetroFramework.Controls.MetroTextBox recorderTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox itemComboBox;
        private MetroFramework.Controls.MetroComboBox companyComboBox;
        private MetroFramework.Controls.MetroListView stockOutListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroButton demageButton;
        private MetroFramework.Controls.MetroButton lostButton;
        private MetroFramework.Controls.MetroButton sellButton;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem setupCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem serchAndViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellViewToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLink lnk_Prev;
        private MetroFramework.Controls.MetroButton deshbordButton;
    }
}