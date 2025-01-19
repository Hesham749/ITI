--SQL CLR stands for
--structured query Language + Common Langauage runtim [VS runtime engine]

--benefits of SQLCLR
--Scale Cabability of query language
--choose any .net language [C# f# Vb.net.....] 
--.net language has alot of features 
--[classes , DataS tructure , Regualar expressions , dealing with external files]
--better performance [VS runtime engine is faster]
--debugging features
--create new objects like [new data types & new aggregate functions]

--SQL server will responsible for:
--assembly loading
--Memory management
--security
--execution

--CLR will responsible for:
--validation
--type safty
--external files access

--CLR can create
--SP
--Trigger
--User defined Function
--user defined type      CLR Only
--Aggregate function     CLR Only

--data type Problem
--u will find builtin [deployed before] assembly named [Microsoft.SqlServer.Types]
------varchar(10)  nchar(10)--------- SQLstring  ----------------> String
------tinyint  smallint     --------- SQLint16   ----------------> int16
------binary varbinary      --------- SQLbinary  ----------------> byte

--SQLCLR disabled by default
--Enable
sp_configure 'clr_enable',1
go
reconfigure
go
sp_configure 'show advanced options',1
go
reconfigure
go
sp_configure 'clr strict security',0
go
reconfigure
go

--SqlCLR security

--Pipelines

--instead of deploy from vs
/* u will find it in programmability --->assemblies
select * from sys.assemblies
1-
create assembly database1
from 'E:\DB\Database1\Database1\bin\Debug\Database1.dll'
with permission_set=safe   --means can't restart service or change any of server properties
                           --unsafe --not recommended
						   --external access -- used in case of access external files or resources


CREATE TRIGGER [StudTrigger] ON student 
FOR update
AS EXTERNAL NAME [Database1].[Triggers].[StudentTrigger1];

--shoud by static and public in VS
CREATE FUNCTION [dbo].[Sum1](@x [smallint], @y [smallint])
RETURNS [smallint] WITH EXECUTE AS CALLER
AS 
EXTERNAL NAME [Database1].[UserDefinedFunctions].[Sum1]
GO

3-
--run function
select dbo.sum1(2,3)

*/


