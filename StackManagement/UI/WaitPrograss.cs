using MetroFramework.Forms;
using System;
using System.Threading.Tasks;

namespace StackManagement.UI
{
    public partial class WaitPrograss : MetroForm
    {
        public Action Worker { get; set; }

        public WaitPrograss(Action worker)
        {
            InitializeComponent();
            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            this.ControlBox = false;
            Worker = worker;
        }

        public string ProcessName { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            this.Text = ProcessName;
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t =>
            {
                this.Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}