--Hierarchical Data (SQL Server)
--hierarchyID Datatype

--Example  [Geographical hierarchical data] 
--Planet   (Earth)
-------continent (Africa,Europe,Asia...)
----------------country (Egypt,Moraco,Southafrica.....)
------------------------------city (cairo ,alex , Mansoura .........
create table Geography_data  
(GLevel hierarchyid not null,  
GName nvarchar(30),  
GType nvarchar(9))
 
insert Geography_data  
values
-- root level data
('/', 'Earth', 'Planet')
-- first level data
,('/1/','Asia','Continent')
,('/2/','Africa','Continent')
,('/3/','Europe','Continent')

  -- second level data 
,('/1/1/','China','Country')
,('/1/2/','Japan','Country')
,('/1/3/','South Korea','Country')
,('/2/1/','South Africa','Country')
,('/2/2/','Egypt','Country')
,('/3/1/','France','Country')
 

-- third level data
,('/1/1/1/','Beijing','City')
,('/1/2/1/','Tokyo','City')
,('/1/3/1/','Seoul','City')
,('/2/1/1/','Pretoria','City')
,('/2/2/1/','Cairo','City')
,('/2/2/2/','Alex','City')
,('/2/2/3/','Mansoura','City')
,('/3/1/1/','Paris','City')
 

 
-- display without sort order returns 
-- rows in input order
select 
 Glevel
,GName
,Gtype  
from Geography_data

select 
 GLeveL.ToString() AS [Node Text]
,GLeveL.GetLevel() [Node Level]
,GName
,Gtype  
from Geography_data

--read tree from left to right
select 
 GLeveL.ToString() AS [NodeText]
,GLeveL.GetLevel() [NodeLevel]
,GName
,Gtype  
from Geography_data
order by [NodeText]
--display all cities
select Gname,Gtype
from (
	select 
	GLeveL.ToString() AS [NodeText]
	,GLeveL.GetLevel() [NodeLevel]
	,GName
	,Gtype  
	from Geography_data ) newtable
where Nodelevel=3


	select 
	GLeveL.ToString() AS [NodeText]
	,GLeveL.GetLevel() [NodeLevel]
	,GName
	,Gtype  
	from Geography_data 
 
 --delete root
 delete top(1) from Geography_data

 --add root with method
insert into Geography_data 
values(hierarchyid::GetRoot(),'Earth','Planet')


