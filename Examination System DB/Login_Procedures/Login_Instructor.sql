use Project 
go 


-- Student Login Stored Procedure 

-- user name will be instructor name
-- password will be instructor id

-- action --> check if the instructor exists in the db

-- output --> will return 0 if the instructor not in the db
--				   return 1 if thr instructor in the db


create procedure Login_Instructor (@userName varchar(50), @password int)
as
begin
	declare @result int = (select count(i.Ins_Id) from dbo.Instructor i 
						   where i.INs_Name = @userName
						   and i.Ins_Id = @password)
	select @result as Result
end



go



Exec dbo.Login_Instructor 'WING CHAN', 69



