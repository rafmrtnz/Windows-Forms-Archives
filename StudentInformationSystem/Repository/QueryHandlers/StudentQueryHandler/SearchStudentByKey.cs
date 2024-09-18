using StudentInformationSystem.Contracts.IQueryHandler;
using StudentInformationSystem.Data;
using System.Data.Linq;

namespace StudentInformationSystem.Repository.QueryHandlers.StudentQueryHandler
{
	public class SearchStudentByKey : IQueryFindByKey<FindRecordResult>
	{
		public readonly RegistrationDataContext _context;
		public SearchStudentByKey(RegistrationDataContext context)
		{
			_context = context;
		}

		public ISingleResult<FindRecordResult> Execute(string key)
		{
			return _context.FindRecord(key);
		}
	}
}
