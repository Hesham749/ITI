USE ITI

--1
SELECT
    COUNT(*) AS Count
FROM
    Student
WHERE St_Age IS NOT NULL

--2
SELECT
    DISTINCT
    i.Ins_Name
FROM
    Instructor AS i


--3

SELECT
    s.St_Id ,
    ISNULL(s.St_Fname,'') +' '+ ISNULL(s.St_Lname,'') AS [Student Full Name] ,
    ISNULL(d.Dept_Name,'') AS [Department name]
FROM
    Student
AS s
    LEFT JOIN Department AS d
    ON s.Dept_Id = d.Dept_Id

--4
SELECT
    i.Ins_Name ,
    ISNULL(d.Dept_Name,'')AS [Department Name]
FROM
    Instructor AS i LEFT JOIN Department AS d
    ON i.Dept_Id = d.Dept_Id

--5
SELECT
    CONCAT(s.St_Fname,' ',s.St_Lname) AS [Full Name] ,
    c.Crs_Name
FROM
    Student AS s JOIN Stud_Course AS sc
    ON s.St_Id = sc.St_Id AND sc.Grade IS NOT NULL
    JOIN Course AS c
    ON sc.Crs_Id = c.Crs_Id

--6
SELECT
    t.Top_Name ,
    count(*) AS [Number of Courses]
FROM
    Topic AS t JOIN Course AS c
    ON t.Top_Id = c.Top_Id
GROUP BY t.Top_Name


--7
SELECT
    MAX(i.Salary) AS [Max Salary],
    MIN(i.Salary) AS [Min Salary]
FROM
    Instructor AS i

--8
SELECT
    *
FROM
    Instructor AS i
WHERE i.Salary < (SELECT
    AVG(Salary)
FROM
    Instructor )


--9

SELECT
    d.Dept_Name
FROM
    Department AS d
    JOIN Instructor  AS i
    ON i.Dept_Id = d.Dept_Id AND i.Salary = (SELECT
            MIN(Salary)
        FROM
            Instructor)

--10

SELECT
    t1.Salary
FROM
    (
SELECT
        * ,
        ROW_NUMBER()OVER(ORDER BY i.Salary DESC) AS rn
    FROM
        Instructor AS i ) AS t1
WHERE rn <=2

--11
SELECT
    i.Ins_Name ,
    COALESCE(CONVERT(varchar , i.Salary),'Bouns') AS Salary
FROM
    Instructor AS i


--12
SELECT
    AVG(i.Salary)
FROM
    Instructor AS i


--13
SELECT
    s.St_Fname ,
    super.*
FROM
    Student AS s
    JOIN Student AS super
    ON s.St_super =  super.St_Id

--14
SELECT
    t1.Dept_Id ,
    t1.Salary
FROM
    (
SELECT
        * ,
        ROW_NUMBER()OVER(PARTITION BY i.Dept_Id ORDER BY i.Salary DESC) AS rn
    FROM
        Instructor AS i
    WHERE i.Salary IS NOT NULL
)AS t1
WHERE rn <=2

--15

SELECT
    t1.St_Id
    ,
    ISNULL(t1.St_Fname, t1.St_Lname) [Student Name]
FROM
    (
SELECT
        * ,
        ROW_NUMBER()OVER(PARTITION BY s.Dept_Id ORDER BY newid() DESC) AS rn
    FROM
        Student AS s
)AS t1
WHERE rn =1

--Part 2


--1
USE AdventureWorks2012

SELECT
    sod.SalesOrderID ,
    sod.ShipDate
FROM
    Sales.SalesOrderHeader AS sod
WHERE sod.OrderDate BETWEEN '7/28/2002' AND '7/29/2014'


--2
SELECT
    p.ProductID ,
    p.Name
FROM
    Production.Product AS p
WHERE p.StandardCost < 110


--3
SELECT
    p.ProductID
FROM
    Production.Product
AS p
WHERE p.Weight IS NOT NULL


--4
SELECT
    *
FROM
    Production.Product AS p
WHERE p.Color IN('silver','black','red')

--5
SELECT
    *
FROM
    Production.Product AS p
WHERE p.Name LIKE 'b%'

--6

UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

SELECT
    *
FROM
    Production.ProductDescription AS pd
WHERE pd.[Description] LIKE '%_%'


--7
SELECT
    sh.OrderDate,
    SUM(sh.TotalDue) AS TotalDue
FROM
    Sales.SalesOrderHeader AS sh
WHERE sh.OrderDate BETWEEN  '7/1/2001' and '7/31/2014'
GROUP BY sh.OrderDate
--8
SELECT
    DISTINCT
    e.HireDate
FROM
    HumanResources.Employee AS e

--9

SELECT
    AVG(DISTINCT p.ListPrice) Average
FROM
    Production.Product AS p

--10
SELECT
    'The '+ p.Name  + ' is only! ' +  CONVERT(NVARCHAR,p.ListPrice)
FROM
    Production.Product AS p
WHERE p.ListPrice BETWEEN 100 AND 120
ORDER BY p.ListPrice

--11
--a
SELECT
    *
INTO [store_Archive]
FROM
    (
SELECT
        s.rowguid ,
        s.Name ,
        s.SalesPersonID,
        s.Demographics
    FROM
        Sales.Store AS s ) AS

--b
SELECT
    TOP(0)
    *
INTO [store_Archive]
FROM
    (
SELECT
        s.rowguid ,
        s.Name ,
        s.SalesPersonID,
        s.Demographics
    FROM
        Sales.Store AS s ) AS

--12

    SELECT
        FORMAT(GETDATE(),'dd/MM/yyyy','en-us')
UNION ALL
    SELECT
        FORMAT(GETDATE(),'dd/MMM/yyyy','en-us')
UNION ALL
    SELECT
        FORMAT(GETDATE(),'MM/yyyy','en-us')
UNION ALL
    SELECT
        FORMAT(GETDATE(),'dddd/yyyy','en-us')
