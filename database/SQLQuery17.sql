USE [EmployeeDB]
GO

/****** Object:  StoredProcedure [dbo].[Employees_Add]    Script Date: 16-11-2021 16:42:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





create proc [dbo].[Employees_Add]
@Id int,
@Name nvarchar(50),
@City nvarchar(50),
@Address nvarchar(50)
as
begin
insert into Employees(Id,Name,City,Address)
    values
	( @Id,@Name,@City,@Address)
 
end
GO


