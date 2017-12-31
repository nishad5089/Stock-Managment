namespace StackManagement.UI
{
    partial class ViewSellForm
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
            this.fromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.toDateTime = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serchSaledButton = new System.Windows.Forms.Button();
            this.printButton = new MetroFramework.Controls.MetroButton();
            this.saledListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.lnk_Prev = new MetroFramework.Controls.MetroLink();
            this.deshbordButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.metroContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromDateTime
            // 
            this.fromDateTime.CustomFormat = "yyyy-MM-d";
            this.fromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTime.Location = new System.Drawing.Point(295, 88);
            this.fromDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDateTime.Name = "fromDateTime";
            this.fromDateTime.Size = new System.Drawing.Size(200, 29);
            this.fromDateTime.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(196, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "From Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(196, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "To Date";
            // 
            // toDateTime
            // 
            this.toDateTime.CustomFormat = "yyyy-MM-d";
            this.toDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTime.Location = new System.Drawing.Point(295, 148);
            this.toDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDateTime.Name = "toDateTime";
            this.toDateTime.Size = new System.Drawing.Size(200, 29);
            this.toDateTime.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serchSaledButton);
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Location = new System.Drawing.Point(175, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale View";
            // 
            // serchSaledButton
            // 
            this.serchSaledButton.BackColor = System.Drawing.Color.Maroon;
            this.serchSaledButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.serchSaledButton.Location = new System.Drawing.Point(245, 126);
            this.serchSaledButton.Name = "serchSaledButton";
            this.serchSaledButton.Size = new System.Drawing.Size(75, 39);
            this.serchSaledButton.TabIndex = 5;
            this.serchSaledButton.Text = "Search";
            this.serchSaledButton.UseVisualStyleBackColor = false;
            this.serchSaledButton.Click += new System.EventHandler(this.serchSaledButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Maroon;
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(120, 126);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(86, 34);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Print";
            this.printButton.UseCustomBackColor = true;
            this.printButton.UseCustomForeColor = true;
            this.printButton.UseSelectable = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // saledListView
            // 
            this.saledListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.saledListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saledListView.FullRowSelect = true;
            this.saledListView.GridLines = true;
            this.saledListView.Location = new System.Drawing.Point(85, 282);
            this.saledListView.Name = "saledListView";
            this.saledListView.OwnerDraw = true;
            this.saledListView.Size = new System.Drawing.Size(538, 296);
            this.saledListView.TabIndex = 5;
            this.saledListView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saledListView.UseCompatibleStateImageBehavior = false;
            this.saledListView.UseSelectable = true;
            this.saledListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL#";
            this.columnHeader1.Width = 224;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 169;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sale Quentity";
            this.columnHeader3.Width = 140;
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.serchToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(160, 136);
            // 
            // categorySetupToolStripMenuItem
            // 
            this.categorySetupToolStripMenuItem.Name = "categorySetupToolStripMenuItem";
            this.categorySetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.categorySetupToolStripMenuItem.Text = "Category Setup";
            this.categorySetupToolStripMenuItem.Click += new System.EventHandler(this.categorySetupToolStripMenuItem_Click);
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
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // serchToolStripMenuItem
            // 
            this.serchToolStripMenuItem.Name = "serchToolStripMenuItem";
            this.serchToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.serchToolStripMenuItem.Text = "Serch & View";
            this.serchToolStripMenuItem.Click += new System.EventHandler(this.serchToolStripMenuItem_Click);
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.BackgroundImage = global::StackManagement.Properties.Resources.settings_png_image_51342;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.Location = new System.Drawing.Point(671, 48);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(54, 53);
            this.menuButton.Style = MetroFramework.MetroColorStyle.Black;
            this.menuButton.TabIndex = 15;
            this.menuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // lnk_Prev
            // 
            this.lnk_Prev.BackColor = System.Drawing.Color.Black;
            this.lnk_Prev.Image = global::StackManagement.Properties.Resources.back_left_arrow_botton_32;
            this.lnk_Prev.ImageSize = 32;
            this.lnk_Prev.Location = new System.Drawing.Point(23, 31);
            this.lnk_Prev.Name = "lnk_Prev";
            this.lnk_Prev.Size = new System.Drawing.Size(44, 35);
            this.lnk_Prev.TabIndex = 17;
            this.lnk_Prev.UseSelectable = true;
            this.lnk_Prev.Click += new System.EventHandler(this.lnk_Prev_Click);
            // 
            // deshbordButton
            // 
            this.deshbordButton.Location = new System.Drawing.Point(434, 26);
            this.deshbordButton.Name = "deshbordButton";
            this.deshbordButton.Size = new System.Drawing.Size(75, 32);
            this.deshbordButton.TabIndex = 39;
            this.deshbordButton.Text = "DeshBord";
            this.deshbordButton.UseSelectable = true;
            this.deshbordButton.Click += new System.EventHandler(this.deshbordButton_Click);
            // 
            // ViewSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(729, 590);
            this.Controls.Add(this.deshbordButton);
            this.Controls.Add(this.lnk_Prev);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.saledListView);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.toDateTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fromDateTime);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ViewSellForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "View Sell";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewSellForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.metroContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime fromDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime toDateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button serchSaledButton;
        private MetroFramework.Controls.MetroListView saledListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchToolStripMenuItem;
        private MetroFramework.Controls.MetroButton printButton;
        private MetroFramework.Controls.MetroLink lnk_Prev;
        private MetroFramework.Controls.MetroButton deshbordButton;
    }
}