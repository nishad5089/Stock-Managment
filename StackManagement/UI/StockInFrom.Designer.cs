namespace StackManagement.UI
{
    partial class StockInFrom
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.CategoryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchAndViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.itemComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.recorderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.avilableQuentiyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.quentityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.lnk_Prev = new MetroFramework.Controls.MetroLink();
            this.deshbordButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-98, -51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.serchAndViewToolStripMenuItem,
            this.viewSellToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(160, 158);
            this.metroContextMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // CategoryStripMenuItem
            // 
            this.CategoryStripMenuItem.Name = "CategoryStripMenuItem";
            this.CategoryStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.CategoryStripMenuItem.Text = "Category Setup";
            this.CategoryStripMenuItem.Click += new System.EventHandler(this.CategoryStripMenuItem_Click);
            // 
            // companySetupToolStripMenuItem
            // 
            this.companySetupToolStripMenuItem.Name = "companySetupToolStripMenuItem";
            this.companySetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.companySetupToolStripMenuItem.Text = "Company Setup";
            this.companySetupToolStripMenuItem.Click += new System.EventHandler(this.companySetupToolStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // serchAndViewToolStripMenuItem
            // 
            this.serchAndViewToolStripMenuItem.Name = "serchAndViewToolStripMenuItem";
            this.serchAndViewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.serchAndViewToolStripMenuItem.Text = "Serch And View";
            this.serchAndViewToolStripMenuItem.Click += new System.EventHandler(this.serchAndViewToolStripMenuItem_Click);
            // 
            // viewSellToolStripMenuItem
            // 
            this.viewSellToolStripMenuItem.Name = "viewSellToolStripMenuItem";
            this.viewSellToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewSellToolStripMenuItem.Text = "View Sell";
            this.viewSellToolStripMenuItem.Click += new System.EventHandler(this.viewSellToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.ItemHeight = 23;
            this.companyComboBox.Location = new System.Drawing.Point(217, 50);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.PromptText = "--SELECT--";
            this.companyComboBox.Size = new System.Drawing.Size(172, 29);
            this.companyComboBox.TabIndex = 15;
            this.companyComboBox.UseSelectable = true;
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.ItemHeight = 23;
            this.itemComboBox.Location = new System.Drawing.Point(217, 122);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.PromptText = "--SELECT--";
            this.itemComboBox.Size = new System.Drawing.Size(172, 29);
            this.itemComboBox.TabIndex = 15;
            this.itemComboBox.UseSelectable = true;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(78, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Company";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Item";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(78, 202);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Record Lavel";
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
            this.recorderTextBox.Location = new System.Drawing.Point(217, 202);
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
            this.recorderTextBox.TabIndex = 17;
            this.recorderTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recorderTextBox.UseSelectable = true;
            this.recorderTextBox.WaterMark = "Reorder Lavel";
            this.recorderTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.recorderTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.avilableQuentiyTextBox.Location = new System.Drawing.Point(217, 263);
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
            this.avilableQuentiyTextBox.TabIndex = 17;
            this.avilableQuentiyTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.avilableQuentiyTextBox.UseSelectable = true;
            this.avilableQuentiyTextBox.WaterMark = "Avialable Quentity";
            this.avilableQuentiyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.avilableQuentiyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.quentityTextBox.Location = new System.Drawing.Point(217, 319);
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
            this.quentityTextBox.TabIndex = 17;
            this.quentityTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quentityTextBox.UseSelectable = true;
            this.quentityTextBox.WaterMark = "Stock-In Quentity";
            this.quentityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quentityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.quentityTextBox.TextChanged += new System.EventHandler(this.quentityTextBox_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(78, 319);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Stock-In Quantity";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(78, 263);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Avialable Quentity";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(314, 374);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 39);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseCustomBackColor = true;
            this.saveButton.UseCustomForeColor = true;
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(127, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 447);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock In";
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.BackgroundImage = global::StackManagement.Properties.Resources.settings_png_image_51342;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.Location = new System.Drawing.Point(652, 46);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(54, 53);
            this.menuButton.Style = MetroFramework.MetroColorStyle.Black;
            this.menuButton.TabIndex = 13;
            this.menuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // lnk_Prev
            // 
            this.lnk_Prev.BackColor = System.Drawing.Color.Black;
            this.lnk_Prev.Image = global::StackManagement.Properties.Resources.back_left_arrow_botton_32;
            this.lnk_Prev.ImageSize = 32;
            this.lnk_Prev.Location = new System.Drawing.Point(23, 29);
            this.lnk_Prev.Name = "lnk_Prev";
            this.lnk_Prev.Size = new System.Drawing.Size(44, 35);
            this.lnk_Prev.TabIndex = 20;
            this.lnk_Prev.UseSelectable = true;
            this.lnk_Prev.Click += new System.EventHandler(this.lnk_Prev_Click);
            // 
            // deshbordButton
            // 
            this.deshbordButton.Location = new System.Drawing.Point(460, 29);
            this.deshbordButton.Name = "deshbordButton";
            this.deshbordButton.Size = new System.Drawing.Size(75, 32);
            this.deshbordButton.TabIndex = 39;
            this.deshbordButton.Text = "DeshBord";
            this.deshbordButton.UseSelectable = true;
            this.deshbordButton.Click += new System.EventHandler(this.deshbordButton_Click);
            // 
            // StockInFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 590);
            this.Controls.Add(this.deshbordButton);
            this.Controls.Add(this.lnk_Prev);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockInFrom";
            this.Resizable = false;
            this.Text = "Stock In";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockIn_FromClosing);
            this.Load += new System.EventHandler(this.StockIn_Load);
            this.metroContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CategoryStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroComboBox itemComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox recorderTextBox;
        private MetroFramework.Controls.MetroTextBox avilableQuentiyTextBox;
        private MetroFramework.Controls.MetroTextBox quentityTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox companyComboBox;
        private MetroFramework.Controls.MetroButton saveButton;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem serchAndViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSellToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lnk_Prev;
        private MetroFramework.Controls.MetroButton deshbordButton;
    }
}