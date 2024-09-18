using System;

namespace StudentInformationSystem.Models
{
	public class Address
	{
		public int StudentId { get; set; }
		public string HouseNumber { get; set; }
		public string Street { get; set; }
		public string Barangay { get; set; }
		public string Province { get; set; }
		public string City { get; set; }
		public string Zip { get; set; }

		public Student Student { get; set; }

		public void CheckHouseNumberValidity()
		{
			if (!int.TryParse(HouseNumber, out int houseno))
				throw new Exception("Invalid house number format.");
		}

		public void CheckZipValidity()
		{
			if (!int.TryParse(Zip, out int zip))
				throw new Exception("Invalid zip code format.");

			if (Zip.Length < 4 || Zip.Length > 4)
				throw new Exception("Zip code should be 4 characters in lenght.");
		}
	}
}
