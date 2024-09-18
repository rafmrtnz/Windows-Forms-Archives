using StudentInformationSystem.Data;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Contracts.IQueryHandler
{
	public interface IQueryFindByKey<TResult>
	{
		ISingleResult<FindRecordResult> Execute(string key);
	}
}
