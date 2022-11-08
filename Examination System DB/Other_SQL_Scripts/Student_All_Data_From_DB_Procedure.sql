USE [Project]
GO

/****** Object:  StoredProcedure [dbo].[Student_All_Data_From_DB]    Script Date: 10/22/2022 3:52:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


--- getting all data from all tables about a student ( 101602 )


create procedure [dbo].[Student_All_Data_From_DB] (@sid int )
as
begin
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
end

GO


