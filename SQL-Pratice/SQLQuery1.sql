SELECT * FROM Product;
SELECT * FROM Supplier;

SELECT DISTINCT Country FROM Supplier;

SELECT COUNT(DISTINCT Country) FROM Supplier;


SELECT * FROM Supplier
WHERE Country = 'USA';


SELECT ContactName, City, Phone, CompanyName FROM Supplier
ORDER BY CompanyName, ContactName, City, Phone  ASC

SELECT * FROM Product
WHERE SupplierId = 1 AND UnitPrice LIKE '1%';

SELECT * FROM Product
WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Product);

SELECT * FROM Product
WHERE ProductName LIKE 'C%'



SELECT * FROM [dbo].[View_1]

SELECT Distinct s.CompanyName, s.ContactName, s.City, s.Country, p.Unitprice FROM Supplier s JOIN Product p ON s.Id = p.SupplierId
WHERE Country IN ('UK', 'USA', 'Japan') AND UnitPrice > 10 AND UnitPrice < 20

GO
SELECT  s.CompanyName, s.ContactName, s.City, s.Country FROM Supplier s WHERE s.Id IN
(
  SELECT p.SupplierID FROM Product p WHERE p.UnitPrice > 10 AND p.UnitPrice < 20
)
AND Country IN ('UK', 'USA', 'Japan')


SELECT * FROM [Order]

SELECT * FROM OrderItem


SELECT DISTINCT s.CompanyName, s.City, s.Country, o.Quantity FROM Supplier s JOIN OrderItem o ON s.Id = o.ProductId
WHERE Country IN ('UK', 'USA', 'Japan') AND Quantity > 10 AND Quantity < 20

GO
SELECT s.CompanyName, s.City, s.Country  FROM Supplier s WHERE s.Id IN 
(
  SELECT o.Id FROM OrderItem o WHERE o.Quantity > 10 AND o.Quantity < 20
)
AND Country IN ('UK', 'USA', 'Japan')

select s.companyname, count(productname) as products from supplier s join product p on s.id = p.supplierid 
group by companyname



