--Create DB _Code 
--default path
--C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\


CREATE DATABASE MyDB
ON 
(NAME=MyDB_data,
FILENAME = 'E:\MyDB_data.mdf'
)
LOG ON
(
NAME=MyDB_log,
FILENAME = 'E:\MyDB_Log.ldf'
)

CREATE DATABASE MyDB
ON 
(NAME=MyDB_data,
FILENAME = 'E:\MyDB_data.mdf',
size=10,
Maxsize=100,
filegrowth=5
)
LOG ON
(
NAME=MyDB_log,
FILENAME = 'E:\MyDB_Log.ldf'
)

CREATE DATABASE MyNewDB 
ON
PRIMARY --optional
( 
	NAME = Df1, 
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df1.mdf',
	SIZE = 3MB--at least 3 M
),
( 
	NAME = Df2, 
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df2.ndf',
	SIZE = 3MB
),
FILEGROUP SECONDARY_fg
( 
	NAME = Df3,
	FILENAME ='C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df3.ndf',
	SIZE = 1
),
( 
	NAME = Df4,
	FILENAME ='C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df4.ndf',
	SIZE = 1MB
)
LOG ON 
( 
	NAME = Log1,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\lg1.ldf', 
	SIZE = 1MB
)


--Alter db to add new filegroup
USE master;
ALTER DATABASE MyNewDB
ADD FILEGROUP FGNew
GO

-- alter db to make filegroup is the default
ALTER DATABASE MyNewDB 
  MODIFY FILEGROUP 
  SECONDARY_fg DEFAULT;
GO


--Alter db to add secondary file
ALTER DATABASE MyNewDB
ADD FILE
( 
	NAME = 'DFNew',
	FILENAME ='C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\DFNew.ndf',
	SIZE = 2MB,
	MAXSIZE=5,
	FILEGROWTH=1
)
TO FILEGROUP FGNew;				

