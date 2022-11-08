create view Options as 
select q.Q_Id, q.Model_Ans
from dbo.Question q
union 
select c.Q_Id, c.Choice
from dbo.Choices c