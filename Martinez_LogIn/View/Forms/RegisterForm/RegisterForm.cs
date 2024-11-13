using Martinez_LogIn.View.Contracts;
using System;
using System.Windows.Forms;

namespace Martinez_LogIn.View.Forms.RegisterForm
{
	public partial class RegisterForm : Form, IRegisterForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		public string Firstname { get => firstNameField.Text; }
		public string Lastname { get => lastNameField.Text;}
		public string Email { get => emailField.Text;}
		public string Password { get => passwordField.Text;}
		public string ComfirmPassword { get => reconfirmPasswordField.Text;}

		public bool ShowPasswordChecked => showPassword.Checked;

		public event EventHandler ShowPasswordCheckedChanged;

		public void SetPasswordVisibility(bool isChecked)
		{
			passwordField.UseSystemPasswordChar = !isChecked;
			reconfirmPasswordField.UseSystemPasswordChar = !isChecked;
		}

		public void SetShowPasswordChecked(bool isVisible)
		{
			showPassword.Checked = isVisible;
		}

		private void showPassword_CheckedChanged(object sender, EventArgs e)
		{
			ShowPasswordCheckedChanged?.Invoke(this, EventArgs.Empty);
		}
	}
}
