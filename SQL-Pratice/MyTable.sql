CREATE TABLE MyTable (
    ID INT PRIMARY KEY,
    FirstName VARCHAR(50),
	LastName VARCHAR(50),
    City VARCHAR(50),
    Country VARCHAR(50),
    Phone VARCHAR(15)
);

SELECT * FROM MyTable

INSERT INTO MyTable (ID, FirstName, LastName, City, Country, Phone)
VALUES
    (1, 'John', 'Doe', 'New York', 'USA', 3698521470),
    (2, 'Jane', 'Smith', 'London', 'UK', 1478523698),
    (3, 'Alice', 'Johnson', 'Paris', 'France', 0147523698),
    (4, 'Bob', 'Anderson', 'Berlin', 'Germany', 0258941367),
    (5, 'Eva', 'Martinez', 'Madrid', 'Spain', 3021456987),
    (6, 'David', 'Kim', 'Seoul', 'South Korea', 3021458796),
    (7, 'Maria', 'Garcia', 'Mexico City', 'Mexico', 3021548796),
    (8, 'Chris', 'Taylor', 'Sydney', 'Australia', 3698754120),
    (9, 'Ahmed', 'Ali', 'Cairo', 'Egypt', 9871230548),
    (10, 'Marta', 'Oliveira', 'Lisbon', 'Portugal', 0215478963);