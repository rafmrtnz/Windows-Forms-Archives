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

create table Email(
	Id int,
	EmailAddress varchar(255) not null unique,
	primary key(Id),
	foreign key(Id) references Student
		on delete cascade
		on update cascade
);

create table Mobile(
	Id int,
	Number varchar(255) not null unique,
	primary key(Id),
	foreign key(Id) references Student
		on delete cascade 
		on update cascade
);


ALTER TABLE Mobile
DROP CONSTRAINT UQ_Number;

ALTER TABLE Mobile
ALTER COLUMN Number VARCHAR(255);

ALTER TABLE Mobile
ADD CONSTRAINT UQ_Number UNIQUE (Number);


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

delete from major;
delete from course;
DBCC CHECKIDENT ('major', RESEED, 0);
DBCC CHECKIDENT ('course', RESEED, 0);


select * from Major;
select * from course;
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
delete from Mobile;
delete from Email;

create or alter procedure CheckEmailExist
	@Email varchar(255)
	as
	select @Email from Email where Email.EmailAddress = @Email;

create or alter procedure CheckMobileNumberExist
	@Mobile varchar(255)
	as
	select @Mobile from Mobile where Mobile.Number = @Mobile;



create or alter procedure SaveRecord
	@Firstname varchar(255),
	@Middlename varchar(255),
	@Lastname varchar(255),
	@Email varchar(255),
	@Mobile varchar(255),
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
	begin try
		begin transaction;
		declare @NewCourseId int;
		declare @AddressId int;
		declare @StudentId int;
		declare @IsEmailExist varchar(255);
		declare @IsNumberExist varchar(255);
		declare @MajorId int;
		
		select @IsEmailExist = Email.EmailAddress from Email where Email.EmailAddress = @Email;
		select @IsNumberExist = Mobile.Number from Mobile where Mobile.Number = @Mobile;
		select @MajorId = Major.Id from Major where Major.Program = @Major;

		if @IsEmailExist is not null
			begin
				rollback transaction;
				raiserror('Email already exist.', -1, -1);
			end;

		if @IsNumberExist is not null
			begin
				rollback transaction;
				raiserror('Number already exist.', -1, -1);
			end;

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

		if @Major is null or @Major = ''
			begin
				select @Major = Major.Id from Major where Major.Program = 'N/A';
			end;

		if @Major = 'N/A'
			begin
				select @Major = Major.Id from Major where Major.Program = 'N/A';
			end;

		insert into Student values(@Firstname, @Middlename, @Lastname);
		set @StudentId = SCOPE_IDENTITY();

		insert into StudentCourse values(@StudentId, @NewCourseId);
		insert into StudentMajor values(@StudentId, @MajorId);
		insert into Address values (@StudentId, @HouseNumber, @Street, @Barangay, @Province, @City, @Zip);
		insert into Email values (@StudentId, @Email);
		insert into Mobile values (@StudentId, @Mobile);

		commit transaction;
	end try
	begin catch
		rollback transaction;
		throw;
	end catch;
	end;

create or alter procedure UpdateRecord
	@Id int,
	@Firstname varchar(255),
	@Middlename varchar(255),
	@Lastname varchar(255),
	@Email varchar(255),
	@Mobile varchar(255),
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

		if @MajorId = ''
			begin
				select @MajorId = Major.Id from Major where Major.Program = 'N/A'; 
			end;

		if @MajorId = 'N/A'
			begin
				select @MajorId = Major.Id from Major where Major.Program = 'N/A'; 
			end;

		update Student set Firstname = @Firstname, Middlename = @Middlename, Lastname = @Lastname where Id = @Id;
		update Address set HouseNumber = @HouseNumber, Street = @Street, Barangay = @Barangay, Province = @Province, City = @City, Zip = @Zip where Address.Id = @Id;
		update StudentCourse set CourseId = @CourseId where StudentCourse.StudentId = @Id;
		update StudentMajor set MajorId = @MajorId where StudentMajor.StudentId = @Id;
		update Mobile set Number = @Mobile where Mobile.Id = @Id;
		update Email set EmailAddress = @Email where Email.Id = @Id;

				
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
    Course.Program AS Course, 
    Major.Program AS Major,
	Mobile.Number AS 'Mobile Number',
	Email.EmailAddress AS Email
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
	INNER JOIN
		Mobile ON Mobile.Id = Student.Id
	INNER JOIN
		Email ON Email.Id = Student.Id;

create or alter procedure FetchAllMajor
	as
	SELECT Major.Id, Major.Program FROM Major;

create or alter procedure FetchAllCourses
	as
	SELECT Course.Id, Course.Program FROM Course;




select * from Student;
select * from StudentCourse;
select * from StudentMajor;
select * from Address;

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
    Course.Program AS Course, 
    Major.Program AS Major,
	Mobile.Number AS 'Mobile Number',
	Email.EmailAddress AS Email
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
	INNER JOIN
		Mobile ON Mobile.Id = Student.Id
	INNER JOIN
		Email ON Email.Id = Student.Id;

INSERT INTO Email values (13, 'johndoe@gmail.com')
INSERT INTO Mobile values (13, '09254375843')

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
    Course.Program AS Course, 
    Major.Program AS Major,
	Mobile.Number AS 'Mobile Number',
	Email.EmailAddress AS Email
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
	INNER JOIN
		Mobile ON Mobile.Id = Student.Id
	INNER JOIN
		Email ON Email.Id = Student.Id;

select * from Mobile;
