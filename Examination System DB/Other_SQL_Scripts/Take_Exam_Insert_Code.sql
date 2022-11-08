
go

	declare @cid int
	declare @eid int
	declare @qid int
	declare @noq int = 10						--No. questons in each exam
	declare s_cur cursor						--Cursor for looping on all students by Student id
	for select s.S_Id  from dbo.Student s 
	for read only  
	declare @sid int
	open s_cur 
	fetch s_cur into @sid
	begin
		While @@fetch_status=0					-- Looping on all Students
		begin
			set @cid = (select top 1 sc.C_Id from dbo.Stu_Crs sc where sc.S_Id = @sid)  -- getting course id that student enrolled in 
			set @eid = (select top 1 e.E_Id from dbo.Exam e where e.C_Id = @cid)		-- getting one of the exams for this course
			while  @noq > 0						--loop to insert rows into take exam table by No. questions
			begin
												--getting a question based on course id randomlly
				set @qid = ( select top 1 q.Q_Id from dbo.Question q where q.C_Id = @cid order by NEWID())	
				insert into dbo.Take_Exam (E_Id, S_Id, Q_Id, St_Ans, SQ_Grade) 
				values (@eid, @sid, @qid, 1, 10)
												-- if the question id repeated it will not be inserted then it will break out from the current 
									  		    -- iteration without decreasing the No. questions thus it will try again until findind a unique one
				set @noq = @noq - 1
			end
			fetch s_cur into @sid
			set @noq = 10						-- resetting No. Questions to allow adding new questions for the new student
		end
	end
	close s_cur
	deallocate s_cur



