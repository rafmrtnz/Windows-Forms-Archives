using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_LogIn
{
	public partial class AuthenticationForm : Form
	{
		public AuthenticationForm()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var url = (NameValueCollection)ConfigurationManager.GetSection("appSettings");
			Process.Start(url["URL"]);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
				textBox1.UseSystemPasswordChar = false;
			else
				textBox1.UseSystemPasswordChar = true;
		}
	}
}
