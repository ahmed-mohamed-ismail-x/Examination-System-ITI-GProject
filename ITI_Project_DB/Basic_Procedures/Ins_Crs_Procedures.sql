use Project
go


-- insert procedure
create procedure Ins_Crs_Insert (@ins_id int, @c_id int)
as
begin
	insert into dbo.Ins_Crs 
	values (@ins_id, @c_id)
end



go


--update procedure
create procedure Ins_Crs_Update 
(@ins_id_old int, @c_id_old int, @ins_id_new int, @c_id_new int)
as
begin
	update dbo.Ins_Crs 
	set Ins_Id = @ins_id_new, C_Id = @c_id_new
	where Ins_Id = @ins_id_old
	and C_Id = @c_id_old
end



go



--delete procedure
create procedure Ins_Crs_Delete (@ins_id int, @c_id int)
as
begin
	delete from dbo.Ins_Crs
	where Ins_Id = @ins_id
	and C_Id = @c_id
end



go


--select procedure 1 select all courses of an instructor
create procedure Ins_Crs_select_Courses (@ins_id int)
as
begin
	select * from dbo.Ins_Crs ic 
	where ic.Ins_Id = @ins_id
end


go



-- select procdure 2 select all instructors of a course
create procedure Ins_crs_Select_Instructors (@c_id int)
as
begin
	select * from Ins_Crs ic 
	where ic.C_Id = @c_id
end



go

exec dbo.Ins_Crs_Insert 4444, 4444
exec dbo.Ins_Crs_Update 4444, 4444, 4444, 100
exec dbo.Ins_Crs_select_Courses 4444
exec dbo.Ins_crs_Select_Instructors 4444
