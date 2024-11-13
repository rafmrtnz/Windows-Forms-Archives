using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPDemo
{
	public partial class Form1 : Form, IForm1
	{
		public Form1()
		{
			InitializeComponent();
		}

		public string Username { get => textBox1.Text; set => textBox1.Text = value; }
		public string Password { get => textBox2.Text; set => textBox2.Text = value; }

		public event EventHandler ClickShowPasswordTextBox;

		public void ShowPassword()
		{
			if (checkBox1.Checked)
				textBox2.UseSystemPasswordChar = false;
			else
				textBox2.UseSystemPasswordChar = true;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			ClickShowPasswordTextBox?.Invoke(this, EventArgs.Empty);
		}
	}
}
