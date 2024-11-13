using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_RDLCDemo
{
	public partial class Form1 : Form
	{
		private ReportDataContext _context = new ReportDataContext();
		
		public Form1()
		{
			InitializeComponent();
		}

		private void GetAllReports()
		{
			var reports = from report in _context.GetEmployeeDetails() select report;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetAllReports();

			var dataTable = new DataTable();

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.ReportPath = @"D:\Code-Space\VisualStudio\WindowsForms\Martinez_RDLCDemo\EmployeeDetailReport.rdlc";
			
			if(_context.GetEmployeeDetails() == null)
			{
				MessageBox.Show("No data found");
				return;
			}
			
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _context.GetEmployeeDetails().ToList()));

			this.reportViewer1.RefreshReport();
		}

	}
}
