--XML

--The FOR XML clause is central to XML data retrieval in SQL Server 2005. This clause
--instructs the SQL Server query engine to return the data as an XML stream rather than
--as a rowset

--The FOR XML clause has four modes to control XML Formate:
--1)RAW
--Transforms each row in the result set into an XML element

select * from Student
for xml raw

select * from Student
for xml raw('Student')

select * from Student
for xml raw('Student'),ELEMENTS


select * from Student
for xml raw('Student'),ELEMENTS,ROOT


select * from Student
for xml raw('Student'),ELEMENTS,ROOT('STUDENTS')

--how to show null values in xml
select * from Student
for xml raw('Student'),ELEMENTS xsinil,ROOT('STUDENTS')

--RAW mode queries can include aggregated columns and GROUP BY clauses.
select * from Student
order by St_Address
for xml raw('Student'),ELEMENTS,ROOT('STUDENTS')

select St_Address,COUNT(st_id) from Student
group by St_Address
for xml raw('Student'),ELEMENTS,ROOT('STUDENTS')

--u can only present data as elemets or attributes
--using For XML Path is the solution for representing mixed "elemets and attributes"
--for each separate row

--JOIN problem
select t.Top_Id,Top_Name,Crs_Id,Crs_Name 
from Topic t,Course c
where t.Top_Id=c.Top_Id
order by t.top_id
for xml raw ('topic'),ELEMENTS

--should be nested topic includes courses
--using For XML Auto is the solution for this problem

--2)AUTO
--Returns query results in a simple, nested XML tree. Each table in the FROM clause 
--for which at least one column is listed in the SELECT clause is represented as an XML 
--element. The columns listed in the SELECT clause are mapped to the appropriate element attributes.
select Topic.Top_Id,Top_Name,Crs_Id,Crs_Name 
from Topic ,Course 
where topic.Top_Id=Course.Top_Id
for xml raw,elements

select * 
from Student as st
for xml auto

select * 
from Student 
for xml auto,elements

select * 
from Student 
for xml auto,elements,root('ALLstudents')

--Benifets of For XML Auto
--1)Each row returned by the query is represented by an XML element with the same name
--2)the child elements are collated correctly with their parent
--3)Each column in the result set is represented by an attribute, unless the ELEMENTS option is specified
	select Topic.Top_Id,Top_Name,Crs_Id,Crs_Name 
	from Topic ,Course 
	where topic.Top_Id=Course.Top_Id
	for xml auto,elements,root('Courses_Inside_Topics')

--4)PATH
--Provides a simpler way to mix elements and attributes, and to 
--introduce additional nesting for representing complex properties.
--Easier than Explicit mode

select st_id "@SID",
	   St_Fname "StudentName/FirstName",
	   St_Lname "StudentName/LastName",
	   St_Address "Address"	
from Student
for xml path('student')

select st_id "@StudentID",
	   St_Fname "StudentName/@FirstName",
	   St_Lname "StudentName/LastName",
	   St_Address "Address"	
from Student
for xml path('Student'),root('Students')
-------------------------------------------------------------------------------------
--XML Shredding
--The process of transforming XML data to a rowset is known as “shredding” the XML data.

--Processing XML data as a rowset involves the following five steps:
--1)create proc processtree
declare @docs xml =
				'<Students>
				 <Student StudentID="1">
					<StudentName>
						<First>AHMED</First>
						<Second>ALI</Second>
					</StudentName>
					<Address>CAIRO</Address>
				</Student>
				<Student StudentID="2">
					<StudentName>
						<First>OMAR</First>
						<Second>SAAD</Second>
					</StudentName>
					<Address>ALEX</Address>
				</Student>
				</Students>'

--2)declare document handle
declare @handler int

--3)create memory tree
Exec sp_xml_preparedocument @handler output, @docs

--4)process document 'read tree from memory'
--OPENXML Creates Result set from XML Document

SELECT * 
FROM OPENXML (@handler, '//Student')  --levels  XPATH Code
WITH (StudentID int '@StudentID',
	  Address varchar(10) 'Address', 
	  StudentFirst varchar(10) 'StudentName/First',
	  StudentSECOND varchar(10) 'StudentName/Second'
	  )
--5)remove memory tree
Exec sp_xml_removedocument @handler
-----------------------------------------------------------------------------------
--XQuery
--Query language to indentify nodes in XML
--Query, Value, Exist, Modify and Nodes methods in XQuery
 CREATE TABLE customerData
 (
        customerDocs xml NOT NULL,
 ) 

