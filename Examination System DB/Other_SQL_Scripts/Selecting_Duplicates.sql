/****** Script for SelectTopNRows command from SSMS  ******/
SELECT * from (select [S_Id]
      ,[D_Name]
      ,[C_Name]
      ,[C_Duration]
      ,[Ins_Name]
      ,[NO_Topics]
      ,[Enroll_Date]
      ,[Stu_Crs_Grade]
      ,[Exam_Date]
      ,[No_Ques]
      ,[Answered_Right]
      ,[Overall Rank],
	  Row_number()over (partition by 
	   [S_Id]
      ,[D_Name]
      ,[C_Name]
      ,[C_Duration]
      ,[Ins_Name]
      ,[NO_Topics]
      ,[Enroll_Date]
      ,[Stu_Crs_Grade]
      ,[Exam_Date]
      ,[No_Ques]
      ,[Answered_Right]
      ,[Overall Rank] 
	  order by 
	   [S_Id]
      ,[D_Name]
      ,[C_Name]
      ,[C_Duration]
      ,[Ins_Name]
      ,[NO_Topics]
      ,[Enroll_Date]
      ,[Stu_Crs_Grade]
      ,[Exam_Date]
      ,[No_Ques]
      ,[Answered_Right]
      ,[Overall Rank]
	  ) c
  FROM [Project].[dbo].[Fact] ) t
  where t.c >1





  select distinct * into #temp from dbo.Fact
  where s_id = 101602
  delete from dbo.Fact
  where s_id = 101602
  insert into dbo.Fact
  select * from #temp

  select distinct * from dbo.Fact
