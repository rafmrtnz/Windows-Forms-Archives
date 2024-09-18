using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Models
{
	public class PhoneNumber
	{
		public int StudentId { get; set; }
		public string Phonenumber { get; set; }
		public Student Student { get; set; }

		public void CheckMobileValidity()
		{
			if (!long.TryParse(Phonenumber, out long phonenum))
				throw new Exception("Invalid mobile number format.");

			if (Phonenumber[0] != '0' || Phonenumber[1] != '9')
				throw new Exception("Phone number should start with \"09\"");
			
			if (Phonenumber.Length < 11 || Phonenumber.Length > 11)
				throw new Exception("Phone number should be 11 characters in lenght.");
		}
	}
}
