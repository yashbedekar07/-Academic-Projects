DECLARE @x VARCHAR(50), @y VARCHAR(50), @c vARCHAR(50), @p VARCHAR(50)
DECLARE @t VARCHAR(15)

DECLARE @ctr int = 1, @ctrlimit int = 1
--CREATE  Index idx 
--ON MyTable(ID,FirstName, LastName, City, Country, Phone)
DECLARE @idx INT 

--SELECT * FROM MyTable
--SELECT *FROM Customer
--DELETE FROM Customer WHERE Id >91

SELECT @ctrlimit = COUNT(*) FROM MyTable

WHILE(@ctr <= @ctrlimit)
BEGIN
        SELECT 
		@x = FirstName
		,@y = LastName
		,@c = City
		,@p = Country
		,@t = Phone
		FROM MyTable WHERE ID = @idx

		IF NOT EXISTS (SELECT FirstName FROM Customer WHERE FirstName = @x)
		BEGIN
		    EXEC [dbo].[sp_InsertCustomer]  @x,@y,@c,@p,@t
		END

       SELECT * FROM MyTable WHERE ID = @idx

SET @ctr += 1

END
-- Create a stored procedure to update customer information
--CREATE PROCEDURE UpdateCustomer
--    @CustomerID INT,
--    @FirstName VARCHAR(50),
--    @LastName VARCHAR(50),
--    @Email VARCHAR(100),
--    @Phone VARCHAR(20)
--AS
--BEGIN
--    UPDATE Customer
--    SET FirstName = @FirstName,
--        LastName = @LastName,
--        Email = @Email,
--        Phone = @Phone
--    WHERE CustomerID = @CustomerID;
--END;

-- Create a stored procedure to retrieve customer information by ID
--CREATE PROCEDURE GetCustomerByID
--    @CustomerID INT
--AS
--BEGIN
--    SELECT *
--    FROM Customer
--    WHERE CustomerID = @CustomerID;
--END;

-- Create a stored procedure to delete a customer by ID
--CREATE PROCEDURE DeleteCustomer
--    @CustomerID INT
--AS
--BEGIN
--    DELETE FROM Customer
--    WHERE CustomerID = @CustomerID;
--END;
