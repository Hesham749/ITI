--CTE --Common type expression
--CTEs make code more readable.
--readability makes queries easier to debug.
--CTEs can reference the results multiple times throughout the query. 
--By storing the results of the subquery, you can reuse them throughout a larger query.
--CTEs can help you perform multi-level aggregations. 
--make a recursive query

--self relationship
select S.st_fname as studentname , L.st_fname as Leadername
from student S , student L
where L.st_id = S.st_super

with StudMemory
as
	(select * from student)
select S.st_fname as studentname , L.st_fname as Leadername
from StudMemory S , StudMemory L
where L.st_id = S.st_super

select *
from Instructor
where salary > (Select avg(Salary) from Instructor)

with InstMemory
as
	(select * from Instructor)
select *
from InstMemory
where salary > (Select avg(Salary) from InstMemory)

--agregate over aggregate   
select st_Fname,sum(grade) 
from Stud_Course sc inner join Student S
On s.St_Id = SC.St_Id
group by st_fname


with CTE1(SName,total)
as
	(select st_Fname,sum(grade) 
	from Stud_Course sc inner join Student S
	On s.St_Id = SC.St_Id
	group by st_fname)
select Max(total) from CTE1

--recursive
Declare @RowNo int =1;
with ROWCTE as  
   (  
      SELECT @RowNo as ROWNO    
	  UNION ALL  
      SELECT ROWNO+1  
	  FROM   ROWCTE  
	  WHERE  RowNo < 10
    )  
 
SELECT * FROM ROWCTE
execute sp_changedbowner sa
alter database iti set trustworthy on
go
sp_configure 'show advenced options',1;
go
reconfigure
go
sp_configure 'clr_enable',1
go
reconfigure
go
sp_configure 'show_advenced_options',0;
go
reconfigure

