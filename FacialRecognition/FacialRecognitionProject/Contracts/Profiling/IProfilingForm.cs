using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacialRecognitionProject.Contracts.Profiling
{
	public interface IProfilingForm
	{
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Gender { get; set; }

        event EventHandler ClickSaveUserProfile;
        event EventHandler Timer;
        event EventHandler DisplayBox;

        void ShowMessage(string message);
        void TimerStart();
	}
}
