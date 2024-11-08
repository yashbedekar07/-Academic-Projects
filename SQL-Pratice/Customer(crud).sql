CREATE TABLE Customers (
    CustomerId INT  IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(100)NOT NULL,
    Age VARCHAR(2) NOT NULL,
    Email VARCHAR(255)NOT NULL,
    Phone VARCHAR(20)NOT NULL,
    Address VARCHAR(255)NOT NULL,
    DateOfBirth Datetime DEFAULT(GETDATE())NOT NULL,
    City VARCHAR(100)NOT NULL,
    State VARCHAR(50)NOT NULL
);


SELECT * FROM Customers
--DROP TABLE Customers;