use Project 
go
create Procedure getcourse_results (@s_id int)
as
begin
	select c.C_Name, sc.Enroll_Date, sc.Stu_Crs_Grade
	from dbo.Course c, dbo.Stu_Crs sc
	where c.C_Id = sc.C_Id
	and sc.S_Id = @s_id
end