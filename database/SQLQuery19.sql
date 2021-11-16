USE [EmployeeDB]
GO

/****** Object:  StoredProcedure [dbo].[Employees_Get]    Script Date: 16-11-2021 16:42:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Employees_Get]
@Id int
as
begin
select Id,Name,City,Address
from Employees
where Id =@Id
end


GO


