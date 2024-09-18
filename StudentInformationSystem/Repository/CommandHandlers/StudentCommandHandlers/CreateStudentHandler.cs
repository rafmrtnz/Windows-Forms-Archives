using StudentInformationSystem.Contracts;
using StudentInformationSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Repository.CommandHandlers.StudentCommandHandlers
{
	public class CreateStudentHandler : ICommandHandler<CreateStudentCommand>
	{
		private readonly RegistrationDataContext _dataContext;
        public CreateStudentHandler(RegistrationDataContext dataContext)
        {
			_dataContext = dataContext;
        }
        public void Handle(CreateStudentCommand command)
		{
			bool isEmailExist = CheckEmail(command.CreateStudentDto.Email);

			if (isEmailExist)
				throw new Exception("Email already exist.");

			bool isMobileExist = CheckMobile(command.CreateStudentDto.MobileNumber);
			if (isMobileExist)
				throw new Exception("Mobile number already exist");

			_dataContext.SaveRecord(
				command.CreateStudentDto.Firstname,
				command.CreateStudentDto.Middlename,
				command.CreateStudentDto.Lastname,
				command.CreateStudentDto.Email,
				command.CreateStudentDto.MobileNumber,
				command.CreateStudentDto.HouseNumber,
				command.CreateStudentDto.Street,
				command.CreateStudentDto.Barangay,
				command.CreateStudentDto.Province,
				command.CreateStudentDto.City,
				command.CreateStudentDto.Zip,
				command.CreateStudentDto.Course,
				command.CreateStudentDto.Major
				);
		}

		private bool CheckEmail(string email)
		{
			var result = _dataContext.CheckEmailExist(email).AsEnumerable().ToList();
			return result.Count < 1 ? false : true;
		}

		private bool CheckMobile(string phone)
		{
			var result = _dataContext.CheckMobileNumberExist(phone).AsEnumerable().ToList();
			return result.Count < 1 ? false : true;
		}
	}
}
