
CREATE DATABASE lab3
USE lab3

CREATE TABLE course
(
    cID      INT          IDENTITY PRIMARY KEY,
    cName    NVARCHAR(50) ,
    duration INT          UNIQUE
)
GO
CREATE TABLE instructor
(
    ID       INT           IDENTITY PRIMARY KEY,
    hireDate DATE          DEFAULT getDate(),
    Address  NVARCHAR(100),
    Salary   DEC(8,2)      DEFAULT 3000,
    overTime INT           UNIQUE,
    BD       DATE ,
    Fname    NVARCHAR(50),
    Lname    NVARCHAR(50),
    Age
    AS (datediff(YEAR,BD,getDate())),
    netSalary AS (isnull(Salary,0)+isnull(overTime,0)) PERSISTED ,
    CONSTRAINT c2 CHECK (Address IN
('cairo', 'alex')),
    CONSTRAINT c3 CHECK (Salary BETWEEN 1000 AND
    5000)

)
GO
CREATE TABLE teach
(
    insID INT FOREIGN KEY REFERENCES instructor(ID) ON DELETE CASCADE ON UPDATE CASCADE,
    cID   INT FOREIGN KEY REFERENCES course(cID) ON DELETE CASCADE ON UPDATE CASCADE,
    PRIMARY KEY (insID,cID)
)
GO
CREATE TABLE lab
(
    lID      INT          ,
    cID      INT           FOREIGN KEY REFERENCES course(cID) ON DELETE  CASCADE ON
    UPDATE CASCADE,
    location NVARCHAR(100),
    capacity INT,
    PRIMARY KEY
    (lID,cID),
    CONSTRAINT c1 CHECK (capacity < 20)

)
