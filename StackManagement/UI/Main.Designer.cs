namespace StackManagement.UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.idTextBox = new MetroFramework.Controls.MetroTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.catNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.categoryListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchAndViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchCatTextBox = new MetroFramework.Controls.MetroTextBox();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.lnk_Prev = new MetroFramework.Controls.MetroLink();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.comTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroContextMenu.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel
            // 
            resources.ApplyResources(this.metroLabel, "metroLabel");
            this.metroLabel.BackColor = System.Drawing.Color.Transparent;
            this.comTransition.SetDecoration(this.metroLabel, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel.ForeColor = System.Drawing.Color.Black;
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.UseCustomBackColor = true;
            this.metroLabel.UseCustomForeColor = true;
            this.metroLabel.UseStyleColors = true;
            // 
            // groupBox
            // 
            this.groupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.resetButton);
            this.groupBox.Controls.Add(this.idTextBox);
            this.groupBox.Controls.Add(this.saveButton);
            this.groupBox.Controls.Add(this.catNameTextBox);
            this.groupBox.Controls.Add(this.bunifuGradientPanel1);
            this.comTransition.SetDecoration(this.groupBox, BunifuAnimatorNS.DecorationType.None);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Name = "groupBox";
            this.groupBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comTransition.SetDecoration(this.resetButton, BunifuAnimatorNS.DecorationType.None);
            this.resetButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.resetButton.ForeColor = System.Drawing.Color.Ivory;
            this.resetButton.Name = "resetButton";
            this.resetButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resetButton.UseCustomBackColor = true;
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // idTextBox
            // 
            // 
            // 
            // 
            this.idTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.idTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.idTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.idTextBox.CustomButton.Name = "";
            this.idTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.idTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.idTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTextBox.CustomButton.UseSelectable = true;
            this.idTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.comTransition.SetDecoration(this.idTextBox, BunifuAnimatorNS.DecorationType.None);
            this.idTextBox.Lines = new string[0];
            resources.ApplyResources(this.idTextBox, "idTextBox");
            this.idTextBox.MaxLength = 32767;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PasswordChar = '\0';
            this.idTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTextBox.SelectedText = "";
            this.idTextBox.SelectionLength = 0;
            this.idTextBox.SelectionStart = 0;
            this.idTextBox.ShortcutsEnabled = true;
            this.idTextBox.UseSelectable = true;
            this.idTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Maroon;
            this.comTransition.SetDecoration(this.saveButton, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = global::StackManagement.Properties.Resources.Ok_icon;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // catNameTextBox
            // 
            this.catNameTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.catNameTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.catNameTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.catNameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.catNameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.catNameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.catNameTextBox.CustomButton.Name = "";
            this.catNameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.catNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.catNameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.catNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.catNameTextBox.CustomButton.UseSelectable = true;
            this.catNameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.comTransition.SetDecoration(this.catNameTextBox, BunifuAnimatorNS.DecorationType.None);
            this.catNameTextBox.DisplayIcon = true;
            this.catNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.catNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.catNameTextBox.Icon = global::StackManagement.Properties.Resources.categories_icon;
            this.catNameTextBox.Lines = new string[0];
            resources.ApplyResources(this.catNameTextBox, "catNameTextBox");
            this.catNameTextBox.MaxLength = 32767;
            this.catNameTextBox.Name = "catNameTextBox";
            this.catNameTextBox.PasswordChar = '\0';
            this.catNameTextBox.PromptText = "Categroy Name";
            this.catNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.catNameTextBox.SelectedText = "";
            this.catNameTextBox.SelectionLength = 0;
            this.catNameTextBox.SelectionStart = 0;
            this.catNameTextBox.ShortcutsEnabled = true;
            this.catNameTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.catNameTextBox.UseCustomBackColor = true;
            this.catNameTextBox.UseCustomForeColor = true;
            this.catNameTextBox.UseSelectable = true;
            this.catNameTextBox.WaterMark = "Categroy Name";
            this.catNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.catNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.catNameTextBox.TextChanged += new System.EventHandler(this.catNameTextBox_TextChanged);
            // 
            // categoryListView
            // 
            resources.ApplyResources(this.categoryListView, "categoryListView");
            this.categoryListView.AllowDrop = true;
            this.categoryListView.AllowSorting = true;
            this.categoryListView.BackColor = System.Drawing.Color.White;
            this.categoryListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.comTransition.SetDecoration(this.categoryListView, BunifuAnimatorNS.DecorationType.None);
            this.categoryListView.ForeColor = System.Drawing.Color.White;
            this.categoryListView.FullRowSelect = true;
            this.categoryListView.GridLines = true;
            this.categoryListView.HoverSelection = true;
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.OwnerDraw = true;
            this.categoryListView.Style = MetroFramework.MetroColorStyle.Blue;
            this.categoryListView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.UseCustomBackColor = true;
            this.categoryListView.UseCustomForeColor = true;
            this.categoryListView.UseSelectable = true;
            this.categoryListView.UseStyleColors = true;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.DoubleClick += new System.EventHandler(this.Listview_DoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.companyStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            resources.ApplyResources(this.itemSetupToolStripMenuItem, "itemSetupToolStripMenuItem");
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            resources.ApplyResources(this.stockInToolStripMenuItem, "stockInToolStripMenuItem");
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comTransition.SetDecoration(this.metroContextMenu, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.metroContextMenu, "metroContextMenu");
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.serchAndViewToolStripMenuItem,
            this.viewSellToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            resources.ApplyResources(this.stockOutToolStripMenuItem, "stockOutToolStripMenuItem");
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // serchAndViewToolStripMenuItem
            // 
            this.serchAndViewToolStripMenuItem.Name = "serchAndViewToolStripMenuItem";
            resources.ApplyResources(this.serchAndViewToolStripMenuItem, "serchAndViewToolStripMenuItem");
            this.serchAndViewToolStripMenuItem.Click += new System.EventHandler(this.serchAndViewToolStripMenuItem_Click);
            // 
            // viewSellToolStripMenuItem
            // 
            this.viewSellToolStripMenuItem.Name = "viewSellToolStripMenuItem";
            resources.ApplyResources(this.viewSellToolStripMenuItem, "viewSellToolStripMenuItem");
            this.viewSellToolStripMenuItem.Click += new System.EventHandler(this.viewSellToolStripMenuItem_Click);
            // 
            // serchCatTextBox
            // 
            // 
            // 
            // 
            this.serchCatTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.serchCatTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.serchCatTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.serchCatTextBox.CustomButton.Name = "";
            this.serchCatTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.serchCatTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serchCatTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.serchCatTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serchCatTextBox.CustomButton.UseSelectable = true;
            this.serchCatTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.comTransition.SetDecoration(this.serchCatTextBox, BunifuAnimatorNS.DecorationType.None);
            this.serchCatTextBox.DisplayIcon = true;
            this.serchCatTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.serchCatTextBox.Icon = global::StackManagement.Properties.Resources.serchcat;
            this.serchCatTextBox.Lines = new string[0];
            resources.ApplyResources(this.serchCatTextBox, "serchCatTextBox");
            this.serchCatTextBox.MaxLength = 32767;
            this.serchCatTextBox.Name = "serchCatTextBox";
            this.serchCatTextBox.PasswordChar = '\0';
            this.serchCatTextBox.PromptText = "Serch Categroy";
            this.serchCatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serchCatTextBox.SelectedText = "";
            this.serchCatTextBox.SelectionLength = 0;
            this.serchCatTextBox.SelectionStart = 0;
            this.serchCatTextBox.ShortcutsEnabled = true;
            this.serchCatTextBox.UseSelectable = true;
            this.serchCatTextBox.WaterMark = "Serch Categroy";
            this.serchCatTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serchCatTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.serchCatTextBox.TextChanged += new System.EventHandler(this.serchCatTextBox_TextChanged);
            // 
            // menuButton
            // 
            resources.ApplyResources(this.menuButton, "menuButton");
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.BackgroundImage = global::StackManagement.Properties.Resources.settings_png_image_51342;
            this.comTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.Name = "menuButton";
            this.menuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // lnk_Prev
            // 
            this.lnk_Prev.BackColor = System.Drawing.Color.Black;
            this.comTransition.SetDecoration(this.lnk_Prev, BunifuAnimatorNS.DecorationType.None);
            this.lnk_Prev.Image = global::StackManagement.Properties.Resources.back_left_arrow_botton_32;
            this.lnk_Prev.ImageSize = 32;
            resources.ApplyResources(this.lnk_Prev, "lnk_Prev");
            this.lnk_Prev.Name = "lnk_Prev";
            this.lnk_Prev.UseSelectable = true;
            this.lnk_Prev.Click += new System.EventHandler(this.lnk_Prev_Click);
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Controls.Add(this.metroLabel);
            this.comTransition.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            // 
            // comTransition
            // 
            this.comTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.comTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.comTransition.DefaultAnimation = animation1;
            // 
            // Main
            // 
            this.AcceptButton = this.saveButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lnk_Prev);
            this.Controls.Add(this.serchCatTextBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.categoryListView);
            this.comTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroContextMenu.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroTextBox catNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroListView categoryListView;
        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox idTextBox;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton resetButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchAndViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSellToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox serchCatTextBox;
        private MetroFramework.Controls.MetroLink lnk_Prev;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private BunifuAnimatorNS.BunifuTransition comTransition;
    }
}

