using StudentInformationSystem.Contracts;
using StudentInformationSystem.DTO;

namespace StudentInformationSystem.Repository.Command.StudentCommand
{
	public class UpdateStudentCommand : ICommand
	{
		public UpdateStudentDto UpdateStudentDto { get; }
		public UpdateStudentCommand(UpdateStudentDto updateStudent)
		{
			UpdateStudentDto = updateStudent;
		}
	}
}
