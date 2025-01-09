declare @x int=(select avg(st_age) from Student)
set @x=90
select @x=100
select @x

declare @y int=100
select @y=st_age from student where st_id=80
select @y

declare @age int
select @age=st_age from Student where st_address='alex'
select @age

declare @y int,@n varchar(20)
select @y=st_age,@n=st_fname from student where st_id=8
select @y,@n

declare @y int
update Student  set st_fname='ali',@y=st_age
where st_id=4
select @y

declare @t table(col1 int)
insert into @t 
select st_age from Student where st_address='alex'
select * from @t


declare @t table(col1 int,col2 varchar(20))
insert into @t 
select st_age,st_fname from Student where st_address='alex'
select * from @t

declare @x int=4
select top(@x) *
from student

declare @col varchar(20)='*',@t varchar(20)='instructor'
execute('select '+@col+'  from '+@t)

select * from Student

select 'select * from Student'

execute ('select * from Student')

--Global Varibales

Select @@servername

select @@version

select @@SERVERNAME='ahmed'  XXXXXXXXX

Declare @@x int ----------Local Variable

update Student set st_age+=1
select @@ROWCOUNT

select * from student where st_address='alex'
select @@ROWCOUNT

update Student set st_age+=1
select @@ROWCOUNT
select @@ROWCOUNT

select * from student
go
select @@error

select @@identity
---------------------------------------------
-------------------
--Control of Flow
--if
declare @x int
update Student set st_age+=1
select @x=@@ROWCOUNT
if @x>0
	begin
	select 'Multi rows affected =' +convert(varchar(2),@x)
	end
else
	begin
	select 'No Rows Affected'
	end
--begin
--end
--if exists     if not exists

select name from sys.tables

if exists(select name from sys.tables where name='studs')
	select 'table is existed'
else
	create table studs
	(
	id int ,
	name varchar(20)
	)

if not exists(select dept_id from Student where Dept_Id=300)
	and not exists(select dept_id from Instructor where dept_id=300)
		delete from Department 	where dept_id=300
else
	select 'table has relation'

begin try
	delete from Department where dept_id=30
end try
begin catch
	select 'error'
end catch

--while
declare @x int=10
while @x<=20
	begin
		set @x+=1
		if @x=14
			continue
		if @x=16
			break
			select @x
	end 
 --continue
 --break
 --case   iif
 --choose
 --waitfor
------------------------------------
--windowing Function
-- lead    lag   first_value   last_value

select s.st_id as sid,st_fname as sname,grade,crs_name as Cname into grades
from Student s,Stud_Course sc,Course c
where s.St_Id=sc.St_Id and c.Crs_Id=sc.Crs_Id

select * from grades


SELECT sname,grade,Cname,
	   Prod_prev=lAG(sname) OVER(ORDER BY grade),
	   Prod_Next=LEAD(sname) OVER(ORDER BY grade)
FROM grades

SELECT sname,grade,cname,
	   Prod_prev=lAG(sname) OVER(partition by Cname ORDER BY grade),
	   Prod_Next=LEAD(sname) OVER(partition by Cname ORDER BY grade)
FROM grades

SELECT sname,grade,Cname,
	   First=FIRST_VALUE(grade)  OVER(ORDER BY grade),
	   last=LAST_VALUE(grade)    OVER(ORDER BY grade Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades

SELECT sname,grade,Cname,
	    FIRST_VALUE(grade) OVER(partition by Cname ORDER BY grade),
	   LAST_VALUE(grade) OVER(partition by Cname ORDER BY grade Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades

SELECT sname,grade,
	   Prod_prev=lAG(grade) OVER(ORDER BY grade),
	   Prod_Next=LEAD(grade) OVER(ORDER BY grade),
	   First=FIRST_VALUE(grade) OVER(ORDER BY grade),
	   last=LAST_VALUE(grade) OVER(ORDER BY grade Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades

SELECT sname,grade,Cname,
	   Prod_prev=lAG(Sname) OVER(partition by Cname ORDER BY grade),
	   Prod_Next=LEAD(Sname) OVER(partition by Cname ORDER BY grade),
	   First=FIRST_VALUE(Sname) OVER(partition by Cname ORDER BY grade),
	   last=LAST_VALUE(Sname) OVER(partition by Cname ORDER BY grade Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades

---------------------------------------
--insert statement
--simple insert
insert into student(st_id,st_fname)
values(222,'ali')	

--insert Constructor
insert into student(st_id,st_fname)
values(222,'ali'),(333,'omar'),(444,'khalid')

--insert based on select 
insert into test
select * from student where st_adderss='alex' 	

--bulk insert
bulk insert mytest
from 'D:\student.txt'
with (fieldterminator=',')

--insert based on execute  (Stored Procedure)

--identity Insert
CREATE TABLE dbo.T1 ( column_1 int, column_2 VARCHAR(30),
					column_3 int IDENTITY primary key);
GO

SELECT * FROM T1

delete from T1 where column_3 between 3 and 13


INSERT T1 VALUES (70,'new rows');

INSERT T1  VALUES (789,'Row #2');
GO
SET IDENTITY_INSERT T1 ON;
SET IDENTITY_Insert T1 off;
GO
INSERT INTO T1 (column_3,column_1,column_2)  VALUES 
(7,1, 'Explicit identity value');
GO
SELECT column_1, column_2,column_3
FROM T1;

drop table T1

dbcc checkident(T1,RESEED,8)
------------------------
-------------Functions
---Scalar
--string GetSname(int id)
alter function GetSname(@id int)
returns Varchar(30)
	begin
		declare @name varchar(30)
		select @name=st_fname from Student
		where st_id=@id
		return @name	
	end

select dbo.getSname(3)

drop function GetSname


--Inline
Create function Getist(@did int)
returns table
	as
	return
	(
	 select ins_name,salary*12 as TotalSal
	 from Instructor
	 where Dept_Id=@did	
	)

select * from Getist(20)

select ins_name from Getist(20)

select sum(totalsal) from getist(10)

--Multi statement
create function GetStuds(@format varchar(20))
returns @t table
			(
			 id int,
			 sname varchar(20)
			)
as
	begin
		if @format='first'
			insert into @t
			select st_id,st_fname from Student
		else if @format='last'
			insert into @t
			select st_id,st_Lname from Student
		else if @format='fullname'
			insert into @t 
			select st_id,st_fname+' '+st_lname from Student
		return 
	end

select * from getstuds('Fullname')


alter schema hr transfer GetSname

use Adventureworks2012

select *
from HumanResources.EmployeeDepartmentHistory

create synonym ED
for  HumanResources.EmployeeDepartmentHistory

select *
from ED
-------------------------------------------------
--physical Table
create table exam
(
 eid int,
 edate date,
 numofQ int
)

drop table exam


--local table    --session based tables
create table #exam
(
 eid int,
 edate date,
 numofQ int
)


--global table   --shared tables

create table ##exam
(
 eid int,
 edate date,
 numofQ int
)


----------------------
create table test
create table #test
create Table ##test
declare @t table
------------------------

--variables
--Control of flow
--Windowing Function
--User Defined Function
--System DBs   [temp tables]






