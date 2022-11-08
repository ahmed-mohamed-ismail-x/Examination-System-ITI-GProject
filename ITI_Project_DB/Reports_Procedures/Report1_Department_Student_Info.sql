use Project
go



----------------------------------Report 1 ----------------------


--• Report that returns the students information
--  according to Department No parameter.


create Procedure Report1_Department_Student_Info (@d_id int)
as
begin
	select s.S_Id AS "ID", concat(s.S_Fname, ' ', s.S_Lname) as "Full Name",
	DATEDIFF(YEAR, s.DOB, GETDATE()) as "Age",
	s.Gender, [s].[Address]
	from dbo.Student s
	where s.D_Id = @d_id
	order by s.S_Fname
end 


Exec dbo.Report1_Department_Student_Info 109


