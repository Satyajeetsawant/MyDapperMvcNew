USE [EmployeeDB]
GO

/****** Object:  StoredProcedure [dbo].[Employees_Update]    Script Date: 16-11-2021 16:43:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Employees_Update]
@id int,
@Name nvarchar(50),
@City nvarchar(50),
@Address nvarchar(50)
	 
as 
begin

update Employees
		set
Name = @Name,
City = @City,
Address = @Address
where Id=@Id
	END

GO


