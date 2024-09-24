CREATE TABLE MembershipTypes (
    MembershipTypeID INT PRIMARY KEY IDENTITY(1,1),
    TypeName VARCHAR(50),
    Description VARCHAR(255),
    Price DECIMAL(10, 2)
);

CREATE TABLE Members (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    Gender VARCHAR(50),
    DateOfBirth DATETIME,
    JoinDate DATETIME,
    MembershipTypeID INT,
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(100),
    CONSTRAINT FK_MembershipType_Members FOREIGN KEY (MembershipTypeID) REFERENCES MembershipTypes(MembershipTypeID)
);

CREATE TABLE Trainers (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    Gender VARCHAR(50),
    DateOfBirth DATETIME,
    HireDate DATETIME,
    Specialization VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(100)
);

CREATE TABLE Classes (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Description VARCHAR(50),
    TrainerID INT,
    StartTime DATETIME,
    EndTime DATETIME,
    ClassDate DATETIME,
    CONSTRAINT FK_Classes_Trainers FOREIGN KEY (TrainerID) REFERENCES Trainers(ID)
);

CREATE TABLE Equipment (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Description VARCHAR(50),
    Quantity INT,
    PurchaseDate DATETIME,
    WarrantyExpirationDate DATETIME
);

CREATE TABLE Memberships (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MemberID INT,
    StartDate DATETIME,
    EndDate DATETIME,
    Amount DECIMAL(10, 2),
    PaymentStatus VARCHAR(20),
    CONSTRAINT FK_Memberships_Members FOREIGN KEY (MemberID) REFERENCES Members(ID)
);

CREATE TABLE Attendance (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MemberID INT,
    ClassID INT,
    AttendanceDate DATETIME,
    CONSTRAINT FK_Attendance_Members FOREIGN KEY (MemberID) REFERENCES Members(ID),
    CONSTRAINT FK_Attendance_Classes FOREIGN KEY (ClassID) REFERENCES Classes(ID)
);

-- Inserting 10 valid gym equipment data entries into the Equipment table
INSERT INTO Equipment (Name, Description, Quantity, PurchaseDate, WarrantyExpirationDate) VALUES
('Treadmill', 'Cardio equipment', 5, '2023-05-20 10:00:00', '2026-05-20 10:00:00'),
('Dumbbells', 'Free weights', 20, '2023-07-15 10:00:00', '2027-07-15 10:00:00'),
('Stationary Bike', 'Cardio equipment', 8, '2023-09-10 10:00:00', '2026-09-10 10:00:00'),
('Bench Press', 'Weightlifting equipment', 10, '2023-11-05 10:00:00', '2027-11-05 10:00:00'),
('Elliptical Machine', 'Cardio equipment', 6, '2023-12-20 10:00:00', '2026-12-20 10:00:00'),
('Kettlebells', 'Free weights', 15, '2024-02-25 10:00:00', '2028-02-25 10:00:00'),
('Rowing Machine', 'Cardio equipment', 4, '2024-04-15 10:00:00', '2027-04-15 10:00:00'),
('Leg Press Machine', 'Weightlifting equipment', 7, '2024-06-10 10:00:00', '2028-06-10 10:00:00'),
('Resistance Bands', 'Strength training equipment', 25, '2024-08-05 10:00:00', '2028-08-05 10:00:00'),
('Pull-up Bar', 'Bodyweight equipment', 12, '2024-10-20 10:00:00', '2028-10-20 10:00:00');

select * from Equipment;
select * from MembershipTypes;
select * from Trainers

INSERT INTO MembershipTypes (TypeName, Description, Price)
VALUES 
    ('Basic', 'Access to basic gym facilities', 50.00),
    ('Standard', 'Access to standard gym facilities with additional features', 75.00),
    ('Premium', 'Access to premium gym facilities with personalized training sessions', 100.00),
    ('Student', 'Discounted membership for students with valid student ID', 40.00),
    ('Senior', 'Discounted membership for seniors aged 65 and above', 45.00);

	INSERT INTO Members (Name, Gender, DateOfBirth, JoinDate, MembershipTypeID, Email, Phone, Address)
VALUES 
    ('John Doe', 'Male', '1990-05-15', '2023-01-10', 1, 'john.doe@example.com', '1234567890', '123 Main St'),
    ('Jane Smith', 'Female', '1985-09-20', '2022-12-01', 2, 'jane.smith@example.com', '9876543210', '456 Elm St'),
    ('Michael Johnson', 'Male', '1995-03-08', '2023-02-28', 3, 'michael.johnson@example.com', '5556667777', '789 Oak St'),
    ('Emily Brown', 'Female', '2000-11-12', '2023-03-15', 4, 'emily.brown@example.com', '4443332222', '101 Pine St'),
    ('David Wilson', 'Male', '1975-07-30', '2022-11-05', 5, 'david.wilson@example.com', '9998887777', '321 Cedar St');


INSERT INTO Trainers (Name, Gender, DateOfBirth, HireDate, Specialization, Email, Phone, Address)
VALUES 
    ('Alice Johnson', 'Female', '1988-04-20', '2020-05-10', 'Strength Training', 'alice.johnson@example.com', '1234567890', '123 Gym St'),
    ('Bob Smith', 'Male', '1985-11-15', '2019-08-05', 'Cardio', 'bob.smith@example.com', '9876543210', '456 Fitness Ave'),
    ('Charlie Brown', 'Male', '1990-08-30', '2021-03-20', 'Yoga', 'charlie.brown@example.com', '5556667777', '789 Health Blvd'),
    ('Diana Wilson', 'Female', '1995-02-10', '2018-12-15', 'CrossFit', 'diana.wilson@example.com', '4443332222', '101 Wellness Ln'),
    ('Eva Martinez', 'Female', '1992-06-25', '2022-01-10', 'Pilates', 'eva.martinez@example.com', '9998887777', '321 Exercise Rd');

	INSERT INTO Classes (Name, Description, TrainerID, StartTime, EndTime, ClassDate) 
VALUES 
('Yoga Class', 'Morning yoga session', 1, '2024-04-27 08:00:00', '2024-04-27 09:00:00', '2024-04-27'),
('Zumba Class', 'High-energy dance fitness', 2, '2024-04-27 10:00:00', '2024-04-27 11:00:00', '2024-04-27'),
('Pilates Class', 'Core strengthening exercises', 3, '2024-04-27 12:00:00', '2024-04-27 13:00:00', '2024-04-27'),
('Boxing Class', 'Cardio and strength training', 4, '2024-04-27 14:00:00', '2024-04-27 15:00:00', '2024-04-27'),
('Spinning Class', 'Indoor cycling workout', 5, '2024-04-27 16:00:00', '2024-04-27 17:00:00', '2024-04-27');