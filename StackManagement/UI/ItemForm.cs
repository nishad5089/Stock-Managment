using MetroFramework;
using MetroFramework.Forms;
using StackManagement.Manager;
using StackManagement.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StackManagement.UI
{
    public partial class ItemForm : MetroForm
    {
        public ItemForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
        }

        private ItemManager itemManager = new ItemManager();

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (categroyComboBox.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Categroy Not Selected", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (companyComboBox.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Company Not Selected", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (itemNameTextBox.Text == "")
                {
                    MetroMessageBox.Show(this, "Item name must not be na", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                Item item = new Item();
                int tryint;
                if (!int.TryParse(reorderTextBox.Text, out tryint))
                {
                    MetroMessageBox.Show(this, "Invalid Input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            if (Convert.ToInt32(reorderTextBox.Text)<0)
            {
                MetroMessageBox.Show(this, "Reorder lavel Can't be Negative", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

                item.catId = Convert.ToInt32(categroyComboBox.SelectedValue);
                item.compId = Convert.ToInt32(companyComboBox.SelectedValue);
                item.itemName = itemNameTextBox.Text.Trim();
                item.reoderLavel = Convert.ToInt32(reorderTextBox.Text);
                item.date = DateTime.Now;

                string msg = itemManager.SaveItem(item);
                MetroMessageBox.Show(this, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                itemNameTextBox.Clear();
                reorderTextBox.Clear();

                LoadCatAndCompany();
            
            
        }

        private void Item_Load(object sender, EventArgs e)
        {
            companyComboBox.Items.Clear();
            categroyComboBox.Items.Clear();
           
            metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            LoadCatAndCompany();
            metroStyleManager.Style = MetroColorStyle.Green;
            reorderTextBox.Text = "0";
        }

        private void LoadCatAndCompany()
        {
           
                Category category = new Category();
            category.catName = "--SELECT--";
            category.id = -1;
            List<Category> categories = new List<Category>();
            categories.Add(category);
            categories.AddRange(itemManager.GetAllCategory());

            categroyComboBox.DisplayMember = "catName";
            categroyComboBox.DataSource = categories;
            categroyComboBox.ValueMember = "id";

            Company company = new Company();
            company.name = "--SELECT--";
            company.id = -1;

            List<Company> companies = new List<Company>();
            companies.Add(company);
            companies.AddRange(itemManager.GetAllCompany());

            companyComboBox.DisplayMember = "name";
            companyComboBox.DataSource = companies;
            companyComboBox.ValueMember = "id";
        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main category = new Main();
            this.Hide();
            category.Show();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm company = new CompanyForm();
            this.Hide();
            company.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(menuButton, 0, menuButton.Height);
            menuButton.BackColor = Color.Black;
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInFrom stockInFrom = new StockInFrom();
            if (stockInFrom.Visible == false)
            {
                this.Hide();
                stockInTransition.ShowSync(stockInFrom);
            }
            
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();
            this.Hide();
            stockOutForm.Show();
        }

        private void SetupCloseing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void serchAndViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serch_View_From serchViewFrom = new Serch_View_From();
            this.Hide();
            serchViewFrom.Show();
        }

        private void lnk_Prev_Click(object sender, EventArgs e)
        {
            CompanyForm company = new CompanyForm();
            this.Hide();
            company.Show();
        }

        private void deshbordButton_Click(object sender, EventArgs e)
        {
            DeshbordForm deshbordForm = new DeshbordForm();
            this.Hide();
            deshbordForm.Show();
        }
    }
}