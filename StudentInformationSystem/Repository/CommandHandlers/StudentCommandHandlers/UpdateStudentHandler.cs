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
	public class UpdateStudentHandler : ICommandHandler<UpdateStudentCommand>
	{
		private readonly RegistrationDataContext _dataContext;
        public UpdateStudentHandler(RegistrationDataContext dataContext)
        {
			_dataContext = dataContext;
        }
        public void Handle(UpdateStudentCommand command)
		{
			_dataContext.UpdateRecord
				(
				command.UpdateStudentDto.Id,
				command.UpdateStudentDto.Firstname,
				command.UpdateStudentDto.Middlename,
				command.UpdateStudentDto.Lastname,
				command.UpdateStudentDto.Email,
				command.UpdateStudentDto.MobileNumber,
				command.UpdateStudentDto.HouseNumber,
				command.UpdateStudentDto.Street,
				command.UpdateStudentDto.Barangay,
				command.UpdateStudentDto.Province,
				command.UpdateStudentDto.City,
				command.UpdateStudentDto.Zip,
				command.UpdateStudentDto.Course,
				command.UpdateStudentDto.Major
				);
		}
	}
}