INSERT INTO customerData(customerDocs)
       VALUES(N'<?xml version="1.0"?>
       <customers>
              <customer FirstName="Bob" LastName="Hayes" Zipcode="91126" status="current">
                     <order ID="12221" Date="July 1, 2006">Laptop</order>
              </customer>
              <customer FirstName="Judy" LastName="Amelia" Zipcode="23235" status="current">
                     <order ID="12221" Date="April 6, 2006">Workstation</order>
              </customer>
              <customer FirstName="Howard" LastName="Golf" Zipcode="20009" status="past due">
                     <order ID="3331122" Date="December 8, 2005">Laptop</order>
              </customer>
              <customer FirstName="Mary" LastName="Smith" Zipcode="12345" status="current">
                     <order ID="555555" Date="February 22, 2007">Server</order>
              </customer>
       </customers>')


Select customerDocs.query('/customers/customer')
from customerData 

Select customerDocs.query('(/customers/customer)[1]')
from customerData 

Select customerDocs.query('/customers/customer/order')
from customerData 

Select customerDocs.query('(/customers/customer/order)[1]')
from customerData
------------------------------------------------------------------------------------ 
 								/*Typed */

CREATE XML SCHEMA COLLECTION BookIndex
AS
N'<xs:schema attributeFormDefault="unqualified"
    elementFormDefault="qualified"
    xmlns:xs="http://www.w3.org/2001/XMLSchema">
    <xs:element name="index">
        <xs:complexType>
            <xs:sequence>
                <xs:element maxOccurs="unbounded" name="keyword">
                    <xs:complexType>
                        <xs:simpleContent>
                            <xs:extension base="xs:string">
                                <xs:attribute name="page" type="xs:int" use="required" />
                            </xs:extension>
                        </xs:simpleContent>
                    </xs:complexType>
                </xs:element>
            </xs:sequence>
        </xs:complexType>
    </xs:element>
</xs:schema>'


create table Books
(
	ISBN char(13) primary key not null,
	Title nvarchar(200) not null,
	BookIndex1 xml(dbo.BookIndex) 
)

Insert into dbo.Books
(ISBN,Title,BookIndex1)
VALUES
('1-59059-589-4','Vxxxxxxxxxxxxxx',
Cast('
<index>
    <keyword page="15">AppDomain</keyword>
    <keyword page="319">DataTable</keyword>
    <keyword page="328">DataSet</keyword>
    <keyword page="149">Encrypt</keyword>
    <keyword page="167">File IO</keyword>
    <keyword page="27">GAC</keyword>
    <keyword>Generics</keyword>

</index>' as XML) )

select * from dbo.Books

declare @xml xml(dbo.BookIndex)
set @xml ='<index>
    <keyword page="1">Chapter1</keyword>
    <keyword page="50">Chapter2</keyword>
    <keyword page="100">Chapter3</keyword>
    <keyword page="200">Chapter4</keyword>
    <keyword page="220">Chapter5</keyword>
    <keyword page="379">Chapter6</keyword>
    <keyword page="1919">Chapter7</keyword>
</index>' 
insert into dbo.Books
(ISBN,Title,BookIndex)
VALUES ('1-11111-111-1','SQL Server 2008',@xml)


-- FLWOR with LET operator
--Query language to indentify nodes in XML
--Statments
-------------
--1)for 
--Used to iterate through a group of nodes at the same level in an XML document.
--is like (select from) in sql

--2)where 
--Used to apply filtering criteria to the node iteration. XQuery includes
--functions such as count that can be used with the where statement.
--like where clause in sql

--3)return 
--Used to specify the XML returned from within an iteration.
--is like select in sql

--4)let is used for issignment

--5)order used for order by

-- FLWOR simple example

SELECT customerDocs.query('
       for $order in /customers/customer/order
        where $order/@ID >=555555
       return $order/text()')
FROM customerData


SELECT customerDocs.query('
       <CustomerOrders> {
       for $i in //customer
       let $name := concat($i/@FirstName, " ", $i/@LastName)
       order by $i/@LastName
       return
              <Customer Name="{$name}">
              {
              $i/order
              }
              </Customer>
       }
       </CustomerOrders>')
FROM customerData

drop table books

--HOW TO SHOW SCHEMA CONTENT
select XML_SCHEMA_NAMESPACE('dbo','BookIndex')

drop xml schema collection dbo.BookIndex

select name
from sys.XML_SCHEMA_COLLECTIONS
order by create_date

--CREATE PRIMARY XML INDEX idx_XML_Primary_Books_BookIndex
--ON dbo.Books(BookIndex)--need a clustered index in the table

