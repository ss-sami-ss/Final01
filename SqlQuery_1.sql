create database Contact
go
use Contact
go
create table dbo.Person
(
	Id int primary key identity(1,1),
	PhoneNumber nvarchar(11),
	TelephoneNumber nvarchar(11),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	IdentityCode nvarchar(10)
	
);