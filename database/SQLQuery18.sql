USE [EmployeeDB]
GO

/****** Object:  StoredProcedure [dbo].[Employees_Delete]    Script Date: 16-11-2021 16:42:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Employees_Delete]
@Id int
as
	begin
		delete from Employees
		where Id = @Id
	END
GO


