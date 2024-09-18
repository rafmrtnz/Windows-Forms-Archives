using StudentInformationSystem.Models.Aggregates;
using StudentInformationSystem.Models;
using StudentInformationSystem.DTO;

namespace StudentInformationSystem.Factory
{
	public interface IStudentFactory
	{
		CreateStudentDto BuildStudent (CreateStudentDto data);
		UpdateStudentDto BuildStudent(UpdateStudentDto data);
	}
}