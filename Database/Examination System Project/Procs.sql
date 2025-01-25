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

-- CREATE PROC sp_InsertQuestion
-- @Body VARCHAR(150),
-- @Mark TINYINT ,
-- @CorrectAnswer TINYINT ,
-- @CrsID int ,
-- @TypeID int ,
-- @InsID  int
-- AS
-- BEGIN

--  BEGIN TRY
--         BEGIN TRANSACTION;

--         INSERT INTO Question (Body, Mark, CorrectAnswer, CrsID, TypeID, InsID)
--         VALUES ( @Body, @Mark, @CorrectAnswer, @CrsID, @TypeID, @InsID);

--         COMMIT TRANSACTION;
--     END TRY
--     BEGIN CATCH
--         ROLLBACK TRANSACTION;
--         PRINT 'question did not insert';
--     END CATCH

-- END;


-- drop PROC sp_UpdateQuestion
-- @ID int ,
-- @Body VARCHAR(150) = NULL,
-- @Mark TINYINT  = NULL ,
-- @CorrectAnswer TINYINT  = NULL ,
-- @TypeID int  = NULL ,
-- @CrsID int  = NULL ,
-- @InsID  int = NULL
-- AS
-- BEGIN

--  BEGIN TRY
--         BEGIN TRANSACTION;
--       UPDATE question
--         SET
--          Body = ISNULL(@Body,Body),
--          Mark = ISNULL(@Mark,Mark),
--          CorrectAnswer = ISNULL(@CorrectAnswer,CorrectAnswer),
--          TypeID = ISNULL(@TypeID,TypeID),
--          CrsID = ISNULL(@CrsID,CrsID),
--          InsID = ISNULL(@InsID,InsID)
--          WHERE ID = @ID

--         COMMIT TRANSACTION;
--     END TRY
--     BEGIN CATCH
--         ROLLBACK TRANSACTION;
--         PRINT 'question did not insert';
--     END CATCH

-- END;

-- GO

CREATE TRIGGER trg_InsteadOfInsert
ON question
INSTEAD OF INSERT
AS
 BEGIN
DECLARE  @CrsID INT , @InsID  INT

SELECT  @CrsID = i.CrsID , @InsID = i.InsID  FROM inserted AS i

IF Exists (SELECT ci.CrsID FROM CoursesInstructors AS ci WHERE ci.CrsID = @CrsID AND ci.InsID = @InsID )
    BEGIN
        INSERT INTO question(Body, Mark,CorrectAnswer,TypeID , CrsID , InsID)
        SELECT Body, Mark,CorrectAnswer,TypeID , CrsID , InsID FROM inserted
    END
ELSE
RAISERROR('operation failed',12,1)

END;


CREATE TRIGGER trg_AfterUpdate
ON question
After UPDATE
AS
 BEGIN
DECLARE  @ID INT , @CrsID INT , @InsID  INT
 IF UPDATE(CrsID) OR  UPDATE(InsID)
    BEGIN
        SELECT  @ID = ID , @InsID = InsID ,  @CrsID = CrsID   FROM inserted
        IF NOT  Exists (SELECT ci.CrsID FROM CoursesInstructors AS ci WHERE ci.CrsID = @CrsID AND ci.InsID = @InsID )
            BEGIN
               SELECT @CrsID = CrsID , @InsID = InsID  FROM deleted ;
                UPDATE question
                SET CrsID = @CrsID , InsID = @InsID
                WHERE ID =@ID
            END
            ELSE
                RAISERROR('operation failed',12,1)
    END


END;



CREATE TRIGGER trg_AfterInsertCorrectAnswer
ON question
After INSERT
AS
 BEGIN
    DECLARE  @ID INT , @CorrectAnswer INT
     SELECT @ID = ID , @CorrectAnswer = CorrectAnswer FROM inserted
        IF NOT  Exists (SELECT qa.OptionNum FROM QuestionOptions AS qa WHERE qa.OptionNum = @CorrectAnswer AND qa.QuestionID = @ID )
            BEGIN
                SET @CorrectAnswer = NULL ;
                UPDATE question
                SET CorrectAnswer = @CorrectAnswer
                WHERE ID =@ID
            END
            ELSE
            print 'correct answer st to NULL';
END;



create TRIGGER trg_AfterUpdateCorrectAnswer
ON question
After UPDATE
AS
 BEGIN
    DECLARE  @ID INT , @CorrectAnswer INT
     SELECT @ID = ID , @CorrectAnswer = CorrectAnswer FROM inserted

 IF UPDATE(CorrectAnswer)
    BEGIN
        IF NOT  Exists (SELECT qa.OptionNum FROM QuestionOptions AS qa WHERE qa.OptionNum = @CorrectAnswer AND qa.QuestionID = @ID )
            BEGIN
                     SELECT @CorrectAnswer = CorrectAnswer FROM deleted ;
                UPDATE question
                SET CorrectAnswer = @CorrectAnswer
                WHERE ID =@ID
            END
        ELSE
            print 'your input is not exist in question options';
    END

END;