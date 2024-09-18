using StudentInformationSystem.Contracts;
using StudentInformationSystem.Contracts.ICommons;
using StudentInformationSystem.Contracts.IQueryHandler;
using StudentInformationSystem.Data;
using StudentInformationSystem.Factory;
using StudentInformationSystem.Presenter;
using StudentInformationSystem.Repository;
using StudentInformationSystem.Repository.Command.StudentCommand;
using System.Collections.Generic;

namespace StudentInformationSystem.Configurations
{
	public class ConfigationServices : IConfigurationServices
	{
		private readonly IStudentForm _studentForm;
		private readonly IStringValidation _strValidation;
		private readonly RegistrationDataContext _dbContext;
		private readonly IStudentFactory _studentFactory;
		private readonly ICommandHandler<CreateStudentCommand> _createStudenthandler;
		private readonly ICommandHandler<DeleteStudentCommand> _deleteStudenthandler;
		private readonly ICommandHandler<UpdateStudentCommand> _updateStudenthandler;
		private readonly IQueryHandler<FetchAllRecordResult> _getAllStudentHandler;
		private readonly IQueryFindByKey<FindRecordResult> _findRecordByKey;
		private readonly ICourseValidation _courseValidator;
		private readonly IEnumerable<FetchAllCoursesResult> _fetchAllCourses;
		private readonly IEnumerable<FetchAllMajorResult> _fetchAllMajor;


		public ConfigationServices(
			IStudentForm studentForm,
			IStringValidation stringValidation,
			RegistrationDataContext dbContext,
			IStudentFactory studentRegistrationFactory,
			ICommandHandler<CreateStudentCommand> createStudenthandler,
			ICommandHandler<DeleteStudentCommand> deleteStudenthandler,
			ICommandHandler<UpdateStudentCommand> updateStudenthandler,
			IQueryHandler<FetchAllRecordResult> getAllStudentHandler,
			IQueryFindByKey<FindRecordResult> findRecordByKey,
			ICourseValidation courseValidation,
			IEnumerable<FetchAllCoursesResult> fetchAllCourses,
			IEnumerable<FetchAllMajorResult> fetchAllMajor
			)
        {
			_studentForm = studentForm;
			_strValidation = stringValidation;
			_dbContext = dbContext;
			_studentFactory = studentRegistrationFactory;
			_createStudenthandler = createStudenthandler;
			_deleteStudenthandler = deleteStudenthandler;
			_updateStudenthandler = updateStudenthandler;
			_getAllStudentHandler = getAllStudentHandler;
			_findRecordByKey = findRecordByKey;
			_courseValidator = courseValidation;
			_fetchAllCourses = fetchAllCourses;
			_fetchAllMajor = fetchAllMajor;
		}

		public IStudentForm Services()
		{
			_studentForm.SetPresenter(StudentPresenter(_studentForm));
			return _studentForm;
		}

		public IStudentFormPresenter StudentPresenter(IStudentForm studentForm)
		{
			return new StudentFormPresenter
				(studentForm, _studentFactory, _createStudenthandler, _deleteStudenthandler, _updateStudenthandler, _getAllStudentHandler, _findRecordByKey,
				_fetchAllMajor, _fetchAllCourses);
		}
	}
}
