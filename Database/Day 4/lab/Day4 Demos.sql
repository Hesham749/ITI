-- DQL

-- Display (Using Union Function)
--  The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--  And the male dependence that depends on Male Employee.

USE Company_SD

--1

    SELECT
        dp.Dependent_name ,
        dp.Sex
    FROM
        Dependent AS dp JOIN Employee AS e
        ON dp.ESSN = e.SSN AND dp.Sex = 'f' AND e.Sex = 'f'
UNION
    SELECT
        dp.Dependent_name ,
        dp.Sex
    FROM
        Dependent AS dp JOIN Employee AS e
        ON dp.ESSN = e.SSN AND dp.Sex = 'm' AND e.Sex = 'm'



-- For each project, list the project name and the total hours per week (for all employees) spent on that project.

--2

SELECT
    p.Pname ,
    SUM(wf.[Hours]) AS [total hours per week]
FROM
    Project AS p JOIN Works_for AS wf
    ON wf.Pno = p.Pnumber
GROUP BY p.Pname

-- Display the data of the department which has the smallest employee ID over all employees' ID.

--3

SELECT
    d.*
FROM
    Departments AS d JOIN Employee AS e
    ON e.Dno = d.Dnum
WHERE
 e.SSN =
(SELECT
    min(SSN)
FROM
    Employee)

-- For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

--4

SELECT
    d.Dname ,
    MAX(e.Salary) AS maxSalary ,
    MIN(e.Salary) AS  minSalary ,
    AVG(e.Salary) AS AVgSalary
FROM
    Departments AS d JOIN Employee AS e
    ON e.Dno = d.Dnum
GROUP BY d.Dname


-- List the last name of all managers who have no dependents.

--5

SELECT
    e.Lname
FROM
    Employee AS e JOIN Departments AS d
    ON d.MGRSSN = e.SSN
    LEFT JOIN Dependent AS dp
    ON dp.ESSN = e.SSN
WHERE dp.ESSN IS NULL

-- For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.

--6

SELECT
    d.Dnum ,
    d.Dname,
    COUNT(e.SSN) AS [number of employees]
FROM
    Departments AS d JOIN Employee AS e
    ON e.Dno = d.Dnum
GROUP BY d.Dnum , d.Dname
HAVING AVG(Salary) < (SELECT
    AVG(Salary)
FROM
    Employee)

-- Retrieve a list of employees names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.

--7

SELECT
    e.Fname ,
    e.Lname,
    p.Pname
FROM
    Employee AS e JOIN Works_for AS wf
    ON wf.ESSn = e.SSN
    JOIN Project AS p
    ON wf.Pno = p.Pnumber
ORDER BY e.Dno , e.Lname , e.Fname


-- Try to get the max 2 salaries using subquery

--8

    SELECT
        max(salary) AS [Max Salary]
    FROM
        Employee
UNION ALL
    SELECT
        max(Salary)
    FROM
        Employee
    WHERE Salary < (SELECT
        max(Salary)
    FROM
        Employee)


-- Get the full name of employees that is similar to any dependent name

--9

    SELECT
        CONCAT(ISNULL(e.Fname,''),' ' , ISNULL(e.Lname,'')) AS [full name]
    FROM
        Employee AS e
INTERSECT
    SELECT
        dp.Dependent_name
    FROM
        Dependent AS dp



-- Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.


-- 10


SELECT
    e.SSN ,
    e.Fname
FROM
    Employee AS e
WHERE
EXISTS
(SELECT
    dp.ESSN
FROM
    Dependent AS dp
WHERE e.SSN = dp.ESSN)



-- DML

-- In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'

--11

INSERT INTO Departments
    (Dname , Dnum ,MGRSSN,[MGRStart Date])
VALUES('DEPT IT', 100, 112233, '11-1-2006')


-- Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager)

-- First try to update her record in the department table
-- Update your record to be department 20 manager.
-- Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)

--12

BEGIN TRY
BEGIN TRANSACTION

UPDATE Departments
SET MGRSSN = 968574
WHERE Dnum = 100

UPDATE Departments
SET MGRSSN = 102672
WHERE Dnum =20

UPDATE Employee
SET Superssn = 102672
WHERE SSN = 102660

COMMIT
END TRY
BEGIN CATCH
ROLLBACK
SELECT
    ERROR_LINE() ,
    ERROR_MESSAGE()
END CATCH


-- Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
-- Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

--13

BEGIN TRY
    BEGIN TRANSACTION
        UPDATE Employee
        SET Superssn = 102672
        WHERE Superssn = 223344

        UPDATE Departments
        SET MGRSSN = 102672
        WHERE = 223344

        UPDATE Works_for
        SET ESSn = 102672
        WHERE ESSn = 223344

        DELETE Employee
        WHERE SSN = 223344

        COMMIT
END TRY

BEGIN CATCH

    ROLLBACK
    SELECT
    ERROR_LINE() ,
    ERROR_MESSAGE()
END catch


-- Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%

-- 14

UPDATE e
SET e.Salary *= 1.30
FROM
    Employee AS e JOIN Works_for AS wf
    ON wf.ESSn = e.SSN
    JOIN Project AS p
    ON wf.Pno = p.Pnumber AND p.Pname = 'Al Rabwah'