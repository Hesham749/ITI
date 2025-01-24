use ExaminationSystem

--Student

GO
CREATE PROCEDURE sp_InsertStudent
    @Fname NVARCHAR(30) ,
    @Lname NVARCHAR(30),
    @BD DATE,
    @Gender VARCHAR(1),
    @Email VARCHAR(50),
    @Password VARCHAR(10),
    @st NVARCHAR(50),
    @city VARCHAR(50),
    @Phone VARCHAR(13),
    @IntakeID INT,
    @TrackID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO Student (Fname, Lname, BD, Gender, Email, Password, st, city, Phone, IntakeID, TrackID)
        VALUES (@Fname, @Lname, @BD, @Gender, @Email, @Password, @st, @city, @Phone, @IntakeID, @TrackID);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Student did not insert' ;
    END CATCH
END;

GO

CREATE PROC sp_UpdateStudent
    @ID INT ,
    @Fname NVARCHAR(30) = NULL,
    @Lname NVARCHAR(30) =NULL,
    @BD DATE =NULL,
    @Gender VARCHAR(1) =NULL,
    @Email VARCHAR(50) =NULL,
    @Password VARCHAR(10) =NULL,
    @st NVARCHAR(50) =NULL,
    @city VARCHAR(50) =NULL,
    @Phone VARCHAR(13) =NULL,
    @IntakeID INT =NULL,
    @TrackID INT =NULL
    AS
    BEGIN

   BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE Student
        SET
         Fname = ISNULL(@Fname,Fname),
         Lname = ISNULL(@Lname,Lname),
         BD = ISNULL(@BD,BD),
         Gender = ISNULL(@Gender,Gender),
         Email = ISNULL(@Email,Email),
         Password = ISNULL(@Password,Password),
         St = ISNULL(@St,St),
         City = ISNULL(@City,City),
         Phone = ISNULL(@Phone,Phone),
         IntakeID = ISNULL(@IntakeID,IntakeID),
         TrackID = ISNULL(@TrackID,TrackID)
         WHERE ID = @ID

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Student did not Update' ;
    END CATCH

    END;

GO

CREATE PROC sp_DeleteStudent @ID int
AS
BEGIN
 BEGIN TRY
        BEGIN TRANSACTION;

        DELETE Student
         WHERE ID = @ID

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Student did not delete';
    END CATCH
END;

GO


-- question

CREATE PROC sp_InsertQuestion
@Body VARCHAR(150),
@Mark TINYINT ,
@CorrectAnswer TINYINT ,
@CrsID int ,
@TypeID int ,
@InsID  int
AS
BEGIN

 BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO Question (Body, Mark, CorrectAnswer, CrsID, TypeID, InsID)
        VALUES ( @Body, @Mark, @CorrectAnswer, @CrsID, @TypeID, @InsID);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'question did not insert';
    END CATCH

END;

GO

CREATE TRIGGER trg_InsteadofUpdOrInsert
ON question
INSTEAD OF INSERT , UPDATE
AS
 BEGIN
DECLARE @insertedCrs INT , @insertedIns INT

SELECT @insertedCrs = i.CrsID , @insertedIns = i.InsID  FROM inserted AS i

IF Exists (SELECT ci.CrsID FROM CoursesInstructors AS ci WHERE ci.CrsID = @insertedCrs AND ci.InsID = @insertedIns )
    BEGIN
    INSERT INTO question(Body, Mark,CorrectAnswer,TypeID , CrsID , InsID)
    SELECT Body, Mark,CorrectAnswer,TypeID , CrsID , InsID FROM inserted
    END
ELSE
RAISERROR('operation failed',12,1)

END;

