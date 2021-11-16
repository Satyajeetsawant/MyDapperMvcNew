USE [EmployeeDB]
GO

/****** Object:  StoredProcedure [dbo].[Employee_ViewAll]    Script Date: 16-11-2021 16:40:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Employee_ViewAll]
as
begin
select Id,
Name,
City,
Address
from Employees
end
GO


