using StudentInformationSystem.Contracts;
using StudentInformationSystem.Contracts.IQueryHandler;
using StudentInformationSystem.Data;
using StudentInformationSystem.DTO;
using StudentInformationSystem.Factory;
using StudentInformationSystem.Repository;
using StudentInformationSystem.Repository.Command.StudentCommand;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Windows.Forms;

namespace StudentInformationSystem.Presenter
{
	public class StudentFormPresenter : IStudentFormPresenter
	{
		private readonly IStudentForm _View;
		private readonly IStudentFactory _StudentFactory;
		private readonly ICommandHandler<CreateStudentCommand> _CreateHandler;
		private readonly ICommandHandler<DeleteStudentCommand> _DeleteHandler;
		private readonly ICommandHandler<UpdateStudentCommand> _UpdateHandler;
		private readonly IQueryHandler<FetchAllRecordResult> _GetAllStudent;
		private readonly IQueryFindByKey<FindRecordResult> _FindById;
		private readonly IEnumerable<FetchAllMajorResult> _DisplayMajor;
		private readonly IEnumerable<FetchAllCoursesResult> _DisplayCourses;


        public StudentFormPresenter(IStudentForm view, IStudentFactory student,
			ICommandHandler<CreateStudentCommand> CreateStudentHandler,
			ICommandHandler<DeleteStudentCommand> DeleteHandler,
			ICommandHandler<UpdateStudentCommand> UpdateHandler,
			IQueryHandler<FetchAllRecordResult> GetAllStudent,
			IQueryFindByKey<FindRecordResult> FindById,
			IEnumerable<FetchAllMajorResult> DisplayMajor,
			IEnumerable<FetchAllCoursesResult> DisplayCourses)
        {
			_View = view;
			_StudentFactory = student;
			_CreateHandler = CreateStudentHandler;
			_DeleteHandler = DeleteHandler;
			_UpdateHandler = UpdateHandler;
			_GetAllStudent = GetAllStudent;
			_FindById = FindById;
			_DisplayMajor = DisplayMajor;
			_DisplayCourses = DisplayCourses;
		}

        public bool CreateStudent()
		{
			var create = 
				new CreateStudentDto
				(_View.Firstname, _View.Middlename, _View.Lastname,
				_View.HouseNumber, _View.Street, _View.Barangay,
				_View.Province, _View.City, _View.Zip,
				_View.Course, _View.Major, _View.Email,
				_View.Mobile);
			try
			{
				var createStudent = _StudentFactory.BuildStudent(create);
				var command = new CreateStudentCommand(createStudent);
				var optionSelected = _View.ResultMessage("Student saved succesfully!");
				if (optionSelected != DialogResult.OK) return false;
				_CreateHandler.Handle(command);
				return true;
			}
			catch (Exception error)
			{
				_View.ErrorMEssage(error.Message);
				return false;
			}
		}

		public bool DeleteStudent()
		{
			if (_View.Id < 1)
			{
				_View.ErrorMEssage("Removal failed, please select a record and try again.");
				return false;
			}

			try
			{
				var delete = new DeleteStudentDto(_View.Id);
				var command = new DeleteStudentCommand(delete);

				var optionSelected = _View.ResultMessage("Student removed succesfully!");
				if (optionSelected != DialogResult.OK) return false;

				_DeleteHandler.Handle(command);
				
				return true;
			}
			catch (Exception error)
			{
				_View.ErrorMEssage(error.Message);
				return false;
			}
		}

		public IEnumerable<FetchAllCoursesResult> FetchAllCourseDisplay()
		{
			return _DisplayCourses;
		}

		public IEnumerable<FetchAllMajorResult> FetchAllMajorDisplay()
		{
			return _DisplayMajor;
		}

		public ISingleResult<FetchAllRecordResult> FetchAllRecord()
		{
			return _GetAllStudent.Execute();
		}

		public ISingleResult<FindRecordResult> FindByKey()
		{
			return _FindById.Execute(_View.SearchField);
		}

		public bool UpdateStudent()
		{
			if(_View.Id < 1)
			{
				_View.ErrorMEssage("Update failed, please select the information and try again.");
				return false;
			}

			var update =
				new UpdateStudentDto
				(_View.Id, _View.Firstname, _View.Middlename, _View.Lastname,
				_View.HouseNumber, _View.Street, _View.Barangay,
				_View.Province, _View.City, _View.Zip,
				_View.Course, _View.Major, _View.Email,
				_View.Mobile);
			try
			{
				var updateStudent = _StudentFactory.BuildStudent(update);
				var command = new UpdateStudentCommand(updateStudent);

				var optionSelected = _View.ResultMessage("Student updated succesfully!");
				if (optionSelected != DialogResult.OK) return false;

				_UpdateHandler.Handle(command);
				return true;
			}
			catch (Exception error)
			{
				_View.ErrorMEssage(error.Message);
				return false;
			}
		}
	}
}
