use Project
go

--- getting all important data from all tables about all student who took exams ( 101602 )

-- Student ids   from   --100001   to   --101999


declare @sid int = 100001
while @sid < 101999
begin
	insert into Fact
	select s.S_Id, d.D_Name, c.C_Name, c.C_Duration, max( i.INs_Name) Ins_Name, count(distinct t.T_Name) NO_Topics,
			sc.Enroll_Date, sc.Stu_Crs_Grade, e.Date Exam_Date, count(distinct te.Q_Id) No_Ques,
			(select count(te.St_Ans) from dbo.Take_Exam te where te.S_Id = @sid and te.St_Ans = 1) Answered_Right,
			(select t.c from (select sc.S_Id, ROW_NUMBER() over (order by sum(sc.Stu_Crs_Grade) desc ) c
			from dbo.Stu_Crs sc group by sc.S_Id) t  where t.S_Id = @sid) as "Overall Rank" 
	from dbo.Student s, dbo.Department d, dbo.Course c, dbo.Stu_Crs sc, dbo.Ins_Crs ic, dbo.Instructor i, dbo.Topic t,
		 dbo.Take_Exam te, dbo.Exam e
	where s.D_Id = d.D_Id
	and s.S_Id = sc.S_Id
	and sc.C_Id = c.C_Id
	and c.C_Id = ic.C_Id
	and ic.Ins_Id = i.Ins_Id
	and c.C_Id = t.C_Id
	and te.S_Id = s.S_Id
	and te.E_Id = e.E_Id
	and e.C_Id = c.C_Id
	and   s.S_Id = @sid
	group by  s.S_Id, d.D_Name, c.C_Name, c.C_Duration, sc.Enroll_Date, sc.Stu_Crs_Grade, sc.Stu_Crs_Grade, e.Date, e.E_Id
	order by sc.Stu_Crs_Grade desc
	set @sid = @sid + 1
end

select distinct * from dbo.Fact order by "Overall Rank" desc











