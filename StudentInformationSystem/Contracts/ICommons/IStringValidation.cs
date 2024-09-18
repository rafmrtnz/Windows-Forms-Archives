using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Contracts
{
	public interface IStringValidation
	{
		bool RequiredFieldValidation(List<string> dataSet);
	}
}
