USE ITI

--1
CREATE FUNCTION GetMonthName(@d DATE)
RETURNS VARCHAR(20)
BEGIN
    RETURN ( SELECT
        FORMAT( @d,'MMM'))

END

SELECT
    dbo.GetMonthName(GETDATE())


--2

CREATE FUNCTION GetValuesBetween(@s INT , @e INT )
RETURNS @t TABLE
(
    value INT
)
AS
BEGIN
    SELECT
        @s+=1
    WHILE @s < @e
BEGIN
        INSERT INTO @t
        VALUES(@s)
        SELECT
            @s+=1
    END
    RETURN
END

SELECT
    *
FROM
    GetValuesBetween(1,5)


--3
CREATE FUNCTION GetStdAndDep(@id INT )
RETURNS TABLE
AS
RETURN
(
    SELECT
    CONCAT(s.St_Fname,' ',s.St_Lname) AS [Full Name],
    d.Dept_Name
FROM
    Student AS s JOIN Department AS d
    ON s.Dept_Id = d.Dept_Id AND s.St_Id = @id
)

SELECT
    *
FROM
    GetStdAndDep(1)


--4

CREATE FUNCTION CheckNameNull(@id INT)
RETURNS VARCHAR(100)
BEGIN
    RETURN(
        SELECT
        CASE
        WHEN s.St_Fname IS NULL AND s.St_Lname IS NULL THEN 'First name & last name are null'
        WHEN s.St_Fname IS NULL THEN 'first name is null'
        WHEN s.St_Lname IS NULL THEN 'last name is null'
        ELSE 'First name & last name are not null'
        END
        AS Result
    FROM
        Student AS s
    WHERE s.St_Id = @id

)
END

SELECT
    dbo.CheckNameNull(13)

--5
CREATE FUNCTION GetDeptByManager(@id INT)
RETURNS TABLE
AS
RETURN (
    SELECT
    d.Dept_Name ,
    i.Ins_Name AS [Manager Name] ,
    d.Manager_hiredate
FROM
    Department AS d JOIN Instructor AS i
    ON d.Dept_Manager = i.Ins_Id AND d.Dept_Manager = @id
)

SELECT
    *
FROM
    GetDeptByManager(10)


--6
CREATE FUNCTION GetName(@n VARCHAR(15))
RETURNS @t TABLE (
    name NVARCHAR(30)
)
AS
BEGIN

    IF @n = 'first name'
        BEGIN
        INSERT
        INTO @t
        SELECT
            ISNULL
        (s.St_Fname,'')
        FROM
            student AS  s
    END
ELSE
IF @n = 'last name'
    BEGIN
        INSERT
    INTO
@t
        SELECT
            ISNULL
        (s.St_Lname,'')
        FROM
            student AS  s
    END
    IF @n = 'full name'
    BEGIN
        INSERT
    INTO
@t
        SELECT
            CONCAT
(s.St_Lname , ' ',s.St_Lname) AS [Full name]
        FROM
            student AS  s
    END
    RETURN
END




SELECT
    *
FROM
    GetName('first name')






--7
SELECT
    SUBSTRING(s.St_Fname,1,len(s.St_Fname)-1)
FROM
    Student AS s


--8


DELETE  sc
FROM
    Stud_Course
AS sc
    JOIN Student AS s
    ON sc.St_Id = s.St_Id
    JOIN Department AS d
    ON d.Dept_Id = s.Dept_Id AND d.Dept_Name = 'SD'


--9

MERGE INTO [Last Transactions] AS t
USING [Daily Transactions] AS s
ON s.userid = t.userid
WHEN matched THEN
 UPDATE
 SET t.userid = s.userid
WHEN NOT matched THEN
INSERT
VALUES
    (s.userid, s.tamount)
;

--10
CREATE SCHEMA st

ALTER SCHEMA st transfer student
 GO
ALTER SCHEMA st transfer course

update st.student
SET st_Age
=3
