
using StudentInformationSystem.Contracts.ICommons;
using System;

namespace StudentInformationSystem.Commons
{
	public class CourseValidation : ICourseValidation
	{
		public bool ValidateCourseAndMajor(string course, string major)
		{
			if (course == "BSIT" || course == "BSIS")
				if (Convert.ToInt32(major) != 1)
					throw new Exception("BSIT and BSIS should have no Major. Please try again.");

			if (course == "BIT" && Convert.ToInt32(major) == 1)
				throw new Exception("Please select Major for BIT course.");

			return true;
		}
	}
}
