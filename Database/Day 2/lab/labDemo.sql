USE Company_SD


--1
SELECT
    *
FROM
    Employee

--2
SELECT
    e.Fname ,
    e.Lname ,
    e.Salary ,
    e.Dno
FROM
    Employee AS e


--3

SELECT
    p.Pname ,
    p.Plocation ,
    p.Dnum
FROM
    Project AS p


--4
SELECT
    e.Fname + ' ' + e.Lname AS [full name] ,
    salary,
    (e.Salary * 12) * .10 AS [ANNUL COMM]
FROM
    Employee AS e


--5
SELECT
    e.SSN ,
    e.Fname
FROM
    Employee AS e
WHERE Salary > 1000


--6

SELECT
    e.SSN ,
    e.Fname
FROM
    Employee AS e
WHERE (Salary*12) > 10000

--7

SELECT
    e.Fname ,
    e.Salary
FROM
    Employee AS e
WHERE e.Sex = 'F'


--8


SELECT
    d.Dnum ,
    d.Dname
FROM
    Departments AS d
WHERE d.MGRSSN = 968574


--9

SELECT
    p.Pnumber,
    p.Pname ,
    p.Plocation
FROM
    Project AS p
WHERE p.Dnum = 10