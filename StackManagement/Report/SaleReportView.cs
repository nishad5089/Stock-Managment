using MetroFramework.Forms;
using StackManagement.Model;
using System;
using System.Collections.Generic;

namespace StackManagement.Report
{
    public partial class SaleReportView : MetroForm
    {
        public string Fromdate;
        public string Todate;
        private List<SaleView> _list;

        public SaleReportView(string fdate, string todate, List<SaleView> _list)
        {
            InitializeComponent();

            Fromdate = fdate;
            Todate = todate;

            this._list = _list;
        }

        private int i = 1;

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            saledReport.SetDataSource(_list);
            saledReport.SetParameterValue("Pfdate", Fromdate);
            saledReport.SetParameterValue("Ptodate", Todate);
            if (_list != null)
            {
                saledReport.SetParameterValue("Ptotal", _list.Count);
            }
            else
            {
                saledReport.SetParameterValue("Ptotal", "0");
            }

            crystalReportViewer1.ReportSource = saledReport;
        }
    }
}