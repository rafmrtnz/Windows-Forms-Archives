using StudentInformationSystem.Commons;
using StudentInformationSystem.Configurations;
using StudentInformationSystem.Contracts;
using StudentInformationSystem.Data;
using StudentInformationSystem.Factory;
using StudentInformationSystem.Repository.CommandHandlers.StudentCommandHandlers;
using StudentInformationSystem.Repository.QueryHandlers.StudentQueryHandler;
using System;
using System.Windows.Forms;

namespace StudentInformationSystem
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var dataContext = new RegistrationDataContext();
			IStringValidation stringValidation = new StringValidation();

			IConfigurationServices config = new ConfigationServices
				(
				new StudentForm(),
				stringValidation,
				dataContext,
				new StudentFactory(stringValidation),
				new CreateStudentHandler(dataContext),
				new DeleteStudentHandler(dataContext),
				new UpdateStudentHandler(dataContext),
				new GetAllStudentQueryHandler(dataContext),
				new SearchStudentByKey(dataContext),
				new CourseValidation(),
				new GetAllCourse(dataContext),
				new GetAllMajor(dataContext)
				);


			Application.Run((Form) config.Services());
		}
	}
}
