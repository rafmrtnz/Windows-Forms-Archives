using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPDemo
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var service = new ServiceCollection();

			service.AddTransient<IForm1, Form1>();
			service.AddTransient<IForm1Presenter, Form1Presenter>();
			service.AddSingleton<MDIParent1>();

			var serviceProvider = service.BuildServiceProvider();

			var mdi = serviceProvider.GetService<MDIParent1>();
			var form1 = serviceProvider.GetService<IForm1>() as Form;
			//serviceProvider.GetService<IForm1Presenter>();
			Application.Run(mdi);
		}
	}
}
