Select Store Procedure example
CREATE PROCEDURE Show_All_Students 
AS  
SELECT * FROM Student
GO; 

EXEC [dbo].[Show_All_Students];

CREATE PROCEDURE Student_edit
AS
BEGIN
INSERT INTO Student(Student_Name,Student_Course,Student_Age,Student_Marks)
VALUES('Aditya', 'MCA', 24, 88);
END

EXEC Student_edit

CREATE PROCEDURE Student_update
AS
BEGIN
UPDATE Student SET Student_Name = 'Kishu' WHERE Student_Name = 'Mohit' ;
END

EXEC Student_update



CREATE PROCEDURE Student_delete
AS
BEGIN
DELETE FROM Student WHERE Student_ID = 139;
END

EXEC Student_delete