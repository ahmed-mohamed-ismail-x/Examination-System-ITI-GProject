Procedure naming in data base

    TableName_Function_of_the_Procedure ()

ex: Course\_Select Course\_Update Course\_Insert Course\_Delete SQL file
Naming TableName\_TypeOfSqlCommands.SQL ex: Course\_procedures.SQL
Stu\_crs\_Procedure.SQL

  -----------------------------------------------------------------------
  every Table has 4 procedures except stu\_crs has 5 ( has two select
  procedures one with 1 param and the other with 2 parameter)
  -----------------------------------------------------------------------
  --Select create procedure Stu\_All\_courses\_Select (@s_Id int) as
  begin select \* from Stu\_crs where s\_Id = @s_Id end

  -----------------------------------------------------------------------

create procedure Stu\_crs\_Select (@s_Id int,@C_Id int) as begin select
\* from Stu\_crs where s\_Id = @s_id and C\_Id=@C_id end
