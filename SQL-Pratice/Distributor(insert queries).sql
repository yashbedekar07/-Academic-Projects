--consignee insert query
SELECT * FROM Consignors
INSERT INTO Consignors ([Name], [Address], Code, GSTIN)
VALUES
('John Doe', '123 Main St, Cityville, USA', 'ABC123', '12ABCD3456E1Z7'),
('Jane Smith', '456 Elm St, Townsville, USA', 'DEF456', '34FGHI5678J2K9'),
('Michael Johnson', '789 Oak St, Villageton, USA', 'GHI789', '56LMNO9012P3Q4'),
('Emily Brown', '101 Pine St, Hamletown, USA', 'JKL101', '78RSTU3456V5W6'),
('David Lee', '202 Maple St, Countryside, USA', 'MNO202', '90XYZA5678B9C1');

--DealerTypes inert query
SELECT * FROM DealerTypes
INSERT INTO DealerTypes (Name)
VALUES 
    ('John Smith'),
    ('Alice Johnson'),
    ('Michael Brown'),
    ('Emily Davis'),
    ('Christopher Martinez');
--dealer insert query
SELECT * FROM Dealers
INSERT INTO dbo.Dealers ([Name], [Address], Code, GSTIN, DealerTypeID)
VALUES 
    ('Dealer 1', '123 Main Street', 'ABC123', '1234567890', 1), 
    ('Dealer 2', '456 Elm Street', 'DEF456', '0987654321', 2), 
    ('Dealer 3', '789 Oak Street', 'GHI789', '1357924680', 3), 
    ('Dealer 4', '101 Pine Street', 'JKL101', '2468013579', 4), 
    ('Dealer 5', '202 Maple Street', 'MNO202', '9876543210', 5);
	--('Dealer 6', '784 kolhapur', 'xyz212', '1234567890', 6);
	
--DespatchTypes inser query
SELECT * FROM DespatchTypes
INSERT INTO dbo.DespatchTypes ([Name])
VALUES 
    ('Courier'),
    ('Truck'),
    ('Air Freight'),
    ('Railway'),
    ('Ship');

--Destinations insert query
SELECT *FROM Destinations
INSERT INTO dbo.Destinations ([Name])
VALUES 
    ('New York'),
    ('London'),
    ('Tokyo'),
    ('Paris'),
    ('Sydney');

--Districts insert query
SELECT * FROM Districts
INSERT INTO dbo.Districts ([Name])
VALUES 
    ('Pune'),
    ('Mumbai'),
    ('Nagpur'),
    ('Nashik'),
    ('Thane'),
    ('Aurangabad'),
    ('Solapur'),
    ('Amravati'),
    ('Nanded'),
    ('Kolhapur'),
    ('Sangli'),
    ('Jalgaon'),
    ('Akola'),
    ('Latur'),
    ('Dhule'),
    ('Ahmednagar'),
    ('Chandrapur'),
    ('Parbhani'),
    ('Jalna'),
    ('Buldhana'),
    ('Yavatmal'),
    ('Satara'),
    ('Beed'),
    ('Osmanabad'),
    ('Nandurbar'),
    ('Ratnagiri'),
    ('Wardha'),
    ('Gadchiroli'),
    ('Hingoli');

-- Inserting records into Talukas table
SELECT * FROM Talukas
INSERT INTO dbo.Talukas ([Name], DistrictID)
VALUES 
    ('Karveer ', 10),  -- Kolhapur
    ('Panhala ', 10),  -- Kolhapur
    ('Shahuwadi ', 10),  -- Kolhapur
    ('Hatkanangale ', 10),  -- Kolhapur
    ('Miraj ', 10),  -- Kolhapur
    ('Kavathe Mahankal', 11),  -- Sangli
    ('Kupwad ', 11),  -- Sangli
    ('Jath ', 11),  -- Sangli
    ('Tasgaon ', 11),  -- Sangli
    ('Shirala', 11); -- Sangli
	--('Karveer', 30);--Fk not matched

