using StudentInformationSystem.Data;
using System.Collections.Generic;
using System.Data.Linq;

namespace StudentInformationSystem.Contracts
{
	public interface IStudentFormPresenter
	{
		bool CreateStudent();
		bool UpdateStudent();
		bool DeleteStudent();
		ISingleResult<FetchAllRecordResult> FetchAllRecord();
		ISingleResult<FindRecordResult> FindByKey();
		IEnumerable<FetchAllCoursesResult> FetchAllCourseDisplay();
		IEnumerable<FetchAllMajorResult> FetchAllMajorDisplay();
	}
}
