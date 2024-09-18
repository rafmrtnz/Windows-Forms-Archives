using StudentInformationSystem.Contracts;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace StudentInformationSystem
{
	public partial class StudentForm : Form, IStudentForm
	{

		private IStudentFormPresenter _studentFormPresenter;
		private int _Id;

		public StudentForm()
		{
			InitializeComponent();
		}

		public int Id => _Id;
		public string Firstname => firstNameField.Text;

		public string Middlename => middleNameField.Text;

		public string Lastname => lastNameField.Text;

		public string HouseNumber => houseNumber.Text;

		public string Street => streetField.Text;

		public string Barangay => barangayField.Text;

		public string Province => provinceField.Text;

		public string City => cityField.Text;

		public string Zip => zipField.Text;

		public string Course => courseComboBox.Text;

		public string Major => majorComboBox.Text;

		public string SearchField => searchField.Text;

		public string Email => emailField.Text;

		public string Mobile => numberField.Text;

		private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				PopulateFieldWithRecord();
			}
			catch(Exception)
			{
				MessageBox.Show("Something went wrong while displaying the records.");
			}
		}

		private void PopulateFieldWithRecord()
		{
			_Id = Convert.ToInt32(dataTable.CurrentRow.Cells[0].Value.ToString());
			firstNameField.Text = dataTable.CurrentRow.Cells[1].Value.ToString();
			middleNameField.Text = dataTable.CurrentRow.Cells[2].Value.ToString();
			lastNameField.Text = dataTable.CurrentRow.Cells[3].Value.ToString();
			houseNumber.Text = dataTable.CurrentRow.Cells[4].Value.ToString();
			streetField.Text = dataTable.CurrentRow.Cells[5].Value.ToString();
			barangayField.Text = dataTable.CurrentRow.Cells[6].Value.ToString();
			provinceField.Text = dataTable.CurrentRow.Cells[7].Value.ToString();
			cityField.Text = dataTable.CurrentRow.Cells[8].Value.ToString();
			zipField.Text = dataTable.CurrentRow.Cells[9].Value.ToString();
			courseComboBox.Text = dataTable.CurrentRow.Cells[10].Value.ToString();
			majorComboBox.Text = dataTable.CurrentRow.Cells[11].Value.ToString();
			emailField.Text = dataTable.CurrentRow.Cells[13].Value.ToString();
			numberField.Text = dataTable.CurrentRow.Cells[12].Value.ToString();
		}

		public void ErrorMEssage(string message)
		{
			DialogResult result = MessageBox.Show(message);
			return;
		}

		public DialogResult ResultMessage(string message)
		{
			DialogResult result = MessageBox.Show(message, "Alert!", MessageBoxButtons.OKCancel);
			return result;
		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{
			dataTable.DataSource = _studentFormPresenter.FindByKey();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			bool isSuccess = _studentFormPresenter.CreateStudent();

			if (!isSuccess) return;

			DisplayTableData();
			ClearFields();
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			
			bool isSuccess = _studentFormPresenter.UpdateStudent();
			if (!isSuccess) return;
			DisplayTableData();
			ClearFields();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			bool isSuccess = _studentFormPresenter.DeleteStudent();
			if (!isSuccess) return;
			DisplayTableData();
			ClearFields();
		}

		public void SetPresenter(IStudentFormPresenter studentFormPresenter)
		{
			_studentFormPresenter = studentFormPresenter;
		}

		private void StudentForm_Load(object sender, EventArgs e)
		{

			ListOfCourses();
			ListOfMajors();
			DisplayTableData();
		}

		private void ListOfCourses()
		{
			var courseList = _studentFormPresenter.FetchAllCourseDisplay().ToList();
			courseComboBox.DataSource = courseList;
			courseComboBox.DisplayMember = "Program";
			courseComboBox.ValueMember = "Id";
		}

		private void ListOfMajors()
		{
			var majorList = _studentFormPresenter.FetchAllMajorDisplay().ToList();
			majorComboBox.DataSource = majorList;
			majorComboBox.ValueMember = "Id";
			majorComboBox.DisplayMember = "Program";
		}

		private void DisplayTableData()
		{
			dataTable.DataSource = _studentFormPresenter.FetchAllRecord();
		}

		private void ClearFields()
		{
			_Id = 0;
			firstNameField.Text = "";
			middleNameField.Text = "";
			lastNameField.Text = "";
			houseNumber.Text = "";
			streetField.Text = "";
			barangayField.Text = "";
			provinceField.Text = "";
			cityField.Text = "";
			zipField.Text = "";
			courseComboBox.Text = "";
			majorComboBox.Text = "";
			emailField.Text = "";
			numberField.Text = "";
		}
	}
}
