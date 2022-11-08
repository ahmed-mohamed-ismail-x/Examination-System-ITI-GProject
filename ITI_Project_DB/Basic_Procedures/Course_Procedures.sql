use Project
go

--Insert Procedure
create procedure Course_Insert (@c_id int, @c_name varchar(50), @duration int)
as
begin
	insert into dbo.Course values (@c_id, @c_name, @duration)
end

go

-- Update Procedure
create procedure Course_Update 
(@c_id_old int, @c_name_name varchar(50), @duration_new int)
as
begin
	update dbo.Course 
	set C_Name = @c_name_name, C_Duration = @duration_new 
	where C_Id = @c_id_old
end



go



--delete
create procedure Course_Delete (@c_id int)
as
begin
	 delete from Course
	 where C_Id = @c_id
end

go

--Select
create procedure Course_Select (@c_id int)
as
begin
	select * from Course where C_Id = @c_id
end

go

exec Course_Insert 4444, 'Test', 4444
exec Course_Update 4444, 'Test', 444
exec Course_Select 4444




-- WARNNING
-- selecting all procedures for dropping them

/*
SELECT 'DROP PROCEDURE [' + SCHEMA_NAME(p.schema_id) + '].[' + p.NAME + ']'
FROM sys.procedures p
ORDER BY p.name
*/
