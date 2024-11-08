CREATE TABLE Trainer (
    TrainerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender VARCHAR(20)NOT NULL,
    DateOfBirth DATE,
    PhoneNumber VARCHAR(20) NOT NULL,
    Email VARCHAR(100)NOT NULL,
    Address VARCHAR(255)NOT NULL,
    HireDate DATE,
    Salary DECIMAL(10, 2) NOT NULL,
    Specialization VARCHAR(100) NOT NULL,
    );


	CREATE TABLE [Member] (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender VARCHAR(20) NOT NULL,
    DateOfBirth DATE,
    PhoneNumber VARCHAR(20)NOT NULL,
    Email VARCHAR(100)NOT NULL,
    Address VARCHAR(255)NOT NULL,
	JoinDate DATE,
	TrainerID INT NOT NULL,
	CONSTRAINT fk_TrainerID FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID),
	  );