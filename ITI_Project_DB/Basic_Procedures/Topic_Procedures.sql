use Project
go

--Insert Procedure
create procedure Topic_Insert (@t_id int, @t_name varchar(50), @c_id int)
as
begin
	insert into dbo.Topic values (@t_id, @t_name, @c_id)
end

go




-- Update Procedure
create procedure Topic_Update (@t_id_old int, @t_name_new varchar(50), @c_id_new int)
as
begin
	update dbo.Topic 
	set T_Name = @t_name_new, C_Id = @c_id_new 
	where T_Id = @t_id_old
end

go



--delete
create procedure Topic_Delete (@t_id int)
as
begin
	 delete from Topic
	 where T_Id = @t_id
end

go

--Select
create procedure Topic_Select (@t_id int)
as
begin
	select * from Topic where T_Id = @t_id
end

go


exec Topic_Insert 4444, 'Test', 4444
exec Topic_Update 4444, 'Test2', 4444  
exec Topic_Select 4444




