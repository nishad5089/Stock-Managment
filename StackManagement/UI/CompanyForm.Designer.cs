namespace StackManagement.UI
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.companyListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.saveCompnayButton = new System.Windows.Forms.Button();
            this.companyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.CategoryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lnk_Prev = new MetroFramework.Controls.MetroLink();
            this.serchCompTextBox = new MetroFramework.Controls.MetroTextBox();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.deshbordButton = new MetroFramework.Controls.MetroButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label = new System.Windows.Forms.Label();
            this.setupItemTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.groupBox.SuspendLayout();
            this.metroContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyListView
            // 
            this.companyListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.companyListView.AllowDrop = true;
            this.companyListView.AllowSorting = true;
            this.companyListView.BackColor = System.Drawing.Color.White;
            this.companyListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.setupItemTransition.SetDecoration(this.companyListView, BunifuAnimatorNS.DecorationType.None);
            this.companyListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.companyListView.ForeColor = System.Drawing.Color.Black;
            this.companyListView.FullRowSelect = true;
            this.companyListView.GridLines = true;
            this.companyListView.HoverSelection = true;
            this.companyListView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.companyListView.Location = new System.Drawing.Point(140, 206);
            this.companyListView.Name = "companyListView";
            this.companyListView.OwnerDraw = true;
            this.companyListView.RightToLeftLayout = true;
            this.companyListView.ShowItemToolTips = true;
            this.companyListView.Size = new System.Drawing.Size(443, 372);
            this.companyListView.TabIndex = 8;
            this.companyListView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.companyListView.UseCompatibleStateImageBehavior = false;
            this.companyListView.UseCustomBackColor = true;
            this.companyListView.UseCustomForeColor = true;
            this.companyListView.UseSelectable = true;
            this.companyListView.UseStyleColors = true;
            this.companyListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL#";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 260;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.White;
            this.groupBox.Controls.Add(this.saveCompnayButton);
            this.groupBox.Controls.Add(this.companyNameTextBox);
            this.groupBox.Controls.Add(this.bunifuGradientPanel1);
            this.setupItemTransition.SetDecoration(this.groupBox, BunifuAnimatorNS.DecorationType.None);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(170, 63);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(383, 137);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Setup Company";
            // 
            // saveCompnayButton
            // 
            this.saveCompnayButton.BackColor = System.Drawing.Color.Maroon;
            this.setupItemTransition.SetDecoration(this.saveCompnayButton, BunifuAnimatorNS.DecorationType.None);
            this.saveCompnayButton.Enabled = false;
            this.saveCompnayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCompnayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.saveCompnayButton.ForeColor = System.Drawing.Color.White;
            this.saveCompnayButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveCompnayButton.Location = new System.Drawing.Point(246, 78);
            this.saveCompnayButton.Name = "saveCompnayButton";
            this.saveCompnayButton.Size = new System.Drawing.Size(84, 33);
            this.saveCompnayButton.TabIndex = 2;
            this.saveCompnayButton.Text = "Save";
            this.saveCompnayButton.UseVisualStyleBackColor = false;
            this.saveCompnayButton.Click += new System.EventHandler(this.saveCompnayButton_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.companyNameTextBox.CustomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyNameTextBox.CustomButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.companyNameTextBox.CustomButton.Image = null;
            this.companyNameTextBox.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.companyNameTextBox.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.companyNameTextBox.CustomButton.Name = "";
            this.companyNameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.companyNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.companyNameTextBox.CustomButton.TabIndex = 1;
            this.companyNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.companyNameTextBox.CustomButton.UseSelectable = true;
            this.companyNameTextBox.CustomButton.Visible = false;
            this.setupItemTransition.SetDecoration(this.companyNameTextBox, BunifuAnimatorNS.DecorationType.None);
            this.companyNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.companyNameTextBox.Lines = new string[0];
            this.companyNameTextBox.Location = new System.Drawing.Point(151, 28);
            this.companyNameTextBox.MaxLength = 32767;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.PasswordChar = '\0';
            this.companyNameTextBox.PromptText = "Company Name";
            this.companyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.companyNameTextBox.SelectedText = "";
            this.companyNameTextBox.SelectionLength = 0;
            this.companyNameTextBox.SelectionStart = 0;
            this.companyNameTextBox.ShortcutsEnabled = true;
            this.companyNameTextBox.Size = new System.Drawing.Size(179, 30);
            this.companyNameTextBox.TabIndex = 1;
            this.companyNameTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.companyNameTextBox.UseCustomBackColor = true;
            this.companyNameTextBox.UseSelectable = true;
            this.companyNameTextBox.WaterMark = "Company Name";
            this.companyNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.companyNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.companyNameTextBox.TextChanged += new System.EventHandler(this.company_Textchanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.setupItemTransition.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(-15, -15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroContextMenu
            // 
            this.setupItemTransition.SetDecoration(this.metroContextMenu, BunifuAnimatorNS.DecorationType.None);
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.viewItemToolStripMenuItem,
            this.sToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(179, 180);
            // 
            // CategoryStripMenuItem
            // 
            this.CategoryStripMenuItem.Name = "CategoryStripMenuItem";
            this.CategoryStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.CategoryStripMenuItem.Text = "Category Setup";
            this.CategoryStripMenuItem.Click += new System.EventHandler(this.CategoryStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // viewItemToolStripMenuItem
            // 
            this.viewItemToolStripMenuItem.Name = "viewItemToolStripMenuItem";
            this.viewItemToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewItemToolStripMenuItem.Text = "Search And View";
            this.viewItemToolStripMenuItem.Click += new System.EventHandler(this.viewItemToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sToolStripMenuItem.Text = "View Sale and Serch";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // lnk_Prev
            // 
            this.lnk_Prev.BackColor = System.Drawing.Color.Black;
            this.setupItemTransition.SetDecoration(this.lnk_Prev, BunifuAnimatorNS.DecorationType.None);
            this.lnk_Prev.Image = global::StackManagement.Properties.Resources.back_left_arrow_botton_32;
            this.lnk_Prev.ImageSize = 32;
            this.lnk_Prev.Location = new System.Drawing.Point(8, 7);
            this.lnk_Prev.Name = "lnk_Prev";
            this.lnk_Prev.Size = new System.Drawing.Size(44, 35);
            this.lnk_Prev.TabIndex = 14;
            this.lnk_Prev.UseSelectable = true;
            this.lnk_Prev.Click += new System.EventHandler(this.lnk_Prev_Click);
            // 
            // serchCompTextBox
            // 
            // 
            // 
            // 
            this.serchCompTextBox.CustomButton.Image = null;
            this.serchCompTextBox.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serchCompTextBox.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.serchCompTextBox.CustomButton.Name = "";
            this.serchCompTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.serchCompTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serchCompTextBox.CustomButton.TabIndex = 1;
            this.serchCompTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serchCompTextBox.CustomButton.UseSelectable = true;
            this.serchCompTextBox.CustomButton.Visible = false;
            this.setupItemTransition.SetDecoration(this.serchCompTextBox, BunifuAnimatorNS.DecorationType.None);
            this.serchCompTextBox.DisplayIcon = true;
            this.serchCompTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.serchCompTextBox.Icon = global::StackManagement.Properties.Resources.serchcat;
            this.serchCompTextBox.Lines = new string[0];
            this.serchCompTextBox.Location = new System.Drawing.Point(475, 26);
            this.serchCompTextBox.MaxLength = 32767;
            this.serchCompTextBox.Name = "serchCompTextBox";
            this.serchCompTextBox.PasswordChar = '\0';
            this.serchCompTextBox.PromptText = "Serch Company";
            this.serchCompTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serchCompTextBox.SelectedText = "";
            this.serchCompTextBox.SelectionLength = 0;
            this.serchCompTextBox.SelectionStart = 0;
            this.serchCompTextBox.ShortcutsEnabled = true;
            this.serchCompTextBox.Size = new System.Drawing.Size(166, 27);
            this.serchCompTextBox.TabIndex = 11;
            this.serchCompTextBox.UseSelectable = true;
            this.serchCompTextBox.WaterMark = "Serch Company";
            this.serchCompTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serchCompTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.serchCompTextBox.TextChanged += new System.EventHandler(this.serchCompTextBox_TextChanged);
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.BackgroundImage = global::StackManagement.Properties.Resources.settings_png_image_51342;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setupItemTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.menuButton.Location = new System.Drawing.Point(665, 41);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(54, 53);
            this.menuButton.Style = MetroFramework.MetroColorStyle.Black;
            this.menuButton.TabIndex = 9;
            this.menuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // deshbordButton
            // 
            this.setupItemTransition.SetDecoration(this.deshbordButton, BunifuAnimatorNS.DecorationType.None);
            this.deshbordButton.Location = new System.Drawing.Point(170, 21);
            this.deshbordButton.Name = "deshbordButton";
            this.deshbordButton.Size = new System.Drawing.Size(75, 32);
            this.deshbordButton.TabIndex = 39;
            this.deshbordButton.Text = "DeshBord";
            this.deshbordButton.UseSelectable = true;
            this.deshbordButton.Click += new System.EventHandler(this.deshbordButton_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label);
            this.setupItemTransition.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(383, 137);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.setupItemTransition.SetDecoration(this.label, BunifuAnimatorNS.DecorationType.None);
            this.label.Location = new System.Drawing.Point(92, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 18);
            this.label.TabIndex = 0;
            this.label.Text = "Name";
            // 
            // setupItemTransition
            // 
            this.setupItemTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.setupItemTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.setupItemTransition.DefaultAnimation = animation1;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 590);
            this.Controls.Add(this.deshbordButton);
            this.Controls.Add(this.lnk_Prev);
            this.Controls.Add(this.serchCompTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.companyListView);
            this.Controls.Add(this.groupBox);
            this.setupItemTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "CompanyForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Setup Company ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.From_closing);
            this.Load += new System.EventHandler(this.Company_Load);
            this.groupBox.ResumeLayout(false);
            this.metroContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Controls.MetroListView companyListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button saveCompnayButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CategoryStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox companyNameTextBox;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox serchCompTextBox;
        private MetroFramework.Controls.MetroLink lnk_Prev;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroButton deshbordButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label;
        private BunifuAnimatorNS.BunifuTransition setupItemTransition;
    }
}