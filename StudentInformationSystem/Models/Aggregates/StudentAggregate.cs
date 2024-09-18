using StudentInformationSystem.Contracts;
using StudentInformationSystem.Contracts.IModel;
using StudentInformationSystem.DTO;
using System;
using System.Collections.Generic;

namespace StudentInformationSystem.Models.Aggregates
{
	public class StudentAggregate : IModel
	{
		private readonly IStringValidation _stringValidation;

		public Student Student { get; private set; }
		public Address Address { get; private set; }
		public Course Course { get; private set; }
		public Major Major { get; private set; }
		public EmailAddress EmailAddress { get; private set; }
		public PhoneNumber PhoneNumber { get; private set; }

		public StudentAggregate
			(Student student, Address address, Course course,
			Major major, EmailAddress email, PhoneNumber phonenumber,
			IStringValidation stringValidation)
		{
			Student = student;
			Address = address;
			Course = course;
			Major = major;
			EmailAddress = email;
			PhoneNumber = phonenumber;
			_stringValidation = stringValidation;
		}

		private bool CheckNullability()
		{
			var isValid = new List<string>()
			{
				Student.Firstname,
				Student.Lastname,
				EmailAddress.Email,
				PhoneNumber.Phonenumber,
				Address.HouseNumber,
				Address.Street,
				Address.Barangay,
				Address.Province,
				Address.City,
				Address.Zip,
				Course.Program
			};
			return _stringValidation.RequiredFieldValidation(isValid);
		}

		private bool CheckId(int Id)
		{
			if (Id < 0)
			{
				return false;
			}
			return true;
		}

		private bool CheckStudentMajorAndCourse()
		{
			string requiredCourse = "BIT";
			string notApplicable = "N/A";
			if (Course.Program == requiredCourse && Major.Program == notApplicable) return false;

			if (Course.Program == requiredCourse && Major.Program == "") return false;

			if (Course.Program != requiredCourse && Major.Program != notApplicable && Course.Program != requiredCourse && Major.Program != "") return false;

			return true;
		}

		// Operations will spit out a DTO format
		public CreateStudentDto Create()
		{
			if(!CheckNullability()) throw new Exception("Only middle name is allowed to be empty.");

			Address.CheckHouseNumberValidity();
			EmailAddress.CheckEmailValidaity();
			PhoneNumber.CheckMobileValidity();
			Address.CheckZipValidity();

			if (!CheckStudentMajorAndCourse()) throw new Exception("Only BIT course can select a major.");

			

			return new CreateStudentDto
				(Student.Firstname, Student.Middlename, Student.Lastname,
				Address.HouseNumber, Address.Street, Address.Barangay,
				Address.Province, Address.City, Address.Zip,
				Course.Program, Major.Program, EmailAddress.Email,
				PhoneNumber.Phonenumber);
		}

		public UpdateStudentDto Update()
		{
			if (!CheckId(Student.Id)) throw new Exception("Id number was not provided.");
			
			if (!CheckNullability()) throw new Exception("Only middle name is allowed to be empty.");

			Address.CheckHouseNumberValidity();
			EmailAddress.CheckEmailValidaity();
			PhoneNumber.CheckMobileValidity();
			Address.CheckZipValidity();

			if (!CheckStudentMajorAndCourse()) throw new Exception("Only BIT course can select a major.");
			
			return new UpdateStudentDto
				(Student.Id, Student.Firstname, Student.Middlename,
				Student.Lastname, Address.HouseNumber, Address.Street,
				Address.Barangay, Address.Province, Address.City,
				Address.Zip, Course.Program, Major.Program,
				EmailAddress.Email, PhoneNumber.Phonenumber);
		}
	}
}
