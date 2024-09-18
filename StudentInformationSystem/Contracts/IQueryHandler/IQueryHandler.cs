using System.Data.Linq;

namespace StudentInformationSystem.Contracts
{
	public interface IQueryHandler<TResult>
	{
		ISingleResult<TResult> Execute();
	}
}
