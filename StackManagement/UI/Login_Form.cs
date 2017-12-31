using MetroFramework;
using MetroFramework.Forms;
using StackManagement.Manager;
using StackManagement.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace StackManagement.UI
{
    public partial class Login_Form : MetroForm
    {
        private static Login_Form _instance;

        public static Login_Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login_Form();
                return _instance;
            }
        }

        public Login_Form()
        {
            Thread t = new Thread(new ThreadStart(Loding));
            t.Start();
            InitializeComponent();
            for (int i = 0; i < 800; i++)
                Thread.Sleep(10);
            t.Abort();//for complete

            usernameTextBox.Focus();
        }

        private void Loding()
        {
            SpalshScreen spalshScreen = new SpalshScreen();
            Application.Run(spalshScreen);
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MetroMessageBox.Show(this, "Pease enter your user name", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                usernameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MetroMessageBox.Show(this, "Pease enter your Password", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                usernameTextBox.Focus();
                return;
            }
            LoginManager loginManager = new LoginManager();
            Login login = new Login();
            login.userName = usernameTextBox.Text;
            login.password = passwordTextBox.Text;
            if (loginManager.IsExistUser(login))
            {
                using (var waitForm = new WaitPrograss(Save))
                {
                    waitForm.ProcessName = "Processing...";
                    waitForm.ShowDialog(this);
                }
                DeshbordForm deshbord = new DeshbordForm();
                if (deshbord.Visible == false)
                {
                    this.Hide();
                    deshbordTransition.ShowSync(deshbord);
                }
               
            }
            else
            {
                MetroMessageBox.Show(this, "Username and Password not match", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}