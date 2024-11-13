using Martinez_LogIn.Presenter.RegisterPresenter;
using Martinez_LogIn.View.Contracts;
using Martinez_LogIn.View.Forms.RegisterForm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_LogIn
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

			var serviceCollection = new ServiceCollection();

			var dependencies = new Dependecies();

			dependencies.Services(serviceCollection);

			var serviceProvider = serviceCollection.BuildServiceProvider();

			var registerForm = serviceProvider.GetRequiredService<IRegisterForm>();
			var registerPresenter = new RegisterPresenter(registerForm);

			Application.Run((Form)registerForm);
		}
	}
}