-- Inserting records into Products table
SELECT * FROM Products
INSERT INTO dbo.Products (ProductName, CommodityCode, ProductCode, BagvsTon, Ton, CurrentStockBags, CurrentStockTons)
VALUES 
    ('Urea', 1001, 1001, 50, 1, 100, 100), -- Product code matches with Product name
    ('DAP', 1002, 1002, 50, 1, 150, 150),  -- Product code matches with Product name
    ('MOP', 1003, 1003, 50, 1, 200, 200),  -- Product code matches with Product name
    ('Potassium Nitrate', 1004, 1004, 50, 1, 120, 120),  -- Product code matches with Product name
    ('NPK', 1005, 1005, 50, 1, 180, 180);  -- Product code matches with Product name

--Inserting records into StationCodes table
SELECT * FROM StationCodes
INSERT INTO dbo.StationCodes (StationCode, Distance, StationName, StationNumber)
VALUES 
    ('KOL001', 10.5, 'Kolhapur Central', 1),
    ('KOL002', 15.2, 'Kolhapur South', 2),
    ('KOL003', 20.9, 'Kolhapur East', 3),
    ('KOL004', 25.6, 'Kolhapur West', 4),
    ('KOL005', 30.3, 'Kolhapur North', 5);

--Inserting records into Transports table
SELECT *FROM Transports
--DELETE FROM dbo.Transports
--WHERE ID > 0;

INSERT INTO dbo.Transports ([Name], [Address], Code, GSTIN)
VALUES 
    ('Neeta ', '123 Main Street, kolhapur , Maharashtra' , 'ABC001', '1234567890'),
    ('Shivshai ', '456 Elm Street, sangali , Maharashtra' ,  'DEF002', '2345678901'),
    ('Labiak ', '789 Oak Street, satara , Maharashtra',  'GHI003', '3456789012'),
    ('Konduskar ', '101 Pine Street, pune , Maharashtra' ,  'JKL004', '4567890123'),
    ('chota Hatthi ', '202 Maple Street, karad , Maharashtra' ,  'MNO005', '5678901234');

--INSERT INTO dbo.Subdealers
SELECT * FROM Subdealers
INSERT INTO dbo.Subdealers ([Name], [Address], Code, GSTIN, DealerId)
VALUES 
    ('Yash ', '123 Subdealer Street, Kolhapur A, Maharashtra', 'SUB001', '1234567890', 1), -- Assuming DealerId 1 exists in Dealers table
    ('Ayush ', '456 Subdealer Street, Kolhapur B, Maharashtra', 'SUB002', '2345678901', 2), -- Assuming DealerId 2 exists in Dealers table
    ('Karan ', '789 Subdealer Street, Sangli, Maharashtra', 'SUB003', '3456789012', 3), -- Assuming DealerId 3 exists in Dealers table
    ('Ashutosh ', '101 Subdealer Street, Karad, Maharashtra', 'SUB004', '4567890123', 4), -- Assuming DealerId 4 exists in Dealers table
    ('Omkar', '202 Subdealer Street,Kokan, Maharashtra', 'SUB005', '5678901234', 5); -- Assuming DealerId 5 exists in Dealers table
	--('Sayali', '203 Subdealer Street,Nigvae, Maharashtra', 'SUB006', '5678901234', 6); --  DealerId 6 Does not exists in Dealers table

