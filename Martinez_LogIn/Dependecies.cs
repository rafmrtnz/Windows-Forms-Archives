using Martinez_LogIn.View.Contracts;
using Martinez_LogIn.View.Forms.RegisterForm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_LogIn
{
	public class Dependecies
	{
		public void Services(IServiceCollection services)
		{
			services.AddTransient<IRegisterForm, RegisterForm>();
			services.AddTransient<RegisterForm>();
		}
	}
}
