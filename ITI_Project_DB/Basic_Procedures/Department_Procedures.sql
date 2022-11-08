use Project
go

--Insert Procedure
create procedure Department_Insert 
(@d_id int, @d_name varchar(50), @MGr_hireDate Date,@Mgr_id int)
as
begin
	insert into dbo.Department values (@d_id, @d_name, @MGr_hireDate, @Mgr_id)
end

go

-- Update Procedure
create procedure Department_Update 
(@d_id_old int, @d_name_new varchar(50), @MGr_hireDate_new Date,@Mgr_id_new int)
as
begin
	update dbo.Department 
	set D_Name =@d_name_new , Mgr_Hiredate=@MGr_hireDate_new, Mgr_Id=@Mgr_id_new
	where D_Id = @d_id_old
end

go

--delete
create procedure Department_Delete (@d_id int)
as
begin
	 delete from Department
	 where D_Id = @d_id
end

go

--Select
create procedure Department_Select (@d_id int)
as
begin
	select * from Department where D_Id = @d_id
end

go

exec Department_Insert 4444, 'Test','2022-4-4',4
exec Department_Update 4444, 'Test', '2022-4-4',4
exec Department_Select 4444
