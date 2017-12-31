using MetroFramework.Forms;
using System.Windows.Forms;

namespace StackManagement.UI
{
    public partial class SpalshScreen : MetroForm
    {
        public SpalshScreen()
        {
            InitializeComponent();
        }

        private void spalsh_screen_closing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}