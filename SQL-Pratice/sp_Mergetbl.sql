DECLARE @x VARCHAR(50), @y VARCHAR(50), @c VARCHAR(50), @p VARCHAR(50), @t VARCHAR(15)
DECLARE @ctr INT = 1, @ctrlimit INT
DECLARE @idx INT 

-- Get the total count of records in MyTable
SELECT @ctrlimit = COUNT(*) FROM MyTable

-- Loop through each record in MyTable
WHILE (@ctr <= @ctrlimit)
BEGIN
    -- Get the values from MyTable based on the current counter
    SELECT 
        @x = FirstName,
        @y = LastName,
        @c = City,
        @p = Country,
        @t = Phone
    FROM MyTable 
    WHERE ID = @ctr

    -- Check if the FirstName already exists in Customer table
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE FirstName = @x)
    BEGIN
        -- If not exists, insert the record into Customer table
        EXEC [dbo].[sp_InsertCustomer]  @x,@y,@c,@p,@t
    END

    -- Increment the counter
    SET @ctr += 1


declare @result bit = 0
select @result = 1 from customer where FirstName = @x
END

