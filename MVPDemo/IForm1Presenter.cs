using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo
{
	public interface IForm1Presenter
	{
		void ShowPasswordTextBox(object sender, EventArgs e);
		void Initialize();
	}
}
