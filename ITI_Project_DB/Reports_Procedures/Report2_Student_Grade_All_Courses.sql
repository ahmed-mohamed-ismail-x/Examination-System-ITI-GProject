use Project
go

---------------------------------Report 2------------------------------

--• Report that takes the student ID and returns the
-- grades of the student in all courses.



create procedure Report2_Student_Grade_All_Courses (@s_id int)
as
begin
	select c.C_Name as "Course Name",  sc.Stu_Crs_Grade as "Grade"
	from dbo.Stu_Crs sc, dbo.Course c
	where sc.C_Id = c.C_Id
	and sc.S_Id = @s_id
	order by sc.Stu_Crs_Grade desc
end 




Exec Report2_Student_Grade_All_Courses 4444


