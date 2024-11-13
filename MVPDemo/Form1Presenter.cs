using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo
{
	public class Form1Presenter : IForm1Presenter
	{
		private readonly IForm1 _view;
		public Form1Presenter(IForm1 view)
        {
			_view = view;
			_view.ClickShowPasswordTextBox += ShowPasswordTextBox;
		}

		public void Initialize()
		{
			
		}

		public void ShowPasswordTextBox(object sender, EventArgs e)
		{
			_view.ShowPassword();
		}
	}
}
