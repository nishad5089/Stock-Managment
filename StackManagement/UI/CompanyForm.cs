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
    public partial class CompanyForm : MetroForm
    {
        private CompanyManager companyManager = new CompanyManager();

        public CompanyForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(menuButton, 0, menuButton.Height);
            menuButton.BackColor = Color.LightBlue;
        }

        private void saveCompnayButton_Click(object sender, EventArgs e)
        {
            if (companyNameTextBox.Text != "")
            {
                int isInt;
                if (int.TryParse(companyNameTextBox.Text, out isInt))
                {
                    MetroMessageBox.Show(this, "Company Can't Be Numarical Value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Company company = new Company();
                company.name = companyNameTextBox.Text.Trim();
                company.date = DateTime.Now;
                string msg = companyManager.SaveCompany(company);
                MetroMessageBox.Show(this, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulateCompany();

                companyNameTextBox.Clear();
            }
            else
            {
                MetroMessageBox.Show(this, "Company Name must not be empty", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Blue;
            PopulateCompany();
        }

        private void PopulateCompany()
        {
            List<Company> companies = companyManager.CompanyList();
            int i = 1;
            companyListView.Items.Clear();
            foreach (var company in companies)
            {
                ListViewItem item = new ListViewItem(i++.ToString());

                item.SubItems.Add(company.name);
                companyListView.Items.Add(item);
            }
        }

        private void CategoryStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void company_Textchanged(object sender, EventArgs e)
        {
            if (companyNameTextBox.Text == "")
            {
                
                saveCompnayButton.Enabled = false;
            }
            else
            {
                saveCompnayButton.Enabled = true;
            }
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            if (itemForm.Visible == false)
            {
                this.Hide();
               setupItemTransition.ShowSync(itemForm);
            }
            
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInFrom stockInFrom = new StockInFrom();
            this.Hide();
            stockInFrom.Show();
        }

        private void From_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();
            this.Hide();
            stockOutForm.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSellForm viewSellForm = new ViewSellForm();
            this.Hide();
            viewSellForm.Show();
        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serch_View_From serchViewFrom = new Serch_View_From();
            this.Hide();
            serchViewFrom.Show();
        }

        private void serchCompTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Company> companies = companyManager.SearchCompanyList(serchCompTextBox.Text);
            int i = 1;
            companyListView.Items.Clear();
            foreach (var company in companies)
            {
                ListViewItem item = new ListViewItem(i++.ToString());

                item.SubItems.Add(company.name);
                companyListView.Items.Add(item);
            }
        }

        private void lnk_Prev_Click(object sender, EventArgs e)
        {
            Main category = new Main();
            this.Hide();
            category.Show();
        }

        private void deshbordButton_Click(object sender, EventArgs e)
        {
            DeshbordForm deshbordForm = new DeshbordForm();
            this.Hide();
            deshbordForm.Show();
        }
    }
}