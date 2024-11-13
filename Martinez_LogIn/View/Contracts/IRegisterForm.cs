using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_LogIn.View.Contracts
{
	public interface IRegisterForm
	{
		string Firstname { get;}
		string Lastname { get;}
		string Email { get;}
		string Password { get;}
		string ComfirmPassword { get;}
		bool ShowPasswordChecked { get; }
		void SetPasswordVisibility(bool isChecked);
		event EventHandler ShowPasswordCheckedChanged;
		void SetShowPasswordChecked(bool isVisible);
	}
}
