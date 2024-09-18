using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem.Contracts
{
	public interface IStudentForm
	{
		void ErrorMEssage(string message);
		DialogResult ResultMessage(string message);
		void SetPresenter(IStudentFormPresenter studentFormPresenter);

		int Id { get; }
		string Firstname { get; }
		string Middlename { get; }
		string Lastname { get; }
		string HouseNumber { get; }
		string Street { get; }
		string Barangay { get; }
		string Province { get; }
		string City { get; }
		string Zip { get; }
		string Course { get; }
		string Major { get; }
		string SearchField { get; }
		string Email { get; }
		string Mobile { get; }
	}
}
