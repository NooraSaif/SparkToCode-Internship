create database CompanyMangement

create table Employee 
(
	Fname nvarchar(20) not null,
	Mname nvarchar(20),
	Lname nvarchar(20) not null,
	SSN int primary key identity(1,1), 
	Bdate date, 
	EmployeeAddress nvarchar(100),
	Gender bit default 0,
	Salary int CONSTRAINT CK_Empolyee_Salary check(Salary between 500 and 3500),
	Super_ssn int,
	foreign key (Super_ssn) references Employee(SSN)
)

create table Department 
(
	Dname nvarchar(20) not null,
	Dnamber int primary key identity(1,1),
	Mgr_start_date date not null,
	Mgr_ssn int,
	foreign key (Mgr_ssn) references Employee(SSN)
)

create table Dept_Location 
(
	Dlocation nvarchar(100),
	Dnumber int,
	foreign key (Dnumber) references Department(Dnamber),
	primary key (Dnumber, Dlocation)
)

create table Project 
(
	Pname nvarchar(20) not null,
	Pnumber int primary key identity(1,1),
	Plocation nvarchar(100) not null,
	Dnum int,
	foreign key (Dnum) references Department(Dnamber)
)

create table Works_on 
(
	Essn int,
	Pno int,
	WorkHours int not null, 
	foreign key (Essn) references Employee(SSN),
	foreign key (Pno) references Project(Pnumber),
	primary key (Essn, Pno)
)

create table EDependent
(
	Essn int,
	Dependent_name nvarchar(50) not null,
	gender bit default 0,
	Bdate date,
	Relationship nvarchar(10),
	foreign key (Essn) references Employee(SSN),
	primary key (Essn, Dependent_name)
)

ALTER TABLE Employee
ALTER COLUMN Mname nvarchar(10);

ALTER TABLE Employee
drop column Mname;

ALTER TABLE Employee
add constraint UQ_Employee_Mname unique (Fname);

INSERT INTO Employee(Fname, Lname, Bdate, Gender, Salary)
values ('noora','saif', '12-10-2001', 2, 500)

INSERT INTO Employee(Fname, Lname, Bdate, Gender, Salary)
values ('anas','ahmed', '12-10-2001', 2, 700)

select * from Employee

select * from Employee 
where Fname = 'noora'

select Fname, Lname 
from Employee
