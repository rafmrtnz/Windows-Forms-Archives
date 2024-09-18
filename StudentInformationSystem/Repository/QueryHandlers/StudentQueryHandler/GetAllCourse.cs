using StudentInformationSystem.Contracts;
using StudentInformationSystem.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;

namespace StudentInformationSystem.Repository.QueryHandlers.StudentQueryHandler
{
	public class GetAllCourse : IEnumerable<FetchAllCoursesResult>
	{
		public readonly RegistrationDataContext _context;
		public GetAllCourse(RegistrationDataContext context)
		{
			_context = context;
		}

		public IEnumerator<FetchAllCoursesResult> GetEnumerator()
		{
			return (IEnumerator<FetchAllCoursesResult>)_context.FetchAllCourses().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
