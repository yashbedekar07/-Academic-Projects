CREATE TABLE Users (
    ID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY,
    PatientName VARCHAR(50),
    DOB DATE NOT NULL,
    Gender NVARCHAR(10),
    ContactNumber NVARCHAR(15),
    Email NVARCHAR(50),
    Address NVARCHAR(255)
);

CREATE TABLE Casepapers (
    CasepaperID INT PRIMARY KEY IDENTITY,
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
    MobileNumber VARCHAR(15),
    RightEyeSPHDV VARCHAR(20),
    RightEyeSPHNV VARCHAR(20),
    RightEyeCYLDV VARCHAR(20),
    RightEyeCYLNV VARCHAR(20),
    RightEyeAXISDV VARCHAR(20),
    RightEyeAXISNV VARCHAR(20),
    LeftEyeSPHDV VARCHAR(20),
    LeftEyeSPHNV VARCHAR(20),
    LeftEyeCYLDV VARCHAR(20),
    LeftEyeCYLNV VARCHAR(20),
    LeftEyeAXISDV VARCHAR(20),
    LeftEyeAXISNV VARCHAR(20),
    FrameID INT FOREIGN KEY REFERENCES Frames(FrameID),
    GlassID INT FOREIGN KEY REFERENCES Glass(GlassID),
    FrameTypesID INT FOREIGN KEY REFERENCES FrameTypes(FrameTypesID),
    Remarks NVARCHAR(255),
    GlassTypesID INT FOREIGN KEY REFERENCES GlassTypes(GlassTypesID),
    CreatedDate DATETIME DEFAULT GETDATE(),
    Amount DECIMAL(10, 2)
);




CREATE TABLE Frames (
    FrameID INT PRIMARY KEY IDENTITY,
    FrameType NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255)
);
CREATE TABLE Glass (
    GlassID INT PRIMARY KEY IDENTITY,
    GlassType NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255)
);

CREATE TABLE FrameTypes (
    FrameTypesID INT PRIMARY KEY IDENTITY,
    FrameTypeName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255)
);
CREATE TABLE GlassTypes (
    GlassTypesID INT PRIMARY KEY IDENTITY,
    GlassTypeName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255)
);

