using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.DTO
{
	public class UpdateStudentDto
	{
		public UpdateStudentDto(
			int id, string firstname, string middlename, string lastname,
			string housenumber, string street, string barangay,
			string province, string city, string zip,
			string course, string major,
			string email, string mobile
			)
		{
			Id = id;
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

		public int Id { get; private set; }
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
