use Project

go

--Insert Procedure 
create procedure Choices_Insert (@q_id int, @choice varchar(150))
as
begin
	insert into  dbo.Choices values (@q_id, @choice)
end


go


--update procedure 
create procedure Choices_Update (@q_id_old int, @choice_old varchar(150), @choice_new varchar(150))
as
begin
	update dbo.Choices 
	set Choice = @choice_new
	where Q_Id  = @q_id_old
	and   Choice = @choice_old
end


go


--delete procedure 
create procedure Choices_Delete (@q_id int, @choice varchar(150))
as
begin
	delete from dbo.Choices 
	where Q_Id = @q_id
	and Choice = @choice
end


go


-- select  proceure 
create procedure Choices_Select (@q_id int)
as
begin
	select * from dbo.Choices c 
	where c.Q_Id = @q_id
end




go



exec Choices_Insert 4444, 'Test'
exec Choices_Update 4444, 'Test', 'Testt'
exec Choices_Select 4444
