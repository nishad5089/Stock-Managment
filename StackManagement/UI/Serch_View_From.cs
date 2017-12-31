using MetroFramework.Forms;
using StackManagement.Manager;
using StackManagement.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace StackManagement.UI
{
    public partial class Serch_View_From : MetroForm
    {
        public Serch_View_From()
        {
            InitializeComponent();
        }

        private Serch_View_Manager serchViewManager = new Serch_View_Manager();
        private CompanyManager companyManager = new CompanyManager();
        private CategoriManager categoryManager = new CategoriManager();

        private void Serch_View_From_Load(object sender, EventArgs e)
        {
            List<Serch_View> relatedItemList = serchViewManager.GetAllRelatedItem();
            PopulateList(relatedItemList);

            LoadCompanyCombobox();
            LoadCategoryCombobox();
        }

        private void LoadCompanyCombobox()
        {
            Company company = new Company();
            company.name = "--SELECT--";
            company.id = -1;
            List<Company> companies = new List<Company>();
            companies.Add(company);
            companies.AddRange(companyManager.CompanyList());

            companyComboBox.DataSource = companies;
            companyComboBox.ValueMember = "id";
            companyComboBox.DisplayMember = "name";
        }

        private void LoadCategoryCombobox()
        {
            Category company = new Category();
            company.catName = "--SELECT--";
            company.id = -1;
            List<Category> categories = new List<Category>();
            categories.Add(company);
            categories.AddRange(categoryManager.GetAllCategory());

            categoryComboBox.DataSource = categories;
            categoryComboBox.ValueMember = "id";
            categoryComboBox.DisplayMember = "catName";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(menuButton, 0, menuButton.Height);
            menuButton.BackColor = Color.LightBlue;
        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            this.Hide();
            companyForm.Show();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            this.Hide();
            itemForm.Show();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInFrom stockInFrom = new StockInFrom();
            this.Hide();
            stockInFrom.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();
            this.Hide();
            stockOutForm.Show();
        }

        private void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }

        private void serchButton_Click(object sender, EventArgs e)
        {
            using (var waitForm = new WaitPrograss(Save))
            {
                waitForm.ProcessName = "Serching...";
                waitForm.ShowDialog(this);
            }
            Serch_View serchView = new Serch_View();
            serchView.catId = Convert.ToInt32(categoryComboBox.SelectedValue);
            serchView.compId = Convert.ToInt32(companyComboBox.SelectedValue);
            List<Serch_View> serchViews;
            if (companyComboBox.SelectedIndex != 0 && categoryComboBox.SelectedIndex == 0)
            {
                serchViews = serchViewManager.GetWithCompany(serchView);
                PopulateList(serchViews);
            }
            else if (companyComboBox.SelectedIndex == 0 && categoryComboBox.SelectedIndex != 0)
            {
                serchViews = serchViewManager.GetWithCategory(serchView);
                if (serchViews.Count == 0)
                {
                    Serch_View catSerch = new Serch_View();
                    catSerch.catName = categoryComboBox.Text;
                    catSerch.itemName = "No Item Given";
                    catSerch.companyName = "No Company";
                    catSerch.aviableQuantity = 0;
                    catSerch.reorderLabel = 0;
                    serchViews.Add(catSerch);
                    PopulateList(serchViews);
                }
                else
                    PopulateList(serchViews);
            }
            else if (companyComboBox.SelectedIndex == 0 && categoryComboBox.SelectedIndex == 0)
            {
                serchViews = serchViewManager.GetAllRelatedItem();
                PopulateList(serchViews);
            }
            else if (companyComboBox.SelectedIndex != 0 && categoryComboBox.SelectedIndex != 0)
            {
                serchViews = serchViewManager.GeWithCatandCom(serchView);
                PopulateList(serchViews);
            }
        }

        private void PopulateList(List<Serch_View> serchViews)
        {
            int i = 1;
            serchListView.Items.Clear();
            foreach (var cmpSearch in serchViews)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = i++.ToString();
                listViewItem.SubItems.Add(cmpSearch.itemName);
                listViewItem.SubItems.Add(cmpSearch.companyName);
                listViewItem.SubItems.Add(cmpSearch.catName);
                listViewItem.SubItems.Add(cmpSearch.aviableQuantity.ToString());
                listViewItem.SubItems.Add(cmpSearch.reorderLabel.ToString());
                serchListView.Items.Add(listViewItem);
            }
        }

        private void viewSalesAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSellForm viewSellForm = new ViewSellForm();
            this.Hide();
            viewSellForm.Show();
        }

        private void Serch_View_From_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lnk_Prev_Click(object sender, EventArgs e)
        {
            StockOutForm stockOut = new StockOutForm();
            this.Hide();
            stockOut.Show();
        }

        private void deshbordButton_Click(object sender, EventArgs e)
        {
           
            DeshbordForm deshbordForm = new DeshbordForm();
            if (deshbordForm.Visible == false)
            {
                this.Hide();
                backtoDeshbordTransition.ShowSync(deshbordForm);

            }
            
        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}