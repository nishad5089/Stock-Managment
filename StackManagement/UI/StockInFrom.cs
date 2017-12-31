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
    public partial class StockInFrom : MetroForm
    {
        public StockInFrom()
        {
            InitializeComponent();
        }

        private CompanyManager companyManager = new CompanyManager();

        private void StockIn_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            company.name = "--SELECT--";
            company.id = -1;
            List<Company> companies = new List<Company>();
            companies.Add(company);
            companies.AddRange(companyManager.CompanyList());
            //companies = companyManager.CompanyList();

            companyComboBox.DataSource = companies;
            companyComboBox.ValueMember = "id";
            companyComboBox.DisplayMember = "name";
        }

        private StockManager stockManager = new StockManager();

        private void saveButton_Click(object sender, EventArgs e)
        {
            StockIn stockIn = new StockIn();
            stockIn.companyId = Convert.ToInt32(companyComboBox.SelectedValue);
            stockIn.itemId = Convert.ToInt32(itemComboBox.SelectedValue);
            stockIn.reorderLavel = Convert.ToInt32(recorderTextBox.Text);
            int quentity;
            if (quentityTextBox.Text == "")
            {
                MetroMessageBox.Show(this, "Please Give Some Quentiy", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (int.TryParse(quentityTextBox.Text, out quentity))
            {
                if (Convert.ToInt32(quentityTextBox.Text) <= 0)
                {
                    MetroMessageBox.Show(this, "Quentity Can't be Negative Or Zero", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                stockIn.aviableQuentity = (Convert.ToInt32(avilableQuentiyTextBox.Text) + Convert.ToInt32(quentityTextBox.Text));
                avilableQuentiyTextBox.Text = stockIn.aviableQuentity.ToString();
                string exist = stockManager.ExistItem(stockIn);
                if (exist == "Exist")
                {
                    string mssg = stockManager.UpdateQuentity(stockIn);
                    MetroMessageBox.Show(this, mssg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    stockIn.date = DateTime.Now;
                    string msg = stockManager.SaveStock(stockIn);
                    MetroMessageBox.Show(this, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                quentityTextBox.Clear();
            }
            else
            {
                MetroMessageBox.Show(this, "Please Give Valid Quentity");
            }
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = itemComboBox.SelectedItem as Item;

            recorderTextBox.Text = item.reoderLavel.ToString();
            StockIn stokIn = new StockIn();

            int itemid;
            int.TryParse(itemComboBox.SelectedValue.ToString(), out itemid);

            StockIn newstock = stockManager.GetStockIn(itemid);
            if (newstock != null)
            {
                avilableQuentiyTextBox.Text = newstock.aviableQuentity.ToString();
            }
            else
            {
                avilableQuentiyTextBox.Text = stokIn.aviableQuentity.ToString();
            }
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyid;
            int.TryParse(companyComboBox.SelectedValue.ToString(), out companyid);
            Item item = new Item();
            item.itemName = "--SELECT--";
            item.id = -1;
            List<Item> items = new List<Item>();
            items.Add(item);
            items.AddRange(stockManager.GetAllItemwithCompId(companyid));
            itemComboBox.DataSource = items;
            itemComboBox.ValueMember = "id";
            itemComboBox.DisplayMember = "itemName";
        }

        private void CategoryStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            this.Hide();
            item.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(menuButton, 0, menuButton.Height);
            menuButton.BackColor = Color.LightBlue;
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            this.Hide();
            companyForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StockIn_FromClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();
            this.Hide();
            stockOutForm.Show();
        }

        private void serchAndViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serch_View_From serchViewFrom = new Serch_View_From();
            this.Hide();
            serchViewFrom.Show();
        }

        private void viewSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSellForm viewSellForm = new ViewSellForm();
            this.Hide();
            viewSellForm.Show();
        }

        private void quentityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quentityTextBox.Text == "")
            {
                return;
            }
            int trytoint;
            if (!int.TryParse(quentityTextBox.Text, out trytoint))
            {
                
                MetroMessageBox.Show(this, "Invalid Input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quentityTextBox.Clear();
                return;
            }
            if (Convert.ToInt32(quentityTextBox.Text) < 0)
            {
                MetroMessageBox.Show(this, "Quenity Must Be Positive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lnk_Prev_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            this.Hide();
            itemForm.Show();
        }

        private void deshbordButton_Click(object sender, EventArgs e)
        {
            DeshbordForm deshbordForm = new DeshbordForm();
            this.Hide();
            deshbordForm.Show();
        }
    }
}