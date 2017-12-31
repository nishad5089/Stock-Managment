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
    public partial class StockOutForm : MetroForm
    {
        public StockOutForm()
        {
            InitializeComponent();
        }

        private StockManager stockManager = new StockManager();
        private CompanyManager companyManager = new CompanyManager();
        private StockOutManager stockOutManager = new StockOutManager();
        private static int i = 1;

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (companyComboBox.SelectedIndex == 0 || itemComboBox.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Invalid Selection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            StockOut stockOut = new StockOut();

            if (quentityTextBox.Text != "")
            {
                int trytoint;
                if (!int.TryParse(quentityTextBox.Text, out trytoint))
                {
                    MetroMessageBox.Show(this, "Invalid Input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToInt32(quentityTextBox.Text) < 0)
                {
                    MetroMessageBox.Show(this, "Quenity Must Be Positive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                stockOut.takenQuentity = Convert.ToInt32(quentityTextBox.Text);
                stockOut.companyId = Convert.ToInt32(companyComboBox.SelectedValue);
                stockOut.itemId = Convert.ToInt32(itemComboBox.SelectedValue);
                //i--;
                int av = Convert.ToInt32(avilableQuentiyTextBox.Text) - Convert.ToInt32(quentityTextBox.Text);
                ListViewItem item = new ListViewItem(i++.ToString());
                item.Name = "item1";
                item.SubItems.Add(itemComboBox.Text);
                item.SubItems.Add(companyComboBox.Text);
                item.SubItems.Add(stockOut.takenQuentity.ToString());
                item.SubItems.Add(stockOut.companyId.ToString());
                item.SubItems.Add(stockOut.itemId.ToString());
                item.SubItems.Add(av.ToString());
                string avaiableQuentity =
                    (Convert.ToInt32(avilableQuentiyTextBox.Text) - Convert.ToInt32(quentityTextBox.Text)).ToString();
                if (Convert.ToInt32(avaiableQuentity) < 0)
                {
                    MetroMessageBox.Show(this, "You have No Stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    avilableQuentiyTextBox.Text = avaiableQuentity;
                }

                if (!IsInCollection(item))
                {
                    stockOutListView.Items.Add(item);
                }
                else
                {
                    MetroMessageBox.Show(this, "Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    i--;
                }

                quentityTextBox.Clear();
                LoadCompanyCombobox();
            }
            else
            {
                MetroMessageBox.Show(this, "Quentity Should Not be Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update in list box and unique check in listview box
        private bool IsInCollection(ListViewItem lvi)
        {
            int count = stockOutListView.Items.Count;
            for (int j = 0; j < count; j++)
            {
                bool isFound = false;
                bool subItemEqualFlag = true;
                for (int i = 1; i < stockOutListView.Items[j].SubItems.Count - 4; i++)
                {
                    string sub1 = stockOutListView.Items[j].SubItems[1].Text; //fetch form listview
                    string sub2 = lvi.SubItems[1].Text;
                    string sub3 = stockOutListView.Items[j].SubItems[2].Text;
                    string sub4 = lvi.SubItems[2].Text;

                    if (sub1 != sub2 && sub3 == sub4)
                    {
                        subItemEqualFlag = false;
                    }
                    else if (sub3 != sub4)
                    {
                        subItemEqualFlag = false;
                    }
                    else
                    {
                        if (!isFound)
                        {
                            string stockCal = (Convert.ToInt32(lvi.SubItems[3].Text) +
                                               Convert.ToInt32(stockOutListView.Items[j].SubItems[3].Text)).ToString();
                            stockOutListView.Items[j].SubItems[3].Text = stockCal;
                            /*int av = Convert.ToInt32(avilableQuentiyTextBox.Text) - Convert.ToInt32(quentityTextBox.Text);*/
                            stockOutListView.Items[j].SubItems[6].Text = avilableQuentiyTextBox.Text;

                            isFound = true;
                        }
                    }
                }

                if (subItemEqualFlag)
                    return true;
            }
            return false;
        }

        private bool IsInListview(ListViewItem lvi)
        {
            int count = stockOutListView.Items.Count;
            for (int j = 0; j < count; j++)
            {
                bool isFound = false;
                bool subItemEqualFlag = true;
                for (int i = 1; i < stockOutListView.Items[j].SubItems.Count - 4; i++)
                {
                    string sub1 = stockOutListView.Items[j].SubItems[1].Text; //fetch form listview
                    string sub2 = lvi.SubItems[i].Text; //texbox

                    string sub3 = stockOutListView.Items[j].SubItems[2].Text;
                    string sub4 = lvi.SubItems[2].Text;
                    if (sub1 != sub2 && sub3 == sub4)
                    {
                        subItemEqualFlag = false;
                    }
                    else if (sub3 != sub4)
                    {
                        subItemEqualFlag = false;
                    }
                    else
                    {

                        if (!isFound)
                        {
                            string avaiableQuentity =
                                (Convert.ToInt32(avilableQuentiyTextBox.Text) - Convert.ToInt32(stockOutListView.Items[j].SubItems[3].Text))
                                .ToString();
                            avilableQuentiyTextBox.Text = avaiableQuentity;
                            isFound = true;
                        }
                    }
                }

                if (subItemEqualFlag)
                    return true;
            }
            return false;
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
                return;
            }
            if (Convert.ToInt32(quentityTextBox.Text) < 0)
            {
                MetroMessageBox.Show(this, "Quenity Must Be Positive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item getItem = itemComboBox.SelectedItem as Item;

            recorderTextBox.Text = getItem.reoderLavel.ToString();
            StockIn stokIn = new StockIn();

            int itemid;
            int.TryParse(itemComboBox.SelectedValue.ToString(), out itemid);

            StockIn newstock = stockManager.GetStockIn(itemid);
            if (newstock != null)
            {
                avilableQuentiyTextBox.Text = newstock.aviableQuentity.ToString();
                ListViewItem item = new ListViewItem();

                item.Name = "item2";
                item.SubItems.Add(itemComboBox.Text);
                item.SubItems.Add(companyComboBox.Text);
                if (IsInListview(item))
                {

                }
                if (Convert.ToInt32(avilableQuentiyTextBox.Text) < 0)
                {
                    avilableQuentiyTextBox.Text = 0.ToString();
                }
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
            quentityTextBox.Clear();
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            LoadCompanyCombobox();
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

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (stockOutListView.Items.Count == 0)
            {
                MetroMessageBox.Show(this, "No Item Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MetroMessageBox.Show(this, "Are You Sure", "Message", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                i = 1;
                StockOut stockOut = new StockOut();
                string msg = "";
                string mssage = "";
                foreach (ListViewItem item in stockOutListView.Items)
                {
                    stockOut.itemId = Convert.ToInt32(item.SubItems[5].Text);
                    stockOut.companyId = Convert.ToInt32(item.SubItems[4].Text);
                    stockOut.takenQuentity = Convert.ToInt32(item.SubItems[3].Text);
                    stockOut.aviableQuentity = Convert.ToInt32(item.SubItems[6].Text);
                    stockOut.insertDate = DateTime.Now;
                    stockOut.sell = "Yes";
                    if (stockOutManager.IsStockedOut(stockOut))
                    {
                        StockOut sigleStack = stockOutManager.GetTekenQuentity(stockOut);
                        stockOut.takenQuentity += sigleStack.takenQuentity;
                        msg = stockOutManager.UpdateTakenQuentity(stockOut);
                    }
                    else
                    {
                        msg = stockOutManager.SaveStock(stockOut);
                    }
                    mssage = stockOutManager.UpdateAviableQuentity(stockOut);
                    stockOutListView.Items.Clear();
                }

                MetroMessageBox.Show(this, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setupCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void setupCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            this.Hide();
            companyForm.Show();
        }

        private void setupItemToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(menuButton, 0, menuButton.Height);
            menuButton.BackColor = Color.White;
        }

        private void demageButton_Click(object sender, EventArgs e)
        {
            if (stockOutListView.Items.Count == 0)
            {
                MetroMessageBox.Show(this, "No Item Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MetroMessageBox.Show(this, "Are You Sure", "Message", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                i = 1;
                StockOut stockOut = new StockOut();
                string msg = "";

                foreach (ListViewItem item in stockOutListView.Items)
                {
                    stockOut.itemId = Convert.ToInt32(item.SubItems[5].Text);
                    stockOut.companyId = Convert.ToInt32(item.SubItems[4].Text);
                    stockOut.takenQuentity = Convert.ToInt32(item.SubItems[3].Text);
                    stockOut.aviableQuentity = Convert.ToInt32(item.SubItems[6].Text);
                    stockOut.insertDate = DateTime.Now;
                    stockOut.damaged = "Yes";
                    if (stockOutManager.IsDamageOut(stockOut))
                    {
                        StockOut sigleStack = stockOutManager.GetTekenQuentity(stockOut);
                        stockOut.takenQuentity += sigleStack.takenQuentity;
                        msg = stockOutManager.UpdateTakenQuentity(stockOut);
                    }
                    else
                    {
                        msg = stockOutManager.SaveStock(stockOut);
                    }
                    stockOutManager.UpdateAviableQuentity(stockOut);
                    stockOutListView.Items.Clear();
                }

                MetroMessageBox.Show(this, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            if (stockOutListView.Items.Count == 0)
            {
                MetroMessageBox.Show(this, "No Item Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MetroMessageBox.Show(this, "Are You Sure", "Message", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                i = 1;
                StockOut stockOut = new StockOut();
                string msg = "";

                foreach (ListViewItem item in stockOutListView.Items)
                {
                    stockOut.itemId = Convert.ToInt32(item.SubItems[5].Text);
                    stockOut.companyId = Convert.ToInt32(item.SubItems[4].Text);
                    stockOut.takenQuentity = Convert.ToInt32(item.SubItems[3].Text);
                    stockOut.aviableQuentity = Convert.ToInt32(item.SubItems[6].Text);
                    stockOut.insertDate = DateTime.Now;
                    stockOut.losed = "Yes";
                    if (stockOutManager.IsLostOut(stockOut))
                    {
                        StockOut sigleStack = stockOutManager.GetTekenQuentity(stockOut);
                        stockOut.takenQuentity += sigleStack.takenQuentity;
                        msg = stockOutManager.UpdateTakenQuentity(stockOut);
                    }
                    else
                    {
                        msg = stockOutManager.SaveStock(stockOut);
                    }
                    stockOutManager.UpdateAviableQuentity(stockOut);
                    stockOutListView.Items.Clear();
                }

                MetroMessageBox.Show(this, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void serchAndViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serch_View_From serchViewFrom = new Serch_View_From();
            this.Hide();
            serchViewFrom.Show();
        }

        private void sellViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSellForm viewSellForm = new ViewSellForm();
            this.Hide();
            viewSellForm.Show();
        }

        private void lnk_Prev_Click(object sender, EventArgs e)
        {
            StockInFrom stockInFrom = new StockInFrom();
            this.Hide();
            stockInFrom.Show();
        }

        private void deshbordButton_Click(object sender, EventArgs e)
        {
            DeshbordForm deshbordForm = new DeshbordForm();
            this.Hide();
            deshbordForm.Show();
        }
    }
}