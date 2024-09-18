create database SIS;
use SIS;

create table Student(
	Id int primary key identity(1,1),
	Firstname varchar(255) not null,
	Middlename varchar(255),
	Lastname varchar(255) not null,
);

alter table Student
	add constraint Student_Middlename_Constraint default '' for Middlename;

create table StudentCourse(
	StudentId int not null,
	CourseId int not null,
	Primary Key(StudentId, CourseId),
	foreign key(StudentId) references Student
		on delete cascade on update cascade,
	foreign key(CourseId) references Course
		on delete cascade on update cascade,
);

create table StudentMajor(
	StudentId int not null,
	MajorId int not null,
	primary key(StudentId, MajorId),
	foreign key(StudentId) references Student
		on delete cascade on update cascade,
	foreign key(MajorId) references Major
		on delete cascade on update cascade,
);

create table Course(
	Id int primary key identity(1,1),
	Program varchar(255) not null,
);

create table Major(
	Id int primary key identity(1,1),
	Program varchar(255) not null,
);

create table [Address](
	Id int primary key,
	HouseNumber varchar(255) not null,
	Street varchar(255) not null,
	Barangay varchar(255) not null,
	Province varchar(255) not null,
	City varchar(255) not null,
	Zip varchar(255) not null,
	foreign key(Id) references Student
		on delete cascade
		on update cascade
);

INSERT INTO Course VALUES 
	('BSIT'),
	('BSIS'),
	('BIT');

INSERT INTO Major VALUES 
	('N/A'),
	('Automotive Technology'),
	('Civil Technology'),
	('Cosmetology'),
	('Drafting Technology'),
	('Electrical Technology'),
	('Electronics Technology'),
	('Food Preparation and Services Technology'),
	('Furniture and Cabinet Making');

select * from Major;
select * from Student

select * from student
	inner join
	Address
	on
	Address.Id = Student.Id;

delete from Student;
delete from StudentMajor;
delete from StudentCourse;
delete from Address;

create or alter procedure SaveRecord
	@Firstname varchar(255),
	@Middlename varchar(255),
	@Lastname varchar(255),
	@HouseNumber varchar(255),
	@Street varchar(255),
	@Barangay varchar(255),
	@Province varchar(255),
	@City varchar(255),
	@Zip varchar(255),
	@Course varchar(255),
	@Major varchar(255)
	as
	begin;
		begin transaction;
		declare @NewCourseId int;
		declare @AddressId int;
		declare @StudentId int;

		select @NewCourseId = Course.Id from Course where Course.Program = @Course;

		if @NewCourseId < 1
			begin
				raiserror('Course Id do not exist.', 11, 1);
				rollback transaction;
				return;
			end;
			

		if @Middlename is null
			begin
				set @Middlename = '';
			end;

		if @Major is null
			begin
				select @Major = Major.Id from Major where Major.Program = 'N/A';
			end;

		insert into Student values(@Firstname, @Middlename, @Lastname);
		set @StudentId = SCOPE_IDENTITY();

		insert into StudentCourse values(@StudentId, @NewCourseId);
		insert into StudentMajor values(@StudentId, @Major);

		insert into Address values (@StudentId, @HouseNumber, @Street, @Barangay, @Province, @City, @Zip);

		commit transaction;	
		return 1;
	end;

create or alter procedure UpdateRecord
	@Id int,
	@Firstname varchar(255),
	@Middlename varchar(255),
	@Lastname varchar(255),
	@HouseNumber varchar(255),
	@Street varchar(255),
	@Barangay varchar(255),
	@Province varchar(255),
	@City varchar(255),
	@Zip varchar(255),
	@Course varchar(255),
	@Major varchar(255)

	as

	begin
		begin try
			begin transaction

		if @Id is null
			begin
				raiserror('Id is not found please try again', -1, -1);
				rollback transaction;
				return;
			end;
				
		declare @CourseId int;
		declare @MajorId int;

		select @CourseId = Course.Id from Course where Course.Program = @Course;
		select @MajorId = Major.Id from Major where Major.Program = @Major;

		if @MajorId is null
			begin
				select @MajorId = Major.Id from Major where Major.Program = 'N/A'; 
			end;

		update Student set Firstname = @Firstname, Middlename = @Middlename, Lastname = @Lastname where Id = @Id;
		update Address set HouseNumber = @HouseNumber, Street = @Street, Barangay = @Barangay, Province = @Province, City = @City, Zip = @Zip where Address.Id = @Id;
		update StudentCourse set CourseId = @CourseId where StudentCourse.StudentId = @Id;
		update StudentMajor set MajorId = @MajorId where StudentMajor.StudentId = @Id;
				
		commit transaction;
		return 1;
		end try
		begin catch
			rollback transaction;
			throw;
		end catch;
	end;

create or alter procedure RemoveRecord
	@Id int
	as
	begin
		begin transaction;

		if @Id is null or @Id < 1
			begin
				rollback transaction;
				return 0;
			end;

		delete Student where Student.Id = @Id;
		delete Address where Address.Id = @Id;
		commit transaction;
	end;

create or alter procedure FindRecord
	@Key varchar(255)
	as
	SELECT
	Student.Id, 
	Student.Firstname, 
	Student.Middlename, 
	Student.Lastname, 
	Address.HouseNumber, 
	Address.Street, 
	Address.Barangay, 
	Address.Province, 
	Address.City, 
	Address.Zip, 
	Course.Program AS CourseProgram, 
	Major.Program AS MajorProgram
	FROM 
		Student
	INNER JOIN 
		Address ON Address.Id = Student.Id
	INNER JOIN 
		StudentCourse ON StudentCourse.StudentId = Student.Id
	INNER JOIN 
		Course ON Course.Id = StudentCourse.CourseId
	INNER JOIN 
		StudentMajor ON StudentMajor.StudentId = Student.Id
	INNER JOIN 
		Major ON Major.Id = StudentMajor.MajorId
	where Student.Id like @Key + '%' 
	or 
	Firstname like @Key + '%' 
	or 
	Lastname like @Key + '%' 
	or 
	Middlename like @Key + '%' 
	or 
	Course.Program like @Key + '%'
	or
	Major.Program like @Key + '%'
	or
	City like @Key + '%'
	or
	Province like @Key + '%'
	or 
	Street like @Key + '%'
	or
	Barangay like @Key + '%'
	or
	Zip like @Key + '%';

create or alter procedure FetchAllRecord
	as
	SELECT 
    Student.Id, 
    Student.Firstname, 
    Student.Middlename, 
    Student.Lastname, 
    Address.HouseNumber, 
    Address.Street, 
    Address.Barangay, 
    Address.Province, 
    Address.City, 
    Address.Zip, 
    Course.Program AS CourseProgram, 
    Major.Program AS MajorProgram
	FROM 
		Student
	INNER JOIN 
		Address ON Address.Id = Student.Id
	INNER JOIN 
		StudentCourse ON StudentCourse.StudentId = Student.Id
	INNER JOIN 
		Course ON Course.Id = StudentCourse.CourseId
	INNER JOIN 
		StudentMajor ON StudentMajor.StudentId = Student.Id
	INNER JOIN 
		Major ON Major.Id = StudentMajor.MajorId;

select * from Student;
select * from StudentCourse;
select * from StudentMajor;
select * from Address;

-- applied sub query to select table that references to major and course.
select Student.Id, Firstname, Middlename, Lastname, HouseNumber, Street, Barangay, Province, City, Zip, Course.Program, Major.Program
	from Student 
	inner join 
	Address on Address.Id = Student.Id
	inner join Course
	on Course.Id = (select StudentCourse.CourseId from StudentCourse)
	inner join Major
	on Major.Id = (select StudentMajor.MajorId from StudentMajor)
	where
	Student.Id = 12;


SELECT 
    Student.Id, 
    Student.Firstname, 
    Student.Middlename, 
    Student.Lastname, 
    Address.HouseNumber, 
    Address.Street, 
    Address.Barangay, 
    Address.Province, 
    Address.City, 
    Address.Zip, 
    Course.Program AS CourseProgram, 
    Major.Program AS MajorProgram
FROM 
    Student
INNER JOIN 
    Address ON Address.Id = Student.Id
INNER JOIN 
    StudentCourse ON StudentCourse.StudentId = Student.Id
INNER JOIN 
    Course ON Course.Id = StudentCourse.CourseId
INNER JOIN 
    StudentMajor ON StudentMajor.StudentId = Student.Id
INNER JOIN 
    Major ON Major.Id = StudentMajor.MajorId;