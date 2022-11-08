use Project
go

------------------------------Report 3 --------------------------------


--• Report that takes the instructor ID and returns
--  the name of the courses that he teaches and the
--  number of student per course.




create procedure Report3_Instructor_Course_Name_No_Students (@ins_id int)
as
begin
	select c.C_Name as "Course Name", count(S_ID) as "Number of Students"
	from stu_Crs sc, Course c, Ins_Crs ic
	where c.C_Id=sc.C_Id
	and  ic.C_Id=c.C_Id
	and  ic.Ins_Id = @ins_id 
	group by c.C_Name 
	order by count(sc.S_Id) desc
end



exec Report3_Instructor_Course_Name_No_Students 43



