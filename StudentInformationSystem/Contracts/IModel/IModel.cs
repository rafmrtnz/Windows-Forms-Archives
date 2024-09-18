using StudentInformationSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Contracts.IModel
{
	public interface IModel
	{
		CreateStudentDto Create();
		UpdateStudentDto Update();
	}
}
