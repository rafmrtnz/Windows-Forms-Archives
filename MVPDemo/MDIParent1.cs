using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace MVPDemo
{
	public partial class MDIParent1 : Form
	{
		private int childFormNumber = 0;
		private readonly IServiceProvider _serviceProvider;

		public MDIParent1(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		//private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//	var form1 = _serviceProvider.GetRequiredService<IForm1>() as Form;

		//	form1.MdiParent = this;

		//	var presenter = _serviceProvider.GetRequiredService<IForm1Presenter>() as Form1Presenter;
		//	presenter.Initialize();

		//	Console.WriteLine("Form1 instance: " + form1.GetHashCode());
		//	Console.WriteLine("Presenter instance: " + presenter.GetHashCode());

		//	form1.Show();
		//}
		private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form1 = new Form1();
			//var presenter = _serviceProvider.GetRequiredService<IForm1Presenter>() as Form1Presenter;
			var presenter = new Form1Presenter(form1);
			form1.MdiParent = this;
			form1.Show();
		}
	}
}
