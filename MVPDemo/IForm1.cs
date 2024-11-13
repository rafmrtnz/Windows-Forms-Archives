using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo
{
	public interface IForm1
	{
		event EventHandler ClickShowPasswordTextBox;
		string Username { get; set; }
		string Password { get; set; }
		void ShowPassword();
	}
}
