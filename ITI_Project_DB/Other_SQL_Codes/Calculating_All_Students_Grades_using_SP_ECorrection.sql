
use Project
go


-------------Calculating_All_Students_Grades_using_SP_Exam_Correction------------



	declare s_e_cur cursor						
	for select distinct te.E_Id, te.S_Id  from dbo.Take_Exam te 
	for read only  
	declare @e_id int
	declare @s_id int
	open s_e_cur 
	fetch s_e_cur into @e_id, @s_id
	begin
		While @@fetch_status=0					
		begin
			Exec dbo.Exam_Correction @e_id, @s_id			
			fetch s_e_cur into @e_id, @s_id
		end
	end
	close s_e_cur
	deallocate s_e_cur



select * from dbo.Stu_Crs



