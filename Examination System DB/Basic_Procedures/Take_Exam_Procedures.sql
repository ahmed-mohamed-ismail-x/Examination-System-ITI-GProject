use Project
go


--insert procedure
create procedure Take_Exam_Insert 
(@e_id int, @s_id int, @q_id int, @st_ans varchar(50), @sq_grade int)
as
begin
	insert into dbo.Take_Exam values
	(@e_id, @s_id, @q_id, @st_ans, @sq_grade)
end


go

--update procedure
create procedure Take_Exam_Update 
(@e_id_old int, @s_id_old int, @q_id_old int, @st_ans_new varchar(50), @sq_grade_new int)
as
begin
	update dbo.Take_Exam 
	set St_Ans = @st_ans_new, SQ_Grade = @sq_grade_new
	where E_Id = @e_id_old
	and S_Id = @s_id_old
	and Q_Id = @q_id_old
end


go


-- delete procedure
create procedure Take_Exam_Delete (@e_id int, @s_id int, @q_id int)
as
begin
	delete from dbo.Take_Exam 
	where E_Id = @e_id
	and S_Id = @s_id
	and Q_Id = @q_id
end


go


--select procedure 1 select student ans and grade of a question in specific exam 
create procedure Take_Exam_Select (@e_id int, @s_id int, @q_id int)
as
begin
	select * from dbo.Take_Exam te
	where te.E_Id = @e_id
	and te.S_Id = @s_id
	and te.Q_Id = @q_id
end


go


--select procedure 2 select all student data in specific exam
create procedure Take_Exam_Select_Student_Exam (@e_id int, @s_id int)
as
begin 
	select * from dbo.Take_Exam te
	where te.E_Id = @e_id
	and te.S_Id = @s_id
end


go

exec dbo.Take_Exam_Insert 4444, 4444, 4444, 'Test', 4444
exec dbo.Take_Exam_Update 4444, 4444, 4444, 'Test', 444
exec dbo.Take_Exam_Select 4444, 4444, 4444
exec dbo.Take_Exam_Select_Student_Exam 4444, 4444
