use Project
go


----------------------------Exam Correction Procedure----------------------


-- Input-----> Exam id, Student id
-- Action----> 1. update the student question grade column in take exam table based on 
--				  the the student answer column
--			   2. calculate the student grade percentage and store it in 
--				  the student course table
-- Output----> return the student grade percentage in this exam




create procedure Exam_Correction (@e_id int, @s_id int)
as
begin
	update dbo.Take_Exam 
	set SQ_Grade = St_Ans * q.Q_Grade
	from dbo.Question q, dbo.Take_Exam te
	where q.Q_Id = te.Q_Id
	and te.E_Id = @e_id
	and te.S_Id = @s_id;

	declare @stu_total_grade decimal(4, 1) = (select sum(te.SQ_Grade) from dbo.Take_Exam te 
									where te.S_Id = @s_id 
									and te.E_Id = @e_id
									and te.SQ_Grade is not Null)
	
	declare @exam_total_grade decimal(4, 1) = (select sum(q.Q_Grade) 
									 from dbo.Question q, dbo.Take_Exam te
									 where q.Q_Id = te.Q_Id
									 and te.E_Id = @e_id
									 and te.S_Id = @s_id)

	declare @stu_exam_grade_percent decimal(4, 1) 
	if @stu_total_grade != 0
	set @stu_exam_grade_percent = (@stu_total_grade/@exam_total_grade)*100
	else set @stu_exam_grade_percent = 0

	update dbo.Stu_Crs 
	set Stu_Crs_Grade = @stu_exam_grade_percent
	where S_Id = @s_id
	and C_Id = (select e.C_Id from dbo.Exam e where e.E_Id = @e_id);
end

go


