using StudentInformationSystem.Contracts;
using StudentInformationSystem.Data;
using StudentInformationSystem.Repository.Command.StudentCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Repository.CommandHandlers.StudentCommandHandlers
{
	public class DeleteStudentHandler : ICommandHandler<DeleteStudentCommand>
	{
		private readonly RegistrationDataContext _dataContext;
        public DeleteStudentHandler(RegistrationDataContext dataContext)
        {
			_dataContext = dataContext;
        }
        public void Handle(DeleteStudentCommand command)
		{
			_dataContext.RemoveRecord(command.DeleteStudent.StudentId);
		}
	}
}
