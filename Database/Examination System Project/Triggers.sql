use ExaminationSystem


--! question

--* insert

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

--* update

ALTER TRIGGER trg_QuestionAfterUpdate
ON question
After UPDATE
AS
 BEGIN
    DECLARE  @ID INT , @CrsID INT , @InsID  INT

        SELECT  @ID = ID , @InsID = InsID ,  @CrsID = CrsID   FROM inserted
        IF Exists (SELECT 1 FROM ExamQuestions AS ea WHERE ea.QuestionID = @ID )
            BEGIN
                SELECT @CrsID = CrsID , @InsID = InsID  FROM deleted ;
                    UPDATE question
                    SET CrsID = @CrsID , InsID = @InsID
                    WHERE ID =@ID
                RAISERROR('not allowed to update question that already in students exams',14,1)
            END
        ELSE IF UPDATE(CrsID) OR  UPDATE(InsID)
            BEGIN
                IF NOT  Exists (SELECT ci.CrsID FROM CoursesInstructors AS ci WHERE ci.CrsID = @CrsID AND ci.InsID = @InsID )
                    BEGIN
                        SELECT @CrsID = CrsID , @InsID = InsID  FROM deleted ;
                            UPDATE question
                            SET CrsID = @CrsID , InsID = @InsID
                            WHERE ID =@ID
                    END
                    ELSE
                        RAISERROR('operation failed',13,1)
            END
END;

--! correct answer

--* insert

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

--* update

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


--! question exam


--* insert

ALTER TRIGGER trg_ExamQuestionInsteadOfInsert
ON ExamQuestions
INSTEAD OF INSERT
AS
 BEGIN
DECLARE  @QuesID INT , @ExamID INT ,@QuesCount int = NULL, @quesCrs INT , @QesMark INT , @HasOption BINARY

SELECT  @QuesID = i.QuestionID , @ExamID = i.ExamID  FROM inserted AS i
SELECT @quesCrs = CrsID , @QesMark = Mark FROM question WHERE ID = @QuesID
SELECT @QuesCount = e.QuestionCount FROM exam as e WHERE e.CrsID = @QuesCrs AND ID = @ExamID
 set @HasOption = IIF( exists(select 1 FROM QuestionOptions WHERE QuestionID = @QuesID) , 1 , 0)
IF  ( @QuesCount IS NOT NULL)
    BEGIN
        IF (SELECT COUNT(*) FROM ExamQuestions WHERE ExamID = @ExamID) < @QuesCount AND  @HasOption = 1
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
        ELSE IF @HasOption = 0
            RAISERROR('Question does not have options',12,1)
        ELSE
            RAISERROR('exam questions is full',12,1)
    END
ELSE
RAISERROR('operation failed',12,1)

END;

--* update

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


--! StudentsExamsAnswers

--* insert

CREATE TRIGGER trg_StudentsExamsAnswersAfterInsert
ON StudentsExamsAnswers
After INSERT
AS
BEGIN
    DECLARE @stdID INT , @QuesID INT , @ExamID INT , @StdAnswer INT , @AnswerGrade TINYINT
    select @stdID = StdID , @QuesID = QuestionID , @ExamID = ExamID , @StdAnswer = StdAnswer  FROM inserted
    IF NOT Exists(select 1 FROM StudentExams as se JOIN ExamQuestions as eq on eq.ExamID = se.ExamID AND  eq.ExamID = @ExamID  AND se.StdID = @stdID AND eq.QuestionID = @QuesID)
            OR NOT EXISTS(select 1 FROM QuestionOptions WHERE QuestionID = @QuesID AND OptionNum = @StdAnswer)
        BEGIN
            ROLLBACK
            RAISERROR('Wrong inputs',13,1)
            RETURN;
        END
    ELSE
        BEGIN
            SELECT @AnswerGrade = IIF(@StdAnswer = CorrectAnswer , Mark , 0) FROM question as q WHERE q.ID = @QuesID
            begin TRY
                BEGIN TRANSACTION
                    UPDATE StudentsExamsAnswers
                        SET AnswerGrade = @AnswerGrade
                        WHERE StdID = @stdID AND QuestionID = @QuesID AND ExamID = @ExamID ;

                    UPDATE StudentExams
                        SET Grade += @AnswerGrade
                        WHERE StdID = @stdID AND ExamID = @ExamID

                    COMMIT TRANSACTION
            end TRY
            BEGIN CATCH
                PRINT 'Operation Failed'
                ROLLBACK TRANSACTION
            END CATCH
        END

END;



--! Exam

--* insert

