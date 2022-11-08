use Project
go


------------------------------ Report 5 ------------------------------



-- • Report that takes exam number and returns the
--   Questions in it



create procedure Report5_Exam_Questions (@e_id int)
as
begin
	select distinct q.Q_text as "Questions"
	from Question q, Take_Exam te
	where te.Q_Id = q.Q_Id
	and   te.E_Id = @e_id
	order by q.Q_Text
end



exec Report5_Exam_Questions 100001

