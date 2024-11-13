using Emgu.CV;
using FacialRecognitionProject.Contracts.Profiling;
using System;
using System.Text.RegularExpressions;

namespace FacialRecognitionProject.Presenter.Profiling
{
	public class ProfilingPresenter : IProfilingPresenter
	{
		private readonly IProfilingForm _view;

		


		public ProfilingPresenter(IProfilingForm view)
        {
			_view = view;
			_view.ClickSaveUserProfile += Save;
        }

		public void Save(object sender, EventArgs e)
		{
			_view.ShowMessage("Hello There!");
		}

		private void Timer(object sender, EventArgs e)
		{
			_view.TimerStart();
		}
	}
}
