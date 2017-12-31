using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace StackManagement.UI
{
    public partial class DeshbordForm : MetroForm
    {
        private bool _logOut;

        public DeshbordForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
        }

        private void lnk_Logout_Click(object sender, EventArgs e)
        {
            _logOut = true;
            this.Close();
            Login_Form.Instance.Show();
        }

        private void DeshbordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_logOut)
                Application.Exit();
        }

        private void DeshbordForm_Load(object sender, EventArgs e)
        {
        }

        private void setupcat_Tile_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (main.Visible == false)
            {
                this.Hide();
                catTransition.ShowSync(main);
               // main.Show();
            }
            
        }

        private void setupCom_Tile_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            if (companyForm.Visible == false)
            {
                this.Hide();
                comTransition.ShowSync(companyForm);
            }
           
        }

        private void setup_Item_Tile_Click(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            if (item.Visible == false)
            {
                this.Hide();
                setupItemTransition.ShowSync(item);
            }
            
        }

        private void stockInTile_Click(object sender, EventArgs e)
        {
            StockInFrom stockIn = new StockInFrom();
            this.Hide();
            stockIn.Show();
        }

        private void viewSaleTile_Click(object sender, EventArgs e)
        {
            ViewSellForm viewSellForm = new ViewSellForm();
            this.Hide();
            viewSellForm.Show();
        }

        private void serch_View_Tile_Click(object sender, EventArgs e)
        {
            Serch_View_From serchViewFrom = new Serch_View_From();
            this.Hide();
            serchViewFrom.Show();
        }

        private void logOutTile_Click(object sender, EventArgs e)
        {
            _logOut = true;
            this.Close();
            Login_Form.Instance.Show();
        }

        private void stockOutTile_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            if (stockOutForm.Visible == false)
            {
                this.Hide();
               anotherTransition.ShowSync(stockOutForm);
            }
            
        }
    }
}