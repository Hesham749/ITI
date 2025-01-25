use ExaminationSystem


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


-- question exam

ALTER TRIGGER trg_ExamQuestionInsteadOfInsert
ON ExamQuestions
INSTEAD OF INSERT
AS
 BEGIN
DECLARE  @QuesID INT , @ExamID INT ,@QuesCount int = NULL, @quesCrs INT , @QesMark INT

SELECT  @QuesID = i.QuestionID , @ExamID = i.ExamID  FROM inserted AS i
SELECT @quesCrs = CrsID , @QesMark = Mark FROM question WHERE ID = @QuesID
SELECT @QuesCount = e.QuestionCount FROM exam as e WHERE e.CrsID = @QuesCrs AND ID = @ExamID
IF  ( @QuesCount IS NOT NULL)
    BEGIN
        IF (SELECT COUNT(*) FROM ExamQuestions WHERE ExamID = @ExamID) < @QuesCount
        BEGIN
            BEGIN TRY
                BEGIN TRANSACTION
                    INSERT INTO ExamQuestions(ExamID , QuestionID)
                        VALUES (@ExamID, @QuesID)

                            UPDATE Exam
                            SET TotalMark += @QesMark
                            WHERE ID = @ExamID
                        COMMIT TRANSACTION
            END TRY
            BEGIN CATCH
                ROLLBACK TRANSACTION
                print 'operation failed'
            END CATCH
        END
        ELSE
        RAISERROR('exam questions is full',12,1)
    END
ELSE
RAISERROR('operation failed',12,1)

END;


ALTER TRIGGER trg_ExamQuestionAfterUpdate
ON ExamQuestions
    After UPDATE
AS
BEGIN
    DECLARE  @QuesID INT , @ExamID INT , @QuesCrs INT , @QuesMark INT , @NewQuesID INT , @NewExamID INT , @NewQuesMark INT
    SELECT   @ExamID = ExamID , @QuesID = QuestionID  FROM deleted AS e
    SELECT  @NewQuesID = i.QuestionID , @NewExamID = ExamID FROM inserted AS i
    SELECT @QuesCrs = CrsID , @NewQuesMark = Mark FROM question WHERE ID = @NewQuesID
     IF @ExamID != @NewExamID
            BEGIN
                    UPDATE ExamQuestions
                    Set ExamID = @ExamID, QuestionID = @QuesID
                        WHERE ExamID = @NewExamID AND QuestionID = @NewQuesID;
                 RAISERROR('You can not change Exam' ,16, 1)
            END
    ELSE IF NOT EXISTS(SELECT 1 FROM exam as e WHERE e.CrsID = @QuesCrs AND ID = @ExamID)
        BEGIN
                UPDATE ExamQuestions
                    Set ExamID = @ExamID, QuestionID = @QuesID
                        WHERE ExamID = @NewExamID AND QuestionID = @NewQuesID;
                 IF Exists(SELECT 1 FROM StudentExams WHERE ExamID = @ExamID)
                    BEGIN
                        RAISERROR('Exam already launched' ,16, 1)
                        RETURN ;
                    END
        END

    ELSE
     BEGIN
      SELECT  @QuesMark = Mark  FROM question WHERE ID = @QuesID
                    UPDATE Exam
                    SET TotalMark +=  (@NewQuesMark - @QuesMark )
                    where ID = @ExamID;
     END

END;