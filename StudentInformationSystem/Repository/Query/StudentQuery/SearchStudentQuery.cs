using StudentInformationSystem.Contracts;
using StudentInformationSystem.DTO;

namespace StudentInformationSystem.Repository.Query.StudentQuery
{
	public class SearchStudentQuery : IQuery
	{
		public SearchStudentDto Search { get; }
        public SearchStudentQuery(SearchStudentDto search)
		{
			Search = search;
        }
    }
}
