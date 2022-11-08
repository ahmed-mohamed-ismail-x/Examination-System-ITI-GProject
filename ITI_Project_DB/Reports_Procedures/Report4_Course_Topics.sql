use Project 
go


-------------------------------Report 4 ----------------------------


-- • Report that takes course ID and returns its topics 





create procedure Report4_Course_Topics (@c_id int)
as
begin
	select T_Name as "Topic Name" 
	from Topic t 
	where @c_id = t.C_Id
	order by t.T_Name 
end



exec Report4_Course_Topics  200
