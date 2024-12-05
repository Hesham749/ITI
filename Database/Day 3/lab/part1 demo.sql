USE Company_SD

--1

SELECT
    d.Dnum ,
    d.Dname ,
    e.SSN ,
    e.Fname
FROM
    Departments AS d JOIN Employee AS e
    ON d.MGRSSN = e.SSN


--2

SELECT
    d.Dname ,
    p.Pname
FROM
    Departments AS d JOIN Project AS p
    ON p.Dnum = d.Dnum

--3

SELECT
    dp.* ,
    e.Fname
FROM
    Dependent AS dp JOIN Employee AS e
    ON dp.ESSN = e.SSN


--4

SELECT
    p.Pnumber ,
    p.Pname ,
    p.Plocation
FROM
    Project AS p
WHERE p.City IN ('alex','cairo')


--5

SELECT
    *
FROM
    Project AS p
WHERE p.Pname LIKE 'a%'

--6

SELECT
    *
FROM
    Employee AS e
WHERE e.Dno = 30 AND e.Salary BETWEEN 1000 AND 2000

--7

SELECT
    e.Fname
FROM
    Employee AS e JOIN Works_for  AS wf
    ON wf.ESSn = e.SSN AND e.Dno = 10 AND wf.[Hours] = 10
    JOIN Project AS p
    ON wf.Pno = p.Pnumber AND p.Pname = 'AL Rabwah'


--8

SELECT
    emp.Fname
FROM
    Employee AS emp JOIN Employee AS sv
    ON emp.Superssn = sv.SSN AND sv.Fname = 'kamel' AND sv.Lname = 'mohamed'


--9

SELECT
    e.Fname ,
    p.Pname
FROM
    Employee AS e JOIN Works_for AS wf
    ON wf.ESSn = e.SSN
    JOIN Project AS p
    ON wf.Pno = p.Pnumber
ORDER BY p.Pname


--10

SELECT
    p.Pnumber ,
    d.Dname ,
    e.Lname ,
    e.Address,
    e.Bdate

FROM
    Project AS p JOIN Departments AS d
    ON p.Dnum = d.Dnum AND p.City = 'cairo'
    JOIN Employee AS e
    ON d.MGRSSN = e.SSN

-- 11

SELECT
    e.*
FROM
    Employee AS e JOIN Departments AS d
    ON d.MGRSSN = e.SSN

--12

SELECT
    *
FROM
    Employee AS e LEFT JOIN Dependent AS dp
    ON dp.ESSN = e.SSN

--13

INSERT INTO Employee
    (Dno , SSN , Superssn ,Salary,Fname,Lname,Sex,Bdate,Address)
VALUES(30, 102672, 112233, 3000, 'Hesham', 'Elsayed', 'M', '8/10/1994', 'zzzzzzzzzzzzzzzzzz')

--14

INSERT INTO Employee
    (Dno , SSN ,Fname,Lname,Sex,Bdate,Address)
VALUES(30, 102660, 'karim', 'ali', 'M', '4/10/2002', 'xxxxxxxxxxxxxxx')


--15

UPDATE e
SET e.Salary *=1.20
FROM
    Employee AS e
WHERE SSN = 102672
