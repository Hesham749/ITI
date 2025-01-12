USE ITI


--1

CREATE PROC StdCountprc
AS
SELECT
    d.Dept_Name ,
    COUNT(*) AS [Student count]
FROM
    Department AS d
    JOIN Student AS s
    ON s.Dept_Id = d.Dept_Id
GROUP BY D.Dept_Name

StdCountprc

--2

USE CompanyDB

ALTER PROC empInP1Proc
AS
DECLARE @empCount INT
DECLARE @t TABLE (name NVARCHAR(100))

INSERT INTO
    @t

SELECT       CONCAT( [Human Resources].employee.fName, ' ' , [Human Resources].employee.lName)
FROM            [Human Resources].employee INNER JOIN
                         works_on ON [Human Resources].employee.ssn = works_on.ESSN INNER JOIN
                         Company.project ON works_on.PNo = Company.project.PNumber
WHERE        (Company.project.PName = 'p1')

SELECT * FROM @t

SELECT
    @empCount = COUNT(*)
FROM
    @t
IF(@empCount > 3)
    SELECT
    'The number of employees in the project p1 is 3 or more'
ELSE
BEGIN
    SELECT
        'The following employees work for the project p1'

    SELECT
        *
    FROM
        @t
END

empInP1Proc


--3

USE CompanyDB


CREATE PROC upProc
    @oEmpId INT ,
    @nEmpId INT ,
    @proNum INT
AS
UPDATE  wo
SET wo.ESSN = @nEmpId
FROM
    works_on AS wo
    WHERE wo.ESSN = @oEmpId AND wo.PNo = @proNum


--4
use CompanyDB


create TRIGGER t7
on company.project
after update
as
INSERT INTO audit
    SELECT d.pNumber, SUSER_NAME(), GETDATE(), d.budget, i.budget
    FROM deleted d
    JOIN inserted i ON d.pNumber = i.pNumber;




--5
USE ITI

CREATE TRIGGER t1
ON department
INSTEAD OF INSERT
AS
     SELECT
    'he can’t insert a new record in that table'



--6


USE CompanyDB

CREATE TRIGGER t2
ON [Human Resources].employee
instead OF INSERT
AS
    IF(FORMAT(GETDATE(),'MMM') != 'march')
    BEGIN
    INSERT INTO [Human Resources].employee
    SELECT
        *
    FROM
        inserted
END


--7

USE ITI


create TRIGGER t3
ON Student
after INSERT
AS
INSERT INTO std_audit
VALUES(SUSER_NAME(), GETDATE(), CONCAT( SUSER_NAME(),'insert new row with key = ',(SELECT st_id FROM inserted), ' in table Student'))



--8

CREATE TRIGGER t4
ON Student
instead of DELETE
AS
INSERT INTO std_audit
VALUES(SUSER_NAME(), GETDATE(), CONCAT(SUSER_NAME(),'try to delete row with key = ',(SELECT st_id FROM deleted), ' in table Student'))




--?part 2


--*1

-- trigger has no parameters  / --! sp has paramters
-- trigger calls automatically / --! sp can be called or execute
-- trigger has no return  / --! sp can has return but can only return int
-- trigger has inserted and deleted tables /  --!sp has not
-- trigger takes the tables schema and changes if it changes /  --!sp has it own schema no matter what the tables schema inside it

--*2

--func must have return / --! sp may not have proc
--func run the full exec cycle every time it called / --! sp run the full exec cycle only in the first call then it starts from the tree
-- func can be used in select statement directly and can use join with it  // --! sp can't be used in joins and select statement
-- func can't use dml / --! sp can use dml
-- func can't use dynamic queries   / --! sp can have dynamic queries


--*3

-- drop is ddl / --! delete is dml
-- drop delete the the data and the mete data // --! delete only deletes the data
-- can't use where clause with drop // --! can use where clause with delete

--*4

-- select retrive the data //  --! select into make a copy from table in a new table with meta data and data or meta data only based on the condition

--*5

-- ddl used to create , alter or drop data bases or schema or any db object
-- dml used to insert , update or  delete  in  the table (uses with  actual data)
-- dcl used to control the user permission (grant , revoke)
-- dql used to get the data

--*6
--table valued can't have if statement inside it


--*7
-- varchar(50) the max len is 50  // --! varchar(max) the max size is what user inputed first time

--*8
-- sql can be more than one with different permissions need to write the password // --! windows authentication doesn't need to have the password it is always have access to all data bases and tables and there is one windows authentication

--*9
-- view is logical table can't by dynamic table can't have parameters // --! inline function alaways return table that can by dynamic because it can have paramters make it more flexible


--*10
-- identity it is auto increment and you can't insert values in it's column it is alawys unique // --! unique constraint can insert in it's column but it can't be duplicated
