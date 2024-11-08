CREATE TABLE Student  
(  
Student_ID INT PRIMARY KEY IDENTITY,   
Student_Name varchar(100),  
Student_Course varchar(50),  
Student_Age INT,   
Student_Marks INT  
);   

INSERT INTO Student VALUES ( 'Yash ', 'MCA', 23, 92 ); 
INSERT INTO Student VALUES ( 'Asutosh', 'MCA', 23, 90);  
INSERT INTO Student VALUES ( 'Ayush', 'BBA', 19, 92);  
INSERT INTO Student VALUES ( 'Vikash', 'B.tech', 20, 78);  
INSERT INTO Student VALUES ( 'Aniket', 'MBA', 21, 65);  
INSERT INTO Student VALUES ( 'Omkar', 'B.tech', 18, 93);  
INSERT INTO Student VALUES ( 'Sayali', 'BCA', 20, 97);  
INSERT INTO Student VALUES ( 'Shruti', 'B.tech', 21, 89);  
INSERT INTO Student VALUES ( 'Karan', 'MBA', 23, 90);  
INSERT INTO Student VALUES ( 'Yogesh', 'BBA', 20, 88);  
INSERT INTO Student VALUES ( 'Tannavi', 'MBA', 22, 99);  
INSERT INTO Student VALUES ( 'Mohit', 'MCA', 21, 92); 

SELECT * FROM Student


