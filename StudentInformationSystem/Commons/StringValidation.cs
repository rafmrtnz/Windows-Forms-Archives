using StudentInformationSystem.Contracts;
using StudentInformationSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem.Commons
{
	public class StringValidation : IStringValidation
	{
		public bool RequiredFieldValidation(List<string> dataSet)
		{
			foreach (var item in dataSet.ToArray())
			{
				if (string.IsNullOrEmpty(item))
				{
					return false;
				}
			}
			return true;
		}
	}
}
