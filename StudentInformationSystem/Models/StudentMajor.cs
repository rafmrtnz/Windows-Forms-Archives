using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Models
{
	public class StudentMajor
	{
		public int StudentId { get; set; }
		public int MajorId { get; set; }

		public Student Student { get; set; }
		public Major Major { get; set; }
	}
}