--INSERT INTO dbo.RakeDetails
SELECT * FROM RakeDetails
INSERT INTO dbo.RakeDetails (
    RRNO, --12345
    RRDate, --2024-02-26
    FNR, --6789
    FromStationCodeId,--1 
    ProductID, --1
    NoOfWagons,--10 
    TotalWeight,--1000.00 
    Rate, --50
    SenderWeight, --500.00
    TotalChargableWeight, --400.00
    TotalArticles, --20
    FreightAmt, --800.00
    HSNCode, --1234
    WagonNo, --'ABC123
    CC, --12.5,
    Tare, --10.5
    NoOfBagsperRR, -- 5
    GrossWeight, --15.5,
    ActualWeight, --12
    PermissibleCC, --10.5
    ChargableWeight, --8.5
    TypeOfRake, -- Type A
    SpilageBags, --'11.5
    CutAndTornBags, --2
    Bag1Weight, --3
    Bag2Weight, --20
    Bag3Weight, --15
    Bag4Weight, --10
    Bag5Weight, --5
    Bag6Weight, --8
    Bag7Weight, --7
    Bag8Weight, --6
    Bag9Weight, --5
    Bag10Weight, --4
    MRP1, --200.00,
    MRP2, --250
    MRP3, --300
    CompletionDate,--24/02/28 
    ArrivalDate, --24/02/01
    NoOfBagsReceived--100
)
VALUES 
    --(12345, '2024-02-26', 6789, 1, 1, 10, 1000.00, 50, 500.00, 400.00, 20, 800.00, 1234, 'ABC123', 12.5, 10.5, 5, 15.5, 12, 10.5, 8.5, 'Type A',11.5, 2, 3, 20, 15, 10, 5, 8, 7, 6, 5, 4, 200.00, 250.00, 300.00, '2024-02-28', '2024-03-01', 100),
	(578, '2024-02-27', 0336, 2, 2, 20, 2000.00, 70, 700.00, 350.00, 30, 1000.00, 5678, 'xyz089', 13.5, 11.5, 7, 20, 15, 12,10, 'Type B', 7, 4, 2, 20, 10, 15, 10, 12, 13, 14, 17, 2,300.00, 350.00, 600.00, '2024-03-2', '2024-03-5',200);
 
 
---INSERT INTO dbo.DespatchDetails
SELECT * FROM DespatchDetails
INSERT INTO dbo.DespatchDetails (
    DispatchNo, 
    DespatchDate, 
    TransporterID, 
    DriverName, 
    VehicleNo, 
    DestinationID, 
    DealerID, 
    SubDealerID, 
    Mtons, 
    TotalBags, 
    ProductID, 
    DCNo, 
    FreightAmt, 
    AdvanceAmt, 
    BalanceAmt, 
    DistrictID, 
    TalukaID, 
    DespatchTypeID, 
    RakeID, 
    LRNO, 
    LRDate, 
    SONumber, 
    SODate, 
    KM, 
    Rate, 
    Amount
)
VALUES 
    (123456, -- DispatchNo
    '2024-02-26', -- DespatchDate
    16, -- TransporterID
    'John Doe', -- DriverName
    'ABC123', -- VehicleNo
    1, -- DestinationID
    1, -- DealerID
    1, -- SubDealerID
    10.5, -- Mtons
    500, -- TotalBags
    1, -- ProductID
    12345, -- DCNo
    1000.00, -- FreightAmt
    500.00, -- AdvanceAmt
    500.00, -- BalanceAmt
    10, -- DistrictID
    1, -- TalukaID
    4, -- DespatchTypeID
    1, -- RakeID
    123456789, -- LRNO
    '2024-02-27', -- LRDate
    789, -- SONumber
    '2024-02-26', -- SODate
    100, -- KM
    50, -- Rate
    5000.00 -- Amount
    );

--INSERT INTO dbo.RakeProductStock
SELECT * FROM RakeProductStock
INSERT INTO dbo.RakeProductStock (
    RRNO, 
    ProductID, 
    StockDateTime, 
    Stock
)
VALUES 
    (2, -- RRNO (Assuming you have RakeDetails with ID 1)
    3, -- ProductID (Assuming you have Products with ID 1)
    '2024-02-26 10:00:00', -- StockDateTime
    1000.00 -- Stock
    );
