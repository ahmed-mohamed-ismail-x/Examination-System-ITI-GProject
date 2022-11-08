
--------------------------------Faking Insights--------------------------------


--- enrolling newly added student in courses by inserting them into stu_crs table 


	declare cur cursor						
	for select s.S_Id from dbo.Student s where s.S_Id > 101600 
	for read only  
	declare @s_id int
	declare @c_id int
	declare @Enroll_date date
	declare @grade_tbl table (grade decimal (4, 1)) 
	insert into @grade_tbl values 
	(40.0), (60.0), (50.0), (70.0), (30.0), (93.0), (87.0), (62.0), (75.0)
	declare @grade decimal (4, 1) 
	declare @Courses_Student_Enrolled_In Table (c_id int)
	open cur 
	fetch cur into @s_id
	begin
		While @@fetch_status=0					
		begin
			insert into @Courses_Student_Enrolled_In
			select sc.C_Id from dbo.Stu_Crs sc where sc.S_Id = @s_id
			set @c_id = (select top 1 c.C_Id from dbo.Course c order by NEWID())
			if @c_id not in (select * from @Courses_Student_Enrolled_In)
			begin
				set @Enroll_date = (select top 1 sc.Enroll_Date from dbo.Stu_Crs sc order by NEWID())
				set @grade = (select top 1 grade from @grade_tbl order by NEWID()) 
				insert into dbo.Stu_Crs values ( @s_id, @c_id, @Enroll_date, @grade)
				fetch cur into @s_id
			end
		end
	end
	close cur
	deallocate cur



-----------------------------------------------------------------------------------



-- removing the last digit of the instructor salary


go

with mycte 
as
(
	select i.Ins_Id id, convert(int, left(convert(varchar(50), i.Salary ), len(i.Salary)-1)) s
	from dbo.Instructor i
)
update dbo.Instructor
set Salary = m.s
from mycte m
where Ins_Id = m.id



----------------------------------------------------------------------------------------------



--- increasing the number of courses the instructors teach




declare i_cur cursor						
for select  i.Ins_Id from dbo.Instructor i where i.Ins_Id > 45
declare @iid int
declare @ins_crs_tbl table (c_id int)
declare @c_id int
open i_cur 
fetch i_cur into @iid
begin
	While @@fetch_status=0					
	begin
		insert into @ins_crs_tbl
		select ic.C_Id from dbo.Ins_Crs ic
		where ic.Ins_Id = @iid
		set @c_id = (select top 1 c.C_Id from dbo.Course c order by NEWID())
		if @c_id not in(select * from @ins_crs_tbl)
		begin
			insert into dbo.Ins_Crs values (@iid, @c_id)
			fetch i_cur into @iid
		end 
	end
end   
close i_cur
deallocate i_cur


--No courses each instructor teach

select ic.Ins_Id, count(ic.C_Id)
from dbo.Ins_Crs ic
group by ic.Ins_Id


--No instructors teach each course

select ic.C_Id, count(ic.Ins_Id)
from dbo.Ins_Crs ic
group by ic.C_Id



--------------------------------------------------------------------------------------


-- deleting test data



select * from dbo.Take_Exam te where te.E_Id = 4444 
select * from dbo.Take_Exam te where te.E_Id in (select E_Id from dbo.Exam where C_Id = 4444 )
select * from dbo.Exam e where e.E_Id = 4444
select * from dbo.Exam where C_Id = 4444 
select * from dbo.Choices c where c.Q_Id = 4444 
select * from dbo.Question q where q.Q_Id = 4444
select * from dbo.Stu_Crs sc where sc.S_Id = 4444
select * from dbo.Student s where s.S_Id = 4444
select * from dbo.Ins_Crs ic where ic.Ins_Id = 4444
select * from dbo.Topic t where t.T_Id = 4444
select * from dbo.Course c where c.C_Id = 4444
select * from dbo.Instructor i where i.Ins_Id = 4444
select * from dbo.Department d where d.D_Id = 4444



delete from dbo.Take_Exam  where E_Id = 4444 
delete from dbo.Take_Exam  where Q_Id = 4444 
delete from dbo.Take_Exam  where S_Id = 4444 
delete from dbo.Take_Exam  where E_Id in (select E_Id from dbo.Exam where C_Id = 4444 )
delete from dbo.Exam  where E_Id = 4444
delete from dbo.Exam where C_Id = 4444 
delete from dbo.Choices  where Q_Id = 4444 
delete from dbo.Question  where Q_Id = 4444
delete from dbo.Stu_Crs  where S_Id = 4444
delete from dbo.Stu_Crs  where C_Id = 4444
delete from dbo.Student  where S_Id = 4444
delete from dbo.Ins_Crs  where Ins_Id = 4444
delete from dbo.Ins_Crs  where C_Id = 4444
delete from dbo.Topic  where T_Id = 4444
delete from dbo.Course  where C_Id = 4444
delete from dbo.Instructor  where Ins_Id = 4444
delete from dbo.Department  where D_Id = 4444





-- total grades for each student

select sc.S_Id, sum(sc.Stu_Crs_Grade)
from dbo.Stu_Crs sc
group by sc.S_Id
order by sum(sc.Stu_Crs_Grade) desc




-------------------------------------------------------------------------------------





select * from dbo.Take_Exam 
select * from dbo.Exam 
select * from dbo.Choices 
select * from dbo.Question 
select * from dbo.Stu_Crs
select * from dbo.Student
select * from dbo.Ins_Crs 
select * from dbo.Topic 
select * from dbo.Course 
select * from dbo.Instructor 
select * from dbo.Department 






---------------------------------------------------------------------------------------------

-- removing special chars from instructors names

update dbo.Instructor 
set INs_Name =  LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(INs_Name, CHAR(10), CHAR(32)),CHAR(13), CHAR(32)),CHAR(160), CHAR(32)),CHAR(9),CHAR(32))))


-----------------------------------------------------------------------

-- making Q grades different from each other 

update dbo.Question
set Q_Grade = 5 
where Q_Id  like '%2'



---------------------------------------------------------------------------


-- making students take exams and solve questions




go

declare s_cur cursor						
for select s.S_Id  from dbo.Student s 
for read only  
declare @sid int
declare @qid int
declare @noq int = 10						
declare @cid int 
declare @eid int 
open s_cur 
fetch s_cur into @sid
begin
	While @@fetch_status=0					
	begin
		set @cid = (select distinct top 1 sc.C_Id from dbo.Stu_Crs sc where sc.S_Id = @sid)
		set @eid = convert (int, concat(@cid, @sid))
		if @cid is not null
		begin
			insert into dbo.Exam values (@eid, convert(date, Getdate()), @cid)
			while  @noq > 0						
			begin
				set @qid = ( select top 1 q.Q_Id from dbo.Question q where q.C_Id = @cid order by NEWID())	
				insert into dbo.Take_Exam (E_Id, S_Id, Q_Id, St_Ans, SQ_Grade) 
				values (@eid, @sid, @qid, 1, 10)
				set @noq = @noq - 1
			end
			set @noq = 10
		end
		fetch s_cur into @sid
	end
end
close s_cur
deallocate s_cur




update dbo.Take_Exam
set St_Ans = 0, SQ_Grade = 0
where Q_Id like '%5'




select count(distinct S_Id) from dbo.Take_Exam


---------------------------------------------------------------------------


