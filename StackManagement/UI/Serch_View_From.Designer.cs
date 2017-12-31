namespace StackManagement.UI
{
    partial class Serch_View_From
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serch_View_From));
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesAndSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.companyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.serchButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lnk_Prev = new MetroFramework.Controls.MetroLink();
            this.deshbordButton = new MetroFramework.Controls.MetroButton();
            this.backtoDeshbordTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.metroContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.BackgroundImage = global::StackManagement.Properties.Resources.settings_png_image_51342;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtoDeshbordTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.Location = new System.Drawing.Point(766, 44);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(54, 53);
            this.menuButton.Style = MetroFramework.MetroColorStyle.Black;
            this.menuButton.TabIndex = 14;
            this.menuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // metroContextMenu
            // 
            this.backtoDeshbordTransition.SetDecoration(this.metroContextMenu, BunifuAnimatorNS.DecorationType.None);
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.viewSalesAndSearchToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(192, 136);
            // 
            // categorySetupToolStripMenuItem
            // 
            this.categorySetupToolStripMenuItem.Name = "categorySetupToolStripMenuItem";
            this.categorySetupToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.categorySetupToolStripMenuItem.Text = "Category Setup";
            this.categorySetupToolStripMenuItem.Click += new System.EventHandler(this.categorySetupToolStripMenuItem_Click);
            // 
            // companySetupToolStripMenuItem
            // 
            this.companySetupToolStripMenuItem.Name = "companySetupToolStripMenuItem";
            this.companySetupToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.companySetupToolStripMenuItem.Text = "Company Setup";
            this.companySetupToolStripMenuItem.Click += new System.EventHandler(this.companySetupToolStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // viewSalesAndSearchToolStripMenuItem
            // 
            this.viewSalesAndSearchToolStripMenuItem.Name = "viewSalesAndSearchToolStripMenuItem";
            this.viewSalesAndSearchToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewSalesAndSearchToolStripMenuItem.Text = "View Sales And Search";
            this.viewSalesAndSearchToolStripMenuItem.Click += new System.EventHandler(this.viewSalesAndSearchToolStripMenuItem_Click);
            // 
            // serchListView
            // 
            this.serchListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.serchListView.AllowDrop = true;
            this.serchListView.AllowSorting = true;
            this.serchListView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serchListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.backtoDeshbordTransition.SetDecoration(this.serchListView, BunifuAnimatorNS.DecorationType.None);
            this.serchListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.serchListView.ForeColor = System.Drawing.Color.Lavender;
            this.serchListView.FullRowSelect = true;
            this.serchListView.GridLines = true;
            this.serchListView.HoverSelection = true;
            this.serchListView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.serchListView.Location = new System.Drawing.Point(22, 215);
            this.serchListView.Name = "serchListView";
            this.serchListView.OwnerDraw = true;
            this.serchListView.Size = new System.Drawing.Size(810, 378);
            this.serchListView.Style = MetroFramework.MetroColorStyle.Brown;
            this.serchListView.TabIndex = 16;
            this.serchListView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serchListView.UseCompatibleStateImageBehavior = false;
            this.serchListView.UseCustomBackColor = true;
            this.serchListView.UseCustomForeColor = true;
            this.serchListView.UseSelectable = true;
            this.serchListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SL#";
            this.columnHeader7.Width = 123;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Item Name";
            this.columnHeader8.Width = 147;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Companpy";
            this.columnHeader9.Width = 161;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Av. Quentity";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reorder Lavel";
            this.columnHeader3.Width = 124;
            // 
            // categoryComboBox
            // 
            this.backtoDeshbordTransition.SetDecoration(this.categoryComboBox, BunifuAnimatorNS.DecorationType.None);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.ItemHeight = 23;
            this.categoryComboBox.Location = new System.Drawing.Point(400, 127);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(170, 29);
            this.categoryComboBox.TabIndex = 17;
            this.categoryComboBox.UseSelectable = true;
            // 
            // companyComboBox
            // 
            this.backtoDeshbordTransition.SetDecoration(this.companyComboBox, BunifuAnimatorNS.DecorationType.None);
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.ItemHeight = 23;
            this.companyComboBox.Location = new System.Drawing.Point(400, 82);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(170, 29);
            this.companyComboBox.TabIndex = 17;
            this.companyComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.backtoDeshbordTransition.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(285, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Company";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.backtoDeshbordTransition.SetDecoration(this.metroLabel2, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel2.Location = new System.Drawing.Point(285, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Category";
            // 
            // serchButton
            // 
            this.serchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.backtoDeshbordTransition.SetDecoration(this.serchButton, BunifuAnimatorNS.DecorationType.None);
            this.serchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serchButton.Location = new System.Drawing.Point(495, 166);
            this.serchButton.Name = "serchButton";
            this.serchButton.Size = new System.Drawing.Size(75, 29);
            this.serchButton.TabIndex = 19;
            this.serchButton.Text = "Search";
            this.serchButton.UseCustomBackColor = true;
            this.serchButton.UseCustomForeColor = true;
            this.serchButton.UseSelectable = true;
            this.serchButton.Click += new System.EventHandler(this.serchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.backtoDeshbordTransition.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(269, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 146);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serch And View";
            // 
            // lnk_Prev
            // 
            this.lnk_Prev.BackColor = System.Drawing.Color.Black;
            this.backtoDeshbordTransition.SetDecoration(this.lnk_Prev, BunifuAnimatorNS.DecorationType.None);
            this.lnk_Prev.Image = global::StackManagement.Properties.Resources.back_left_arrow_botton_32;
            this.lnk_Prev.ImageSize = 32;
            this.lnk_Prev.Location = new System.Drawing.Point(22, 22);
            this.lnk_Prev.Name = "lnk_Prev";
            this.lnk_Prev.Size = new System.Drawing.Size(44, 35);
            this.lnk_Prev.TabIndex = 21;
            this.lnk_Prev.UseSelectable = true;
            this.lnk_Prev.Click += new System.EventHandler(this.lnk_Prev_Click);
            // 
            // deshbordButton
            // 
            this.backtoDeshbordTransition.SetDecoration(this.deshbordButton, BunifuAnimatorNS.DecorationType.None);
            this.deshbordButton.Location = new System.Drawing.Point(525, 22);
            this.deshbordButton.Name = "deshbordButton";
            this.deshbordButton.Size = new System.Drawing.Size(75, 32);
            this.deshbordButton.TabIndex = 40;
            this.deshbordButton.Text = "DeshBord";
            this.deshbordButton.UseSelectable = true;
            this.deshbordButton.Click += new System.EventHandler(this.deshbordButton_Click);
            // 
            // backtoDeshbordTransition
            // 
            this.backtoDeshbordTransition.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.backtoDeshbordTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.backtoDeshbordTransition.DefaultAnimation = animation1;
            // 
            // Serch_View_From
            // 
            this.AcceptButton = this.serchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(834, 601);
            this.Controls.Add(this.deshbordButton);
            this.Controls.Add(this.lnk_Prev);
            this.Controls.Add(this.serchButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.serchListView);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.groupBox1);
            this.backtoDeshbordTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.Name = "Serch_View_From";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Serch And View";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Serch_View_From_FormClosing);
            this.Load += new System.EventHandler(this.Serch_View_From_Load);
            this.metroContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private MetroFramework.Controls.MetroListView serchListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroComboBox categoryComboBox;
        private MetroFramework.Controls.MetroComboBox companyComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton serchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem viewSalesAndSearchToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lnk_Prev;
        private MetroFramework.Controls.MetroButton deshbordButton;
        private BunifuAnimatorNS.BunifuTransition backtoDeshbordTransition;
    }
}