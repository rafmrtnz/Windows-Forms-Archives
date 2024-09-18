using StudentInformationSystem.DTO;
using System.Windows.Forms;

namespace StudentInformationSystem.Contracts.IFactory
{
	public interface IStudentRegistrationFactory
	{
		CreateStudentDto BuildStudentDto(string firstname, string middlename, string lastname,
			string housenumber, string street, string barangay,
			string province, string city, string zip,
		string course, string major, string email, string mobile);

		UpdateStudentDto BuildStudentDto(int id, string firstname, string middlename, string lastname,
			string housenumber, string street, string barangay,
			string province, string city, string zip,
			string course, string major, string email, string mobile);

		DeleteStudentDto BuildStudentDto(int id);
	}
}
