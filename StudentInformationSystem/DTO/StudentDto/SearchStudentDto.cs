using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.DTO
{
	public class SearchStudentDto
	{
        public SearchStudentDto(string key)
        {
            Key = key;
        }
        public string Key { get; private set; }
    }
}
