namespace StackManagement.UI
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.categroyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.companyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.itemNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.reorderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchAndViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnk_Prev = new MetroFramework.Controls.MetroLink();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.deshbordButton = new MetroFramework.Controls.MetroButton();
            this.stockInTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.metroContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // categroyComboBox
            // 
            this.stockInTransition.SetDecoration(this.categroyComboBox, BunifuAnimatorNS.DecorationType.None);
            this.categroyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categroyComboBox.FormattingEnabled = true;
            this.categroyComboBox.ItemHeight = 23;
            this.categroyComboBox.Location = new System.Drawing.Point(328, 97);
            this.categroyComboBox.Name = "categroyComboBox";
            this.categroyComboBox.PromptText = "--SELECT---";
            this.categroyComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categroyComboBox.Size = new System.Drawing.Size(152, 29);
            this.categroyComboBox.TabIndex = 0;
            this.categroyComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.categroyComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.stockInTransition.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(206, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Category";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.stockInTransition.SetDecoration(this.metroLabel2, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel2.Location = new System.Drawing.Point(206, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Company Name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // companyComboBox
            // 
            this.stockInTransition.SetDecoration(this.companyComboBox, BunifuAnimatorNS.DecorationType.None);
            this.companyComboBox.FormatString = "sELECT";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.ItemHeight = 23;
            this.companyComboBox.Items.AddRange(new object[] {
            "SELECT"});
            this.companyComboBox.Location = new System.Drawing.Point(328, 164);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.PromptText = "--SELECT--";
            this.companyComboBox.Size = new System.Drawing.Size(152, 29);
            this.companyComboBox.TabIndex = 2;
            this.companyComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.companyComboBox.UseSelectable = true;
            // 
            // itemNameTextBox
            // 
            // 
            // 
            // 
            this.itemNameTextBox.CustomButton.Image = null;
            this.itemNameTextBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.itemNameTextBox.CustomButton.Name = "";
            this.itemNameTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.itemNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.itemNameTextBox.CustomButton.TabIndex = 1;
            this.itemNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itemNameTextBox.CustomButton.UseSelectable = true;
            this.itemNameTextBox.CustomButton.Visible = false;
            this.stockInTransition.SetDecoration(this.itemNameTextBox, BunifuAnimatorNS.DecorationType.None);
            this.itemNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.itemNameTextBox.Lines = new string[0];
            this.itemNameTextBox.Location = new System.Drawing.Point(328, 225);
            this.itemNameTextBox.MaxLength = 32767;
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.PasswordChar = '\0';
            this.itemNameTextBox.PromptText = "Item Name";
            this.itemNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemNameTextBox.SelectedText = "";
            this.itemNameTextBox.SelectionLength = 0;
            this.itemNameTextBox.SelectionStart = 0;
            this.itemNameTextBox.ShortcutsEnabled = true;
            this.itemNameTextBox.Size = new System.Drawing.Size(152, 31);
            this.itemNameTextBox.TabIndex = 4;
            this.itemNameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.itemNameTextBox.UseSelectable = true;
            this.itemNameTextBox.WaterMark = "Item Name";
            this.itemNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.itemNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.stockInTransition.SetDecoration(this.metroLabel3, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel3.Location = new System.Drawing.Point(206, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Item Name";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // reorderTextBox
            // 
            // 
            // 
            // 
            this.reorderTextBox.CustomButton.Image = null;
            this.reorderTextBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.reorderTextBox.CustomButton.Name = "";
            this.reorderTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.reorderTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.reorderTextBox.CustomButton.TabIndex = 1;
            this.reorderTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reorderTextBox.CustomButton.UseSelectable = true;
            this.reorderTextBox.CustomButton.Visible = false;
            this.stockInTransition.SetDecoration(this.reorderTextBox, BunifuAnimatorNS.DecorationType.None);
            this.reorderTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.reorderTextBox.Lines = new string[0];
            this.reorderTextBox.Location = new System.Drawing.Point(328, 289);
            this.reorderTextBox.MaxLength = 32767;
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.PasswordChar = '\0';
            this.reorderTextBox.PromptText = "Reorder lavel";
            this.reorderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reorderTextBox.SelectedText = "";
            this.reorderTextBox.SelectionLength = 0;
            this.reorderTextBox.SelectionStart = 0;
            this.reorderTextBox.ShortcutsEnabled = true;
            this.reorderTextBox.Size = new System.Drawing.Size(152, 31);
            this.reorderTextBox.TabIndex = 6;
            this.reorderTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.reorderTextBox.UseSelectable = true;
            this.reorderTextBox.WaterMark = "Reorder lavel";
            this.reorderTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.reorderTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.stockInTransition.SetDecoration(this.metroLabel4, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel4.Location = new System.Drawing.Point(206, 289);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Reorder Lavel";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // saveButton
            // 
            this.stockInTransition.SetDecoration(this.saveButton, BunifuAnimatorNS.DecorationType.None);
            this.saveButton.Location = new System.Drawing.Point(405, 354);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // metroContextMenu
            // 
            this.stockInTransition.SetDecoration(this.metroContextMenu, BunifuAnimatorNS.DecorationType.None);
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.serchAndViewToolStripMenuItem,
            this.viewSellToolStripMenuItem});
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
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // groupBox1
            // 
            this.stockInTransition.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(168, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 382);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Item";
            // 
            // lnk_Prev
            // 
            this.lnk_Prev.BackColor = System.Drawing.Color.Black;
            this.stockInTransition.SetDecoration(this.lnk_Prev, BunifuAnimatorNS.DecorationType.None);
            this.lnk_Prev.Image = global::StackManagement.Properties.Resources.back_left_arrow_botton_321;
            this.lnk_Prev.ImageSize = 32;
            this.lnk_Prev.Location = new System.Drawing.Point(12, 21);
            this.lnk_Prev.Name = "lnk_Prev";
            this.lnk_Prev.Size = new System.Drawing.Size(44, 35);
            this.lnk_Prev.TabIndex = 13;
            this.lnk_Prev.UseCustomBackColor = true;
            this.lnk_Prev.UseSelectable = true;
            this.lnk_Prev.Click += new System.EventHandler(this.lnk_Prev_Click);
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.BackgroundImage = global::StackManagement.Properties.Resources.settings_png_image_51342__1_;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stockInTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.Location = new System.Drawing.Point(670, 39);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(54, 53);
            this.menuButton.TabIndex = 11;
            this.menuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // deshbordButton
            // 
            this.stockInTransition.SetDecoration(this.deshbordButton, BunifuAnimatorNS.DecorationType.None);
            this.deshbordButton.Location = new System.Drawing.Point(484, 15);
            this.deshbordButton.Name = "deshbordButton";
            this.deshbordButton.Size = new System.Drawing.Size(75, 32);
            this.deshbordButton.TabIndex = 38;
            this.deshbordButton.Text = "DeshBord";
            this.deshbordButton.UseSelectable = true;
            this.deshbordButton.Click += new System.EventHandler(this.deshbordButton_Click);
            // 
            // stockInTransition
            // 
            this.stockInTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.stockInTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.stockInTransition.DefaultAnimation = animation1;
            // 
            // ItemForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 590);
            this.Controls.Add(this.deshbordButton);
            this.Controls.Add(this.lnk_Prev);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.categroyComboBox);
            this.Controls.Add(this.groupBox1);
            this.stockInTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.Name = "ItemForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Setup Item";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupCloseing);
            this.Load += new System.EventHandler(this.Item_Load);
            this.metroContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox categroyComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox companyComboBox;
        private MetroFramework.Controls.MetroTextBox itemNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox reorderTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroButton menuButton;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem serchAndViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSellToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lnk_Prev;
        private MetroFramework.Controls.MetroButton deshbordButton;
        private BunifuAnimatorNS.BunifuTransition stockInTransition;
    }
}