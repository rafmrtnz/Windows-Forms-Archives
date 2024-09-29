using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleErrorThrowing
{
	public partial class Form1 : Form
	{
		private int _Id = 0;
		private MartinezDataContext _context = new MartinezDataContext();

		public Form1()
		{
			InitializeComponent();
		}

		private bool EmailValidity()
		{
			return email.Text.Contains("@") ? true : false;
		}

		private bool AgeValidity()
		{
			return int.TryParse(age.Text, out int userAge) ? true : false;
		}

		private void save_Click(object sender, EventArgs e)
		{
			try
			{
				if (!EmailValidity())
				{
					MessageBox.Show("Invalid Email");
					return;
				}

				var result = _context.SaveRecord
					(lastName.Text, firstName.Text, Convert.ToInt32(age.Text),
					email.Text, username.Text
					, password.Text).ToString();

				if(result != "0")
				{
					MessageBox.Show("Unable to save record. Please try again.");
					return;
				}

				GetAllRecord();
			}
			catch (SqlException sqlError)
			{
				MessageBox.Show($"Code \"{sqlError.ErrorCode}\": Something went wrong. Please try again.");
				return;
			}
		}

		private void update_Click(object sender, EventArgs e)
		{
			try
			{
				if (!EmailValidity())
				{
					MessageBox.Show("Invalid Email");
					return;
				}

				var result = _context.UpdateRecord(_Id,
					lastName.Text, firstName.Text, Convert.ToInt32(age.Text),
					email.Text, username.Text
					, password.Text).ToString();

				if (result != "0")
				{
					MessageBox.Show("Unable to save record. Please try again.");
					return;
				}

				GetAllRecord();
			}
			catch (Exception)
			{
				MessageBox.Show("Something went wrong. Please try again.");
				return;
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			try
			{
				var result = _context.RemoveRecord(_Id).ToString();
				if (result != "0")
				{
					MessageBox.Show("Unable to save record. Please try again.");
					return;
				}
				_Id = 0; // reset Id value.
				GetAllRecord();
			}
			catch (Exception)
			{
				MessageBox.Show("Something went wrong. Please try again.");
				return;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetAllRecord();
		}

		private void GetAllRecord()
		{
			dataGridView1.DataSource = _context.FetchAllRecord();

		}

		private void search_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _context.FindRecord(search.Text);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			firstName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			lastName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			age.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			username.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			password.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
		}
	}
}
