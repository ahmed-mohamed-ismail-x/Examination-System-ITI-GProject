use Project 
go


-- defining a user defined data type of type table 
-- student answer column will hold   1 ---> if the student answer is the model answer 
--								     0 ---> if the student answer is a choice
 
-- why this is required ???
-- the stored procedure will not accept a table-valued-parameter (TVP) without defining its structure
-- it means that in order to take a table-valued-parameter it needs to be user defined type


create type Student_Answers_Table_Type  as table
( Q_Id int, St_Ans bit)

go

--------------------------Exam Student Answers Procedure---------------------


-- Input-----> Exam id, Student id, table of (student answers and Questions ids)
-- Action ---> Update take exam table with the student answers
--			   store 1 ---> if the student answer is the model answer 
--			   store 0 ---> if the student answer is a choice



-- Readonly is mandatory for the table-valued-parameters it means you can't edit a TVP 
create procedure Exam_Student_Answers 
(@e_id int, @s_id int, @st_ans_tvp Student_Answers_Table_Type Readonly)
as
begin
	-- this a set-based data modification using the from clause
	update dbo.Take_Exam
	set  Take_Exam.St_Ans = sa.St_Ans
	from dbo.Take_Exam te, @st_ans_tvp sa
	where te.Q_Id = sa.Q_Id
	and te.E_Id = @e_id
	and te.S_Id = @s_id
end




go
declare @Test as Student_Answers_Table_Type  
insert into @Test 
select te.Q_Id, 1
from dbo.Take_Exam te
where te.S_Id = 4444
and te.E_Id = 6004444
Exec dbo.Exam_Student_Answers 6004444, 4444, @Test
go


-- You can't use the user defined table type variable outside its batch

select * from dbo.Take_Exam where S_Id = 4444 and E_Id = 6004444



