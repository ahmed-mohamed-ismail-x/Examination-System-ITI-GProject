use Project
go



-- insert procedure 
create procedure Exam_Insert (@e_id int, @c_id int)
as
begin
	insert into dbo.Exam values (@e_id, CONVERT(Date, GETDATE()), @c_id)
end



go


--update procedure
create procedure Exam_Update (@e_id_old int, @date_new date, @c_id_new int)
as
begin
	update dbo.Exam 
	set "Date" = @date_new, C_Id =@c_id_new
	where E_Id = @e_id_old
end



go


--delete procedure 
create procedure Exam_Delete (@e_id int)
as
begin
	delete from dbo.Exam 
	where E_Id = @e_id
end


go


--select procedure
create procedure Exam_Select (@e_id int)
as
begin
	select * from dbo.Exam e where e.E_Id = @e_id
end


go


exec dbo.Exam_Insert 4444, 4444
exec dbo.Exam_Update 4444, '1-1-2001', 4444
exec dbo.Exam_Select 4444
