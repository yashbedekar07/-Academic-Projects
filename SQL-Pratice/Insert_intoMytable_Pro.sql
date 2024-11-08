CREATE PROCEDURE Insert_intoMytable
AS
BEGIN
INSERT INTO [dbo].[MyTable] (ID, FirstName, LastName, City, Country, Phone)
VALUES (11, 'Yash', 'Bedekar', 'Kolhapur', 'India', 7058249009);
END;

SELECT * FROM MyTable
EXEC Insert_intoMytable

