using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Models
{
	public class EmailAddress
	{
		public int StudentId { get; set; }
		public string Email { get; set; }
		public Student Student { get; set; }

		public void CheckEmailValidaity()
		{
			if (!Email.Contains("@")) throw new Exception("Invalid email, please try again");

			if (Email.TrimEnd().EndsWith(".")) throw new Exception("Invalid Email format.");
		}
	}
}
