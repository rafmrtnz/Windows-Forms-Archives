using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.DTO
{
	public class DeleteStudentDto
	{
        public DeleteStudentDto(int Id)
        {
            StudentId = Id;
        }

        public int StudentId { get; private set; }
    }
}
