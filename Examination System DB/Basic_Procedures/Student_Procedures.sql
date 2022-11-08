use Project
go

--Insert Procedure
Create procedure Student_Insert (@s_id int, @s_fname varchar(50), @s_lname varchar(50), @DOB Date,
									@address VarChar(50), @gender varchar(50), @d_id int)
as
begin
	insert into dbo.Student values (@s_id, @s_fname, @s_lname, @DOB, @address, @gender, @d_id )
end

go

-- Update Procedure
create procedure Student_Update 
(@s_id_old int, @s_fname_new varchar(50), @s_lname_new varchar(50), @DOB_new Date,
									@address_new VarChar(50), @gender_new varchar(50), @d_id_new int)
as
begin
	update dbo.Student 
	set S_Fname = @s_fname_new, S_Lname = @s_lname_new, D_of_Birth = @DOB_new, 
		"Address" = @address_new, Gender = @gender_new, D_id = @d_id_new
	where s_Id = @s_id_old
end

go

--delete
create procedure Student_Delete (@s_id int)
as
begin
	 delete from Student
	 where S_Id = @s_id
end

go

--Select
create procedure Student_Select (@s_Id int)
as
begin
	select * from Student where s_Id = @s_Id
end

go

exec Student_Insert 4444, 'Test','test','2022-4-4','test','Male',4444
exec Student_Update 4444, 'Test','test','2022-4-4','test','Test',4444
exec Student_Select 4444
