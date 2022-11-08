use Project
go



-- Insert procedure 
create procedure Question_Insert 
(@q_id int, @q_text varchar(700), @type varchar(50), @q_grade int, @m_ans varchar(150), @c_id int)
as
begin
	insert into dbo.Question values
	(@q_id, @q_text, @type, @q_grade, @m_ans, @c_id)
end


go


-- Update Procedure 
create procedure Question_Update 
(@q_id_old int, @q_text_new varchar(700), @type_new varchar(50), @q_grade_new int, 
												@m_ans_new varchar(150), @c_id_new int)
as
begin
	update dbo.Question  
	set Q_Text = @q_text_new,
		"Type" = @type_new,
		Q_Grade = @q_grade_new,
		Model_Ans = @m_ans_new,
		C_Id = @c_id_new
	where Q_Id = @q_id_old
end


go


-- delete Procedure
create procedure Question_Delete (@q_id int)
as
begin
	delete from dbo.Question
	where Q_Id = @q_id
end



go



-- select Procedure 1 select all data of a certain question
create procedure Question_Select (@q_id int)
as
begin
	select * from dbo.Question where Q_Id = @q_id
end



go


-- select Procedure 2 select all the questions of a certain course ID
create procedure Questions_Select_Course (@c_id int)
as
begin
	select * from dbo.Question where C_Id = @c_id
end


go

exec Question_Insert 4444, 'Test', 'Test', 4444, 'Test', 4444
exec Question_Update 4444, 'Test', 'Test', 444, 'Test', 4444
exec Question_Select 4444
exec Questions_Select_Course 4444

