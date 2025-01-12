select * from student

create Proc Getst
as
	select * from student

GetSt
execute GetSt

create Proc GetstByID   @id int
as
	select st_id,st_fname,st_age 
	from student
	where st_id=@id

GetStByID 7


alter Proc GetstByadd   @add varchar(20)
with encryption
as
	select st_id,st_fname,st_address 
	from student
	where st_address=@add

GetstbyAdd  'alex'

sp_helptext 'Getstbyadd'

alter schema hr transfer Getst


insert into student(st_id,st_fname)
values(40,'ali')

alter Proc InstSt @id int,@n varchar(20)
as	
if not exists(select st_id from Student where st_id=@id)
	insert into student(st_id,st_fname)
	values(@id,@n)
else
	select 'Duplicate ID'

Instst 40,'ali'


create proc DelDept @did int
as
	begin try
		delete from Department where dept_id=@did
	end try
	begin catch
		select 'Error'
	end catch

DelDept 30


alter proc Sumdata @x int=200,@y int=100
as
	select @x+@y


Sumdata  3,8   --passing Parameters by Position

Sumdata @y=7,@x=10  --passing Parameters by Name

Sumdata 3

Sumdata

create proc GetCourse @duration int
as
	select crs_id,crs_name
	from course
	where crs_duration>@duration

declare @t table(x int,y varchar(20))
insert into @t
execute GetCourse 50
select count(*) from @t

insert into t2(crs_id,crs_name)
execute  GetCourse 50


alter proc GetData @id int
as
	declare @age int
		select @age=st_age
		from student
		where st_id=@id
	return @age


declare @x int
set @x= execute getData 4
select @x



alter proc GetData @id int ,@age int output ,@name varchar(20) output
as
		select @age=st_age,@name=st_fname
		from student
		where st_id=@id

declare @x int,@y varchar(20)
execute getData 2,@x output,@y output
select @x,@y

alter proc GetData @age int output ,@name varchar(20) output
as
		select @age=st_age,@name=st_fname
		from student
		where st_id=@age

declare @x int=2,@y varchar(20)
execute getData @x output,@y output
select @x,@y


create proc GetAll @col varchar(20),@t varchar(20)
as
	execute('select '+@col+'  from '+@t)


GetAll '*','instructor'
----------------------------------------------------------
---------------------------------------------------------
--3 types SP
--Builtin SP
	Sp_bindrule
	sp_helptext
	sp_rename
	sp_helpconstraint
	sp_addtype
	sp_bindefault
--User Defined
	GetSt
	GetstByID
	Sumdata
--Trigger
	--Can't Call
	--Can't Send parameter
	--Trigger Table   [Insert Update delete]

insert into student(st_id,st_fname)
values(432,'ahmed')

create trigger t10
on student
after insert
as
	select 'welcome to ITI'


update student
	set st_age+=1

create trigger t11
on student
after update
as
	select suser_name(),getdate()


create trigger t12
on course
instead of update
as
	select 'not allowed'

update course 
	set crs_name='DB'
where crs_id=100


create trigger t13
on department
instead of insert,update,delete
as
	select 'Not allowed For User= '+suser_name()

update Department
	set Dept_Manager=4
where Dept_Name='SD'

create trigger t14
on course
after update
as
	if update(crs_name)
		select 'welcome to ITI'


update course
	set crs_name='DB'
where Crs_id=100



create trigger t13
on department
instead of insert,update,delete
as
	select 'Not allowed For User= '+suser_name()

drop trigger t13

alter table department disable trigger t13
alter table department enable trigger t13
----------------------------------------------
--------------------------------------------
create trigger t15
on department
after update
as
	Select * from inserted
	Select * from deleted


update Department
	set dept_name='Cloud',Dept_Manager=3
where dept_id=30



create trigger t16
on Course
after update
as
	Select crs_name from deleted


update course set crs_name='MVC'
	where crs_id=400


create trigger t17
on student
instead of delete
as
	if format(getdate(),'dddd')='friday'
		select 'not allowed'
	else
		delete from student where st_id =(select st_id from deleted)



create trigger t17
on student
after delete
as
	if format(getdate(),'dddd')='friday'
		rollback


Create Table history
(
_user varchar(20),
_date date,
_old int,
_New int
)


create trigger t20
on topic
instead of update
as
	if update(top_id)
		begin
			declare @old int,@new int
			select @old=top_id from deleted
			select @new=top_id from inserted
			insert into history
			values(suser_name(),getdate(),@old,@new)
		end
------------------------------------------------
------------------------------------------------

insert into student(st_id,st_fname)
output getdate(),suser_name()
values(3133,'ali')

insert into student(st_id,st_fname)
values(133,'ali')

update student
	set st_fname='omar'
output deleted.st_fname
where st_id=7


delete from student
output deleted.*
where st_id=99

-------------------------------------------------
---------------------------------------

backup database ITI
to Disk='d:\myITI.bak'

--SP
--Trigger
--backup
--jobs




