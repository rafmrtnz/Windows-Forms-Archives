using StudentInformationSystem.Contracts;
using StudentInformationSystem.Data;
using System.Data.Linq;

namespace StudentInformationSystem.Repository.QueryHandlers.StudentQueryHandler
{
	public class GetEmailExist : IQueryHandler<CheckEmailExistResult>
	{
		public readonly RegistrationDataContext _context;
		public GetEmailExist(RegistrationDataContext context)
		{
			_context = context;
		}

		public ISingleResult<CheckEmailExistResult> Execute()
		{
			throw new System.NotImplementedException();
		}

		ISingleResult<CheckEmailExistResult> IQueryHandler<CheckEmailExistResult>.Execute()
		{
			throw new System.NotImplementedException();
		}
	}
}
