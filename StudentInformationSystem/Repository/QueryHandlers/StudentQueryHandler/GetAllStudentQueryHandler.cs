
using StudentInformationSystem.Contracts;
using StudentInformationSystem.Data;
using System.Data.Linq;

namespace StudentInformationSystem.Repository.QueryHandlers.StudentQueryHandler
{
	public class GetAllStudentQueryHandler : IQueryHandler<FetchAllRecordResult>
	{
		public readonly RegistrationDataContext _context;
        public GetAllStudentQueryHandler(RegistrationDataContext context)
        {
			_context = context;
        }
        public ISingleResult<FetchAllRecordResult> Execute()
		{
			return _context.FetchAllRecord();
		}
	}
}
