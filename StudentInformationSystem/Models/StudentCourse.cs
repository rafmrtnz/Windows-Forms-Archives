namespace StudentInformationSystem.Models
{
	public class StudentCourse
	{
		public int StudentId { get; set; }
		public int MajorId { get; set; }

		public Student Student { get; set; }
		public Course Course { get; set; }
	}
}
