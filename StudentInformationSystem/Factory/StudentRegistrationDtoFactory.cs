using StudentInformationSystem.Contracts.IFactory;
using StudentInformationSystem.DTO;


namespace StudentInformationSystem.Factory
{
	public class StudentRegistrationDtoFactory : IStudentRegistrationFactory
	{
		public CreateStudentDto BuildStudentDto(string firstname, string middlename, string lastname,
			string housenumber, string street, string barangay,
			string province, string city, string zip,
			string course, string major, string email, string mobile) 
			
			=> new CreateStudentDto
			(
				firstname, middlename, lastname,
				housenumber, street, barangay,
				province, city, zip,
				course, major, email, mobile
			);

		public UpdateStudentDto BuildStudentDto(int id, string firstname, string middlename, string lastname,
			string housenumber, string street, string barangay,
			string province, string city, string zip,
			string course, string major, string email, string mobile) => new UpdateStudentDto
		(
			id, firstname, middlename,
			lastname, housenumber, street,
			barangay, province, city,
			zip, course, major, email, mobile
		);

		public DeleteStudentDto BuildStudentDto(int id) => new DeleteStudentDto(id);
	}
}
