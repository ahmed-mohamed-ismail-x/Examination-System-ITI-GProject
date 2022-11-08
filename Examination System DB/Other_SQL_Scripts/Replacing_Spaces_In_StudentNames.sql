

-- method 1

declare s_cur cursor						
for select s.S_Id  from dbo.Student s 
for update of S_Fname, S_Lname 
declare @sid int
open s_cur 
fetch s_cur into @sid
begin
	While @@fetch_status=0					
	begin
		update dbo.Student
		set S_Fname = trim(S_Fname), S_Lname = trim(S_Lname) 
		where S_id = @sid
			
		fetch s_cur into @sid
	end
end   
close s_cur
deallocate s_cur

 

--- method 2



with cte as
( select s.S_Id, Trim(s.S_Fname) as f, trim(s.S_Lname) l
  from dbo.Student s
)
 update dbo.Student
 set S_Fname = c.f, S_Lname = c.l
 from dbo.Student s, cte c
 where s.S_Id = c.S_Id



--- method 3

---student tbl
update dbo.Student 
set S_Fname =  LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(S_Fname, CHAR(10), CHAR(32)),CHAR(13), CHAR(32)),CHAR(160), CHAR(32)),CHAR(9),CHAR(32)))),
S_lname =  LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(S_lname, CHAR(10), CHAR(32)),CHAR(13), CHAR(32)),CHAR(160), CHAR(32)),CHAR(9),CHAR(32))))


