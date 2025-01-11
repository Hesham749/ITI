USE ITI
--1
CREATE VIEW vSNameAndCourse
(
    [Full Name] ,
    [Course  name]
)
WITH
    ENCRYPTion
AS
    SELECT
        CONCAT(s.St_Fname , ' ', s.St_Lname) ,
        c.Crs_Name

    FROM
        Student AS s
        JOIN Stud_Course AS sc
        ON sc.St_Id = s.St_Id AND Grade > 50
        JOIN Course AS c ON c.Crs_Id = sc.Crs_Id
with CHECK OPTION


SELECT
    *
FROM
    vSNameAndCourse

--2

CREATE VIEW vManagerTopics
(
    [manager Name] ,
    [Topic  name]
)
WITH
    ENCRYPTion
AS
    SELECT
        i.Ins_Name,
        t.Top_Name

    FROM
        Instructor AS i JOIN Department AS d
        ON  d.Dept_Manager = i.Ins_Id
        JOIN Ins_Course AS ic
        ON ic.Ins_Id = i.Ins_Id
        JOIN Course AS c
        ON c.Crs_Id = ic.Crs_Id
        JOIN Topic AS t
        ON t.Top_Id = c.Top_Id

with CHECK OPTION

SELECT
    *
FROM
    vManagerTopics


--3

CREATE VIEW vInstructorDept
(
    [Instructor name],
    [Department name]
)
WITH
    encryption
AS
    SELECT
        i.Ins_Name,
        d.Dept_Name
    FROM
        Instructor AS i JOIN Department AS d
        ON i.Dept_Id = d.Dept_Id AND d.Dept_Name IN('sd','java')
    WITH CHECK OPTION


SELECT
    *
FROM
    vInstructorDept


--4
CREATE VIEW v1
WITH
    encryption
AS
    SELECT
        s.St_Fname ,
        s.St_Address
    FROM
        Student AS s
    WHERE s.St_Address IN ('alex','cairo')
    WITH CHECK OPTION



UPDATE V1 SET st_address='tanta'
WHERE st_address='alex';

--5

USE CompanyDB

CREATE VIEW vProjectEmpCount
(
    [project name],
    [number of employees]
)
WITH
    encryption
AS
    SELECT
        p.PName ,
        COUNT(e.ssn)
    FROM
        project AS p
        JOIN department AS d
        ON p.DNum = d.DNumber
        JOIN employee AS e
        ON e.dno = d.DNumber
    GROUP BY p.PName
        WITH CHECK OPTION


SELECT
    *
FROM
    vProjectEmpCount




--6

--a
CREATE SCHEMA Company
ALTER SCHEMA Company transfer Department

--b
CREATE SCHEMA [Human Resources]
ALTER SCHEMA [Human Resources] transfer Employee


--7
USE ITI



--! Cannot create more than one clustered index on table 'department'. Drop the existing clustered index 'PK_Department' before creating another.
CREATE CLUSTERED INDEX ix_hired ON department(manager_hiredate)

--8

--!The CREATE UNIQUE INDEX statement terminated because a duplicate key was found for the object name 'dbo.Student' and the index name 'uix_age2'. The duplicate key value is (3).
CREATE UNIQUE INDEX uix_age2 ON student(st_age)


--9
USE CompanyDB

Declare C1 Cursor
for select e.salary
  from [human resources].employee as e
for update     --update
declare @s decimal(8,2)
open C1
Fetch C1 into @s
while @@FETCH_STATUS=0
  begin
    if (@s <3000)
    BEGIN
    update [human resources].employee
    set salary *=1.1
    WHERE current of c1
    end
    else
    BEGIN
    update [human resources].employee
    set salary *=1.2
    WHERE current of c1
    end
    Fetch C1 into @s
  end
close C1
Deallocate C1b


-- 10

use iti


Declare C2 Cursor
for select i.Ins_Name , d.Dept_Name
  from Department as d
  JOIN Instructor as i
  on i.Ins_Id = d.Dept_Manager
for update     --update
declare @i NVARCHAR(30) , @d NVARCHAR(30)
open C2
Fetch C2 into @i ,@d
while @@FETCH_STATUS=0
  begin
    SELECT @i , @d
    Fetch C2 into @i , @d
  end
close C2
Deallocate C1b



--11

DECLARE c5 cursor
for
select i.Ins_Name from Instructor as i
declare @o NVARCHAR(300)='' , @s NVARCHAR(30)
OPEN c5
Fetch c5 into @s
WHILE @@FETCH_STATUS =0
begin
    SELECT @o =  CONCAT(@o,@s , ',')
 FETCH c5 into  @s
end
select SUBSTRING(@o,1,LEN(@o)-1)
close c5
DEALLOCATE c5
