using FacialRecognitionProject.Contracts.Profiling;
using FacialRecognitionProject.Presenter.Profiling;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();

			var projectConfig = new Configuration();
			projectConfig.WinFormConfiguration(services);

			var serviceProvider = services.BuildServiceProvider();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			var userProfilingForm = serviceProvider.GetRequiredService<IProfilingForm>();
			new ProfilingPresenter(userProfilingForm);

			projectConfig.ServiceProviders(serviceProvider);
			
			Application.Run((Form) userProfilingForm);
		}
	}
}
