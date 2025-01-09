create proc studentData
as
select * from student


create procedure GetStudentByAge @age1 int,@age2 int
as
select * from Student
where St_Age between @age1 and @age2

StudentPerAges 20,30


create procedure studentPerDepartmentid @deptid int
as
select * from Student
where Dept_Id=@deptid

create procedure studentPerDepartmentname @dname varchar(50)
as
select s.* from Student s,Department d
where s.Dept_Id=d.Dept_Id and d.Dept_Name=@dname 


use testing

create table sales
(
ProductID int,
SalesmanName varchar(10),
Quantity int
)

insert into sales
values  (1,'ahmed',10),
		(1,'khalid',20),
		(1,'ali',45),
		(2,'ahmed',15),
		(2,'khalid',30),
		(2,'ali',20),
		(3,'ahmed',30),
		(4,'ali',80),
		(1,'ahmed',25),
		(1,'khalid',10),
		(1,'ali',100),
		(2,'ahmed',55),
		(2,'khalid',40),
		(2,'ali',70),
		(3,'ahmed',30),
		(4,'ali',90),
		(3,'khalid',30),
		(4,'khalid',90)
		
select ProductID,SalesmanName,quantity
from sales

SELECT Sales.SalesOrderDetail.LineTotal, Production.ProductCategory.Name, YEAR(Sales.SalesOrderHeader.OrderDate) AS OrderYear
FROM   Production.Product INNER JOIN
             Sales.SalesOrderDetail ON Production.Product.ProductID = Sales.SalesOrderDetail.ProductID INNER JOIN
             Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID AND Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN
             Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID AND Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN
             Sales.SalesOrderHeader ON Sales.SalesOrderDetail.SalesOrderID = Sales.SalesOrderHeader.SalesOrderID AND Sales.SalesOrderDetail.SalesOrderID = Sales.SalesOrderHeader.SalesOrderID AND Sales.SalesOrderDetail.SalesOrderID = Sales.SalesOrderHeader.SalesOrderID

