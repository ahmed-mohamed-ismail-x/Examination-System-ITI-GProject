

use Project
go

--------------------------Exam Generation Procedure----------------------------


-- Input-----> Student id, Course id, Number of Questions
-- Action----> map the relations between a student and a set of questions in a course 
--			   by inserting these data into take exam table & generate new exam id
--			   if the student took an exam before in this course it will return the old exam id
-- Output----> return an Exam id in this course 


create procedure Exam_Generation (@s_id int, @c_id int, @no_q int) 
as
begin 
	-- generating a new exam id by concatenating student id with course id
	declare @e_id int = convert (int, concat(@c_id, @s_id))
	-- checking if the student had took an exam in this course before
	-- if no generate a batch of questions
	-- if yes return his old exam id
	declare @chk_exam int = (select e.E_Id from dbo.Exam e where e.E_Id = @e_id) 
	if @chk_exam is null
	begin
		--inserting the newly generated exam into the exam table
		insert into dbo.Exam values (@e_id, convert(date, Getdate()), @c_id)
		declare @q_id int
		-- declaring a table that will hold the questions ids so it will not be repeated
		declare @check_Question_table table (q_id int )
		declare @i int = 0
		-- looping to get questions based on the number of questions requested
		while  @i < @no_q
		begin	
			-- getting a random question based on the course id specified 
			set @q_id = ( select top 1 q.Q_Id from dbo.Question q where q.C_Id = @c_id order by NEWID())			
			-- checking if the question already taken in this generation batch
			-- if the question is not taken it will insert it into the take exam table 
			-- if the question is already taken it will start a new iteration 
			-- without incrementing the counter 
			if @q_id not in (select * from @check_Question_table)
			begin
				-- inserting the record into the take exam table
				insert into dbo.Take_Exam (E_Id, S_Id, Q_Id) 
				values (@e_id, @s_id, @q_id )
				-- adding the selected question into the temp table for further checking
				insert into @check_Question_table values (@q_id)
				-- incrementing the counter  	
				set @i = @i + 1
			end
		end
		-- returning the generated exam id
		select @e_id
	end
	else 
	begin
		-- returning the old exam id if exsists
		select e.E_Id from dbo.Exam e 
		where e.E_Id = @e_id
	end
end

go



Exec Exam_Generation 4444, 500, 10



select * from dbo.Take_Exam 
where S_Id = 4444










	