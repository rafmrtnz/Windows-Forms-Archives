using StudentInformationSystem.Contracts;
using StudentInformationSystem.DTO;
using StudentInformationSystem.Models;
using StudentInformationSystem.Models.Aggregates;
using System;
namespace StudentInformationSystem.Factory
{
	public class StudentFactory : IStudentFactory
	{
		private readonly IStringValidation _stringValidation;

        public StudentFactory(IStringValidation stringValidation)
        {
			_stringValidation = stringValidation;
        }

        public CreateStudentDto BuildStudent (CreateStudentDto data)
		{
			object[] student = PrepareObjectCreation(data);
			try
			{
				var builder = new StudentAggregate((Student)student[0], (Address)student[1],
					(Course)student[2], (Major)student[3], (EmailAddress)student[4],
					(PhoneNumber)student[5], _stringValidation);

				return builder.Create();
			}
			catch(Exception error)
			{
				throw error;
			}
		}

		public UpdateStudentDto BuildStudent(UpdateStudentDto data)
		{
			try
			{
				object[] student = PrepareObjectUpdate(data);

				var builder = new StudentAggregate((Student)student[0], (Address)student[1],
					(Course)student[2], (Major)student[3], (EmailAddress)student[4],
					(PhoneNumber)student[5], _stringValidation);

				return builder.Update();
			}
			catch (Exception error)
			{

				throw error;
			}
		}

		private object[] PrepareObjectCreation(CreateStudentDto data)
		{
			var student = new Student()
			{
				Firstname = data.Firstname,
				Middlename = data.Middlename,
				Lastname = data.Lastname
			};
			var address = new Address()
			{
				HouseNumber = data.HouseNumber,
				Street = data.Street,
				Barangay = data.Barangay,
				Province = data.Province,
				City = data.City,
				Zip = data.Zip
			};
			var course = new Course()
			{
				Program = data.Course
			};
			var major = new Major()
			{
				Program = data.Major
			};
			var email = new EmailAddress()
			{
				Email = data.Email
			};

			var phone = new PhoneNumber()
			{
				Phonenumber = data.MobileNumber
			};
			return new object[] { student, address, course, major, email, phone };
		}

		private object[] PrepareObjectUpdate(UpdateStudentDto data)
		{
			var student = new Student()
			{
				Id = data.Id,
				Firstname = data.Firstname,
				Middlename = data.Middlename,
				Lastname = data.Lastname
			};
			var address = new Address()
			{
				HouseNumber = data.HouseNumber,
				Street = data.Street,
				Barangay = data.Barangay,
				Province = data.Province,
				City = data.City,
				Zip = data.Zip
			};
			var course = new Course()
			{
				Program = data.Course
			};
			var major = new Major()
			{
				Program = data.Major
			};
			var email = new EmailAddress()
			{
				Email = data.Email
			};

			var phone = new PhoneNumber()
			{
				Phonenumber = data.MobileNumber
			};
			return new object[] { student, address, course, major, email, phone };
		}
	}
}
