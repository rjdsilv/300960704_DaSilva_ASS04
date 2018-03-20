if (not exists(select 1 from master.dbo.sysdatabases where name = N'CustomerAddress'))
begin
	create database CustomerAddress
end
go

use CustomerAddress
go

if (exists (select 1 from sys.all_objects where type = N'U' and name = N'CustomerAddress'))
begin
	drop table dbo.CustomerAddress
end

if (exists (select 1 from sys.all_objects where type = N'U' and name = N'Address'))
begin
	drop table dbo.Address
end

if (exists (select 1 from sys.all_objects where type = N'U' and name = N'Customer'))
begin
	drop table dbo.Customer
end

create table dbo.Customer (
	CustomerID
		decimal (10, 0)
		not null
		primary key
		identity
,	NameStyle
		varchar(32)
,	Title
		varchar(5)
		not null
,	FirstName
		varchar(32)
		not null
,	MiddleName
		varchar(32)
,	LastName
		varchar(64)
		not null
,	Sufix
		varchar(32)
,	CompanyName
		varchar(64)
		not null
,	SalesPerson
		varchar(64)
		not null
,	EmailAddress
		varchar(128)
		not null
,	Phone
		decimal(15,0)
		not null
,	Password
		varchar(128)
		not null
)
go

create table dbo.Address (
	AddressID
		decimal (15, 0)
		not null
		primary key
		identity
,	AddressLine1
		varchar(64)
		not null
,	AddressLine2
		varchar(128)
,	City
		varchar(32)
		not null
,	StateProvince
		varchar(32)
		not null
,	CountryRegion
		varchar(32)
		not null
,	PostalCode
		varchar(15)
		not null
)
go

create table dbo.CustomerAddress (
	CustomerID
		decimal (10, 0)
		not null
,	AddressID
		decimal (15, 0)
		not null
,	AddressType
		varchar(15)
		not null
,	rowguid
		uniqueidentifier
		not null
		DEFAULT NEWSEQUENTIALID()
,	ModifiedDate
		datetime

,	constraint PK_CUSTOMER_ADDRESS
		primary key(CustomerID, AddressID)

,	constraint FK_CUSTOMER_CUSTOMER_ID
		foreign key(CustomerID) references dbo.Customer(CustomerID)

,	constraint FK_ADDRESS_ADDRESS_ID
		foreign key(AddressID) references dbo.Address(AddressID)
)
go

insert into dbo.Customer(Title, FirstName, LastName, CompanyName, SalesPerson, EmailAddress, Phone, Password)
values('Mr.', 'Rodrigo', 'da Silva', 'Centennial College', 'Maria da Penha', 'rdasil17@my.centennialcollege.ca', '1234567890', '123456')

insert into dbo.Customer(Title, FirstName, LastName, CompanyName, SalesPerson, EmailAddress, Phone, Password)
values('Ms.', 'Joana', 'Almeida', 'Best Buy', 'Roger Andrews', 'joa.alm@gmail.com', '1112223333', '98765')

insert into dbo.Customer(Title, FirstName, LastName, CompanyName, SalesPerson, EmailAddress, Phone, Password)
values('Mr.', 'Phillip', 'Mc Millan', 'Amazon', 'Matthew Smith', 'p.mcmillan@hotmail.com', '4445556666', '12345')

insert into dbo.Customer(Title, FirstName, LastName, CompanyName, SalesPerson, EmailAddress, Phone, Password)
values('Ms.', 'Alice', 'Brown', 'The Home Depot', 'Martha Murphy', 'alicebrown@gmail.com', '7778889999', 'aliceB')

insert into dbo.Customer(Title, FirstName, LastName, CompanyName, SalesPerson, EmailAddress, Phone, Password)
values('Mr.', 'Mark', 'Mc Donalds', 'Best Buy', 'John Lam', 'mark.donalds@outlook.com', '9876543210', '222333')

insert into dbo.Customer(Title, FirstName, MiddleName, LastName, CompanyName, SalesPerson, EmailAddress, Phone, Password)
values('Mr.', 'Mathias', 'Roy', 'Wilson', 'Amazon', 'Ted Martin', 'mat.row.wil@gmail.com', '2225558888', 'MRW79')
go

insert into dbo.Address(AddressLine1, AddressLine2, City, StateProvince, CountryRegion, PostalCode)
values ('1350 Danforth Avenue', 'Suite 101', 'Scarborough', 'Ontario', 'Canada', 'M4J 6Y7')

insert into dbo.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode)
values ('941 Progress Avenue', 'Scarborough', 'Ontario', 'Canada', 'M1G 3T8')

insert into dbo.Address(AddressLine1, AddressLine2, City, StateProvince, CountryRegion, PostalCode)
values ('Avenida Celso Garcia, 1907', 'Building 18 - Suite 32', 'Sao Paulo', 'Sao Paulo', 'Brazil', '03015000')

insert into dbo.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode)
values ('2911 Eglinton Avenue East', 'Toronto', 'Ontario', 'Canada', 'M1J 2E5')

insert into dbo.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode)
values ('3155 Highway #7', 'Markham', 'Ontario', 'Canada', 'L3R 0J6')

insert into dbo.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode)
values ('49 Race Course Road', 'Taloja', 'Mumbai', 'India', '55485')

insert into dbo.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode)
values ('529 5th Avenue', 'New York', 'New York', 'USA', '45782')

insert into dbo.Address(AddressLine1, City, StateProvince, CountryRegion, PostalCode)
values ('7108 Crenshaw Boulevard', 'Los Angeles', 'California', 'USA', '90043')
go

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(1, 1, 'Home')

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(1, 2, 'Work')

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(1, 3, 'International')

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(2, 4, 'Home')

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(3, 5, 'Home')

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(4, 6, 'Work')

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(5, 7, 'Mother')

insert into dbo.CustomerAddress(CustomerID, AddressID, AddressType)
values(6, 8, 'Home')
go
