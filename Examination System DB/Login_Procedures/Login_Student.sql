use Project 
go 


-- Student Login Stored Procedure 

-- user name will be student first name
-- password will by student id

-- action --> check if the student exists in the db

-- output --> will return 0 if the student not in the db
--				   return 1 if thr student in the db


create procedure Login_Student (@userName varchar(50), @password int)
as
begin
	declare @result int = (select count(s.S_Id) from dbo.Student s 
						   where s.S_Fname = @userName
						   and s.S_Id = @password)
	select @result as Result
end



go



Exec dbo.Login_Student 'Frances', 101602


