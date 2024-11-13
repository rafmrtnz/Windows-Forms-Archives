using Martinez_LogIn.View.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_LogIn.Presenter.RegisterPresenter
{
	public class RegisterPresenter
	{
		private readonly IRegisterForm _view;

		public RegisterPresenter (IRegisterForm view)
        {
            _view = view;
			_view.ShowPasswordCheckedChanged += OnShowPasswordCheckEvent;
        }

		private void OnShowPasswordCheckEvent(object sender, EventArgs e) => _view.SetPasswordVisibility(_view.ShowPasswordChecked);
    }
}
