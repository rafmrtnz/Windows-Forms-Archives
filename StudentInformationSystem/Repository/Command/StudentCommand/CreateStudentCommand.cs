using StudentInformationSystem.Contracts;
using StudentInformationSystem.DTO;
using StudentInformationSystem.Models.Aggregates;

namespace StudentInformationSystem.Repository
{
	public class CreateStudentCommand : ICommand
	{
		public CreateStudentDto CreateStudentDto { get; }
		public CreateStudentCommand(CreateStudentDto createStudentDto)
		{
			CreateStudentDto = createStudentDto;
		}
	}
}
