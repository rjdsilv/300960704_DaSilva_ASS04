if (not exists(select 1 from master.dbo.sysdatabases where name = N'UserLogin'))
begin
	create database UserLogin
end
go

use UserLogin
go

if (exists (select 1 from sys.all_objects where type = N'U' and name = N'Users'))
begin
	drop table dbo.Users
end

create table dbo.Users (
	UserId
		decimal (10, 0)
		not null
		primary key
		identity
,	UserPassword
		varchar(32)
		not null
,	UserFirstName
		varchar(64)
		not null
,	UserLastName
		varchar(64)
		not null
,	UserPhoneNumber
		decimal(10, 0)
		not null
,	UserEmail
		varchar(128)
		not null
)
go