use Project
go

--Insert Procedure
create procedure Instructor_Insert 
(@ins_id int, @ins_name varchar(50), @Salary int,@Dept_id int)
as
begin
	insert into dbo.Instructor values (@ins_id , @ins_name , @Salary ,@Dept_id )
end

go

-- Update Procedure
create procedure Instructor_Update 
(@ins_id_old int, @ins_name_new varchar(50), @Salary_new int,@Dept_id_new int)
as
begin
	update dbo.Instructor 
	set INs_Name = @ins_name_new, Salary=@Salary_new, D_id =@Dept_id_new
	where Ins_Id = @ins_id_old
end

go

--delete
create procedure Instructor_Delete (@ins_id int)
as
begin
	 delete from Instructor
	 where Ins_Id = @ins_id
end

go

--Select
create procedure Instructor_Select (@ins_id int)
as
begin
	select * from Instructor where Ins_Id = @ins_id
end

go

exec Instructor_Insert 4444, 'Test',4444,4444
exec Instructor_Update 4444, 'Test', 4444,4444
exec Instructor_Select 4444

