
using StudentInformationSystem.Factory;
using StudentInformationSystem.Models;
using StudentInformationSystem.Models.Aggregates;
using System.Collections.Generic;


namespace StudentInformationSystem.DTO
{
	public class CreateStudentDto
	{
        public CreateStudentDto(
			string firstname, string middlename, string lastname,
			string housenumber, string street, string barangay,
			string province, string city, string zip,
			string course, string major,
			string email, string mobile
			)
        {
			Firstname = firstname;
			Middlename = middlename;
			Lastname = lastname;
			HouseNumber = housenumber;
			Street = street;
			Barangay = barangay;
			Province = province;
			City = city;
			Zip = zip;
			Course = course;
			Major = major;
			Email = email;
			MobileNumber = mobile;
		}

        public string Firstname { get; private set; }
		public string Middlename { get; private set; }
		public string Lastname { get; private set; }
		public string HouseNumber { get; private set; }
		public string Street { get; private set; }
		public string Barangay { get; private set; }
		public string Province { get; private set; }
		public string City { get; private set; }
		public string Zip { get; private set; }
		public string Course { get; private set; }
		public string Major { get; private set; }
		public string Email { get; private set; }
		public string MobileNumber { get; private set; }
	}
}
