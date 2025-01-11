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

DECLARE C1 CURSOR
FOR SELECT
    e.salary
FROM
    [human resources].employee AS e
FOR
UPDATE
--update
DECLARE @s DECIMAL(8,2)
OPEN C1
FETCH C1 INTO @s
WHILE @@FETCH_STATUS=0
  BEGIN
    IF (@s <3000)
    BEGIN
        UPDATE [human resources].employee
    SET salary *=1.1
    WHERE CURRENT OF c1
    END
    ELSE
    BEGIN
        UPDATE [human resources].employee
    SET salary *=1.2
    WHERE CURRENT OF c1
    END
    FETCH C1 INTO @s
END
CLOSE C1
DEALLOCATE C1b


-- 10

USE iti


DECLARE C2 CURSOR
FOR SELECT
    i.Ins_Name ,
    d.Dept_Name
FROM
    Department AS d
    JOIN Instructor AS i
    ON i.Ins_Id = d.Dept_Manager
FOR
UPDATE
--update
DECLARE @i NVARCHAR(30) , @d NVARCHAR(30)
OPEN C2
FETCH C2 INTO @i ,@d
WHILE @@FETCH_STATUS=0
  BEGIN
    SELECT
        @i ,
        @d
    FETCH C2 INTO @i , @d
END
CLOSE C2
DEALLOCATE C1b



--11

DECLARE c5 CURSOR
FOR
SELECT
    i.Ins_Name
FROM
    Instructor AS i
DECLARE @o NVARCHAR(300)='' , @s NVARCHAR(30)
OPEN c5
FETCH c5 INTO @s
WHILE @@FETCH_STATUS =0
BEGIN
    SELECT
        @o =  CONCAT(@o,@s , ',')
    FETCH c5 INTO  @s
END
SELECT
    SUBSTRING(@o,1,LEN(@o)-1)
CLOSE c5
DEALLOCATE c5
