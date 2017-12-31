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
    public partial class Main : MetroForm
    {
        private string isUpdte = "";

        public Main()
        {
            InitializeComponent();
            
            this.StyleManager = metroStyleManager;
        }

        private CategoriManager categoryManager = new CategoriManager();

        private void saveButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            saveButton.ForeColor = Color.White;
            if (catNameTextBox.Text == "")
            {
                MetroMessageBox.Show(this, "Please enter category name");
            }
            else
            {
                if (idTextBox.Text != "")
                {
                    category.id = Convert.ToInt32(idTextBox.Text);
                }
                int isInt;
                if (int.TryParse(catNameTextBox.Text, out isInt))
                {
                    MetroMessageBox.Show(this, "Category Can't Be Numarical Value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                category.catName = catNameTextBox.Text.Trim();
                category.date = DateTime.Now;
                string msg;
                if (category.id != 0)
                {
                    if (category.catName == isUpdte)
                    {
                        MetroMessageBox.Show(this, "Nothing To Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        category.updateDate = DateTime.Now;
                        msg = categoryManager.UpdateCategory(category);

                        MetroMessageBox.Show(this, msg);
                        catNameTextBox.Clear();
                        idTextBox.Clear();
                    }
                }
                else
                {
                    msg = categoryManager.SaveCategory(category);
                    MetroMessageBox.Show(this, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    catNameTextBox.Clear();
                    idTextBox.Clear();
                }

                categoryListView.Items.Clear();
                PopupList();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            PopupList();
            /*metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;*/
            metroStyleManager.Style = MetroColorStyle.Green;
        }

        private void PopupList()
        {
            int i = 1;
            List<Category> categories = categoryManager.CategoryList();
            categoryListView.Items.Clear();
            foreach (var category in categories)
            {
                ListViewItem listView = new ListViewItem(i++.ToString());

                listView.SubItems.Add(category.catName);
                listView.SubItems.Add(category.id.ToString());
                categoryListView.Items.Add(listView);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(menuButton, 0, menuButton.Height);
        }

        private void Listview_DoubleClick(object sender, EventArgs e)
        {
            catNameTextBox.Text = categoryListView.SelectedItems[0].SubItems[1].Text;
            idTextBox.Text = categoryListView.SelectedItems[0].SubItems[2].Text;
            isUpdte = catNameTextBox.Text;
            saveButton.Text = "Edit";
            serchCatTextBox.Clear();
           // PopupList();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            catNameTextBox.Clear();
            saveButton.Text = "Save";
        }

        private void catNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (catNameTextBox.Text == "")
            {
                saveButton.Enabled = false;
                resetButton.Enabled = false;
            }
            else
            {
                saveButton.Enabled = true;
                resetButton.Enabled = true;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void companyStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            if (companyForm.Visible ==false)
            {
                this.Hide();
                comTransition.ShowSync(companyForm);
            }
           
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

        private void serchCatTextBox_TextChanged(object sender, EventArgs e)
        {
            
            List<Category> categories =  categoryManager.SearchCat(serchCatTextBox.Text);
            int i = 1;
            categoryListView.Items.Clear();
            foreach (var category in categories)
            {
                ListViewItem listView = new ListViewItem(i++.ToString());

                listView.SubItems.Add(category.catName);
                listView.SubItems.Add(category.id.ToString());
                categoryListView.Items.Add(listView);
            }
        }

        
        private void lnk_Prev_Click(object sender, EventArgs e)
        {
            DeshbordForm deshbordForm = new DeshbordForm();
            this.Hide();
            deshbordForm.Show();
        }
    }
}