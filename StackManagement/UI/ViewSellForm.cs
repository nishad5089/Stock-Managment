using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using StackManagement.Gateway;
using StackManagement.Manager;
using StackManagement.Model;
using StackManagement.Report;

namespace StackManagement.UI
{
    public partial class ViewSellForm : MetroForm
    {
        public ViewSellForm()
        {
            InitializeComponent();
        }
        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }

        private List<SaleView> saledItem;
        SaleManager saleManager = new SaleManager();
        private void serchSaledButton_Click(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromDateTime.Text).Date;
            DateTime toDate = Convert.ToDateTime(toDateTime.Text).Date;
            TimeSpan difference = toDate.Date-fromDate.Date;

            if (difference.Days < 0)
            {
                MetroMessageBox.Show(this, "From Date must be less then To Date", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                saledListView.Items.Clear();
                return;
            }
            using (var waitForm = new WaitPrograss(Save))
            {
                waitForm.ProcessName = "Serching...";
                waitForm.ShowDialog(this);
                
            }
            saledListView.Items.Clear();
            saledItem = saleManager.GetAllSaledItem(fromDateTime.Text,toDateTime.Text);
            int i = 1;
            foreach (var saleView in saledItem)
            {
                ListViewItem listView = new ListViewItem(i++.ToString());
                listView.SubItems.Add(saleView.itemName);
                listView.SubItems.Add(saleView.takenQuentity);
                saledListView.Items.Add(listView);
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            using (SaleReportView f = new SaleReportView(fromDateTime.Text,toDateTime.Text,saledItem))
            {
                f.ShowDialog();
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(menuButton, 0, menuButton.Height);
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
            StockInFrom stockIn = new StockInFrom();
            this.Hide();
            stockIn.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutForm stockOut = new StockOutForm();
            this.Hide();
            stockOut.Show();
        }

        private void serchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serch_View_From serchViewFrom = new Serch_View_From();
            this.Hide();
            serchViewFrom.Show();
        }

        private void ViewSellForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lnk_Prev_Click(object sender, EventArgs e)
        {
           Serch_View_From serchViewFrom = new Serch_View_From();
            this.Hide();
            serchViewFrom.Show();
        }

        private void deshbordButton_Click(object sender, EventArgs e)
        {
            DeshbordForm deshbordForm = new DeshbordForm();
            this.Hide();
            deshbordForm.Show();
        }
    }
}
