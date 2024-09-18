using StudentInformationSystem.DTO;
using StudentInformationSystem.Contracts;

namespace StudentInformationSystem.Repository.Command.StudentCommand
{
	public class DeleteStudentCommand : ICommand
	{
		public DeleteStudentDto DeleteStudent { get; }
		public DeleteStudentCommand(DeleteStudentDto removeStudent)
		{
			DeleteStudent = removeStudent;
		}
	}
}
