use Project
go


------------------------------------Report 6-------------------------------


--• Report that takes exam number and the student
--  ID then returns the Questions in this exam with
--  the student answers.




create procedure Report6_Exam_Student_Questions_Answers (@e_id int, @s_id int)
as
begin
	select q.Q_Text As "Question",
	(case 
		when te.St_Ans = 0 then max( c.Choice)
		else q.Model_Ans
	end) as "Student Answer"
	from Take_Exam te, Question q, Choices c
	where q.Q_Id = te.Q_Id
	and   q.Q_Id = c.Q_Id
	and   te.E_Id =  @e_id
	and   te.S_Id =  @s_id
	group by q.Q_Text, q.Model_Ans, c.Choice, te.St_Ans
	order by q.Q_Text
end


exec  Report6_Exam_Student_Questions_Answers 10001, 100007

