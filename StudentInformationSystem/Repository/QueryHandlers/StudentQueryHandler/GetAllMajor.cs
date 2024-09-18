using StudentInformationSystem.Data;
using System.Collections;
using System.Collections.Generic;

namespace StudentInformationSystem.Repository.QueryHandlers.StudentQueryHandler
{
	internal class GetAllMajor : IEnumerable<FetchAllMajorResult>
	{
		public readonly RegistrationDataContext _context;
		public GetAllMajor(RegistrationDataContext context)
		{
			_context = context;
		}

		public IEnumerator<FetchAllMajorResult> GetEnumerator()
		{
			return (IEnumerator<FetchAllMajorResult>)_context.FetchAllMajor().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
