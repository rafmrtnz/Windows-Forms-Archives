using FacialRecognition.Application;
using FacialRecognition.Infrastructure;
using FacialRecognitionProject.Contracts.Profiling;
using FacialRecognitionProject.Presenter.Profiling;
using Microsoft.Extensions.DependencyInjection;

namespace FacialRecognitionProject
{
	public class Configuration
	{
		public IServiceCollection WinFormConfiguration(IServiceCollection services)
		{
			services.AddApplication().AddInfrastructure();

			services.AddTransient<IProfilingForm, ProfilingForm>();
			services.AddTransient<IProfilingPresenter, ProfilingPresenter>();
			//services.AddTransient<ProfilingPresenter>();

			return services;
		}

		public void ServiceProviders(ServiceProvider serviceProvider)
		{
			serviceProvider.GetRequiredService<IProfilingPresenter>();
		}
	}
}
