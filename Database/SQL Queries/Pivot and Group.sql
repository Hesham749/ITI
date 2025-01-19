--rollup , cube  , grouping sets,  pivot,  unpivot

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

select SalesmanName as Name,sum(quantity) as Qty
from sales
group by SalesmanName
union
select 'Total Values',sum(quantity)
from sales





Select isnull(Name,'Total'),Qty
from ( 
select SalesmanName as Name,sum(quantity) as Qty
from sales
group by rollup(SalesmanName)
) as t


select SalesmanName as Name,sum(quantity) as Qty
from sales
group by rollup(SalesmanName)


select SalesmanName as Name,Count(quantity) as Qty
from sales
group by rollup(SalesmanName)
		

select ProductID,sum(quantity) as "Quantities"
from sales
group by rollup(ProductID)



select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by ProductID,SalesmanName


select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by rollup(ProductID,SalesmanName)

select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by ProductID,SalesmanName
union 
select sum(quantity),productid
from sales
group by productid
union 
select sum(quantity) from sales



select SalesmanName,ProductID,sum(quantity) as "Quantities"
from sales
group by rollup(salesmanName,ProductID)


select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by cube(ProductID,SalesmanName)



select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by Cube(ProductID,SalesmanName,branchid)


select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by cube(ProductID,SalesmanName)

--order by ProductID,SalesmanName


select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by cube(ProductID,SalesmanName)
--order by ProductID,SalesmanName

--grouping sets
select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by grouping sets(ProductID,SalesmanName)


select * from sales

----Pivot and Unpivot OLAP
--if u have the result of the previouse query
select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by SalesmanName,ProductID

SELECT * 
FROM sales 
PIVOT (sum(Quantity) FOR SalesmanName IN ([ahmed],[ali],[khalid])) as Pvt




SELECT *
FROM sales 
PIVOT (sum(Quantity) FOR productid IN ([1],[2],[3],[4])) as PVT
---advanced
--A-sum of columns
select * from (
SELECT 'total' as Prod,[SalesmanName] as sname,Quantity as Qty
FROM sales ) as newtable
PIVOT (sum(qty) FOR sname IN ([ahmed],[ali],[khalid])) as Pvt

--B union with old pivot
select *
from (SELECT Cast(ProductID as varchar(10)) as ProductID,salesmanname,quantity 
	  FROM sales) as tab1 
PIVOT (sum(Quantity) FOR SalesmanName IN ([ahmed],[ali],[khalid])) as Pvt1
union all
select * 
from (SELECT 'total' as Prod,[SalesmanName] as sname,Quantity as Qty
	  FROM sales) as tab2
PIVOT (sum(qty) FOR sname IN ([ahmed],[ali],[khalid])) as Pvt2

--CTE for sum all rows
with Pivotdata as(
select *
from (SELECT Cast(ProductID as varchar(10)) as ProductID,salesmanname,quantity 
	  FROM sales) as tab1 
PIVOT (sum(Quantity) FOR SalesmanName IN ([ahmed],[ali],[khalid])) as Pvt1
union all
select * 
from (SELECT 'total' as Prod,[SalesmanName],Quantity 
	  FROM sales) as tab2
PIVOT (sum(Quantity) FOR SalesManName IN ([ahmed],[ali],[khalid])) as Pvt2
)
select *,convert(int,isnull(ahmed,0))+convert(int,isnull(ali,0))+convert(int,isnull(khalid,0)) from Pivotdata

--with local var
declare @t table(x varchar(10),ahmed int,ali int,khalid int)
insert into @t
select *
from (SELECT Cast(ProductID as varchar(10)) as ProductID,salesmanname,quantity 
	  FROM sales) as tab1 
PIVOT (sum(Quantity) FOR SalesmanName IN ([ahmed],[ali],[khalid])) as Pvt1
union all
select * 
from (SELECT 'total' as Prod,[SalesmanName],Quantity 
	  FROM sales) as tab2
PIVOT (sum(Quantity) FOR SalesManName IN ([ahmed],[ali],[khalid])) as Pvt2

select *,convert(int,isnull(ahmed,0))+convert(int,isnull(ali,0))
+convert(int,isnull(khalid,0)) from @t





SELECT *
FROM sales 
PIVOT (SUM(Quantity) FOR SalesmanName IN (@all_names)) as PVT

select * from pivoting




Select * from newpivot


select * from newtable


--how to get the table
SELECT * FROM newtable 
UNPIVOT (qty FOR salesname IN ([Ahmed],[Khalid],[Ali])) UNPVT



execute('SELECT * FROM sales 
PIVOT(SUM(Quantity) FOR SalesmanName IN (p1))')

PVT


alter proc p1
as
select distinct(salesmanname)
from sales

p1


Index
cursor
View
Pivoting

