use Project
go

--Insert Procedure
create procedure Stu_Crs_Insert (@s_id int, @c_id int )
as
begin
	insert into dbo.Stu_crs values (@s_id , @c_id, CAST( GETDATE() AS Date ))
end

go

-- Update Procedure
create procedure Stu_crs_Update (@s_id_old int, @c_id_old int, @s_id_new int, @c_id_new int)
as
begin
	update dbo.Stu_crs 
	set s_Id = @s_id_new ,  C_Id= @c_id_new ,E_Date=CAST( GETDATE() AS Date )
	where s_Id = @s_id_old and C_Id=@c_id_old
end

go

--delete Procedure
create procedure Stu_crs_Delete (@s_id int,@c_id int)
as
begin
	 delete from Stu_crs
	 where s_Id = @s_id and C_Id=@C_id
end



go



--Select procedure 1 select all courses of a certain student
create procedure Stu_Crs_Select_Courses (@s_id int)
as
begin
	select * from Stu_crs where s_Id = @s_id
end



go




-- select procedure 2 select all students of a certain course
create procedure Stu_Crs_Select_Students (@c_id int)
as
begin
	select * from Stu_crs where C_Id = @c_id
end



go


exec Stu_crs_Insert 4444, 4444
exec Stu_crs_Update 4444, 4444, 4444, 4444
exec Stu_Crs_Select_Courses 4444
exec Stu_crs_Select_Students 4444

