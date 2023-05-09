CREATE DATABASE MobilePhoneDistributeManagement;

USE MobilePhoneDistributeManagement;

CREATE TABLE Staffs (
    StaffID INT PRIMARY KEY,
	Username VARCHAR(50) NOT NULL UNIQUE,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
	Password VARCHAR(50) NOT NULL
);


INSERT INTO Staffs(StaffID, UserName, FirstName, LastName, Email, Password) VALUES 
(1,'U001','Nam','Nhat','94.nguyenhonhatnam@gmail.com','12345'),
(2,'U002','User','Test','testuser@gmail.com','12345'),
(3, 'U003', 'Minh', 'Phạm', 'minhpham@gmail.com', '12345'),
(4, 'U004', 'Trung', 'Nguyễn', 'trungnguyen@gmail.com', '12345'),
(5, 'U005', 'Hương', 'Lê', 'huongle@gmail.com', '12345'),
(6, 'U006', 'Lan', 'Nguyễn', 'lannguyen@gmail.com', '12345'),
(7, 'U007', 'Quỳnh', 'Vũ', 'quynhvuvan@gmail.com', '12345'),
(8, 'U008', 'Hải', 'Đỗ', 'haido@gmail.com', '12345'),
(9, 'U009', 'Thiên', 'Trần', 'thientran@gmail.com', '12345'),
(10, 'U010', 'Tùng', 'Lưu', 'tungluu@gmail.com', '12345'),
(11, 'U011', 'Hiếu', 'Hoàng', 'hieunguyenhoang@gmail.com', '12345'),
(12, 'U012', 'Bảo', 'Võ', 'baovo@gmail.com', '12345'),
(13, 'U013', 'Tâm', 'Nguyễn', 'tamnguyen@gmail.com', '12345'),
(14, 'U014', 'Mai', 'Lâm', 'mailam@gmail.com', '12345'),
(15, 'U015', 'Phúc', 'Trần', 'phuctran@gmail.com', '12345'),
(16, 'U016', 'Thúy', 'Trần', 'thuytran@gmail.com', '12345'),
(17, 'U017', 'Nga', 'Nguyễn', 'nganguyen@gmail.com', '12345'),
(18, 'U018', 'An', 'Đinh', 'andinh@gmail.com', '12345'),
(19, 'U019', 'Đại', 'Phạm', 'daipham@gmail.com', '12345'),
(20, 'U020', 'Vũ', 'Lê', 'vule@gmail.com', '12345');

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CompanyName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
	Password VARCHAR(50) NOT NULL
);

INSERT INTO Customers VALUES(1,'The Gioi Di Dong','tgdd123@gmail.com','12345');
INSERT INTO Customers VALUES(2,'CellphoneS','cellphones123@gmail.com','12345');
INSERT INTO Customers VALUES(3,'Công ty TNHH Hoàng Anh Gia Lai','hoanganh@gmail.com','12345');
INSERT INTO Customers VALUES(4,'FPT Shop','fptshop@gmail.com','12345');
INSERT INTO Customers VALUES(5,'Viễn Thông A','vienthonga@gmail.com','12345');
INSERT INTO Customers VALUES(6,'Tiki','tiki@gmail.com','12345');
INSERT INTO Customers VALUES(7,'Lotte.vn','lotte@gmail.com','12345');
INSERT INTO Customers VALUES(8,'Shopee','shopee@gmail.com','12345');
INSERT INTO Customers VALUES(9,'Sendo.vn','sendo@gmail.com','12345');
INSERT INTO Customers VALUES(10,'MediaMart','mediamart@gmail.com','12345');
INSERT INTO Customers VALUES(11,'Công ty TNHH Hoàng Anh Gia Lai','hoanganh@gmail.com','12345');
INSERT INTO Customers VALUES(12,'Lazada','lazada@gmail.com','12345');
INSERT INTO Customers VALUES(13,'Nguyễn Kim','nguyenkim@gmail.com','12345');
INSERT INTO Customers VALUES(14,'A Đây Rồi','adaroi@gmail.com','12345');
INSERT INTO Customers VALUES(15,'Điện Máy Xanh','dienmayxanh@gmail.com','12345');
INSERT INTO Customers VALUES(16,'An Phát','anphat@gmail.com','12345');
INSERT INTO Customers VALUES(17,'Mua Chung','muachung@gmail.com','12345');
INSERT INTO Customers VALUES(18,'ChoTot','chotot@gmail.com','12345');
INSERT INTO Customers VALUES(19,'Enbac','enbac@gmail.com','12345');
INSERT INTO Customers VALUES(20,'Alibaba','alibaba@gmail.com','12345');

CREATE TABLE RCustomers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
	Username VARCHAR(50) NOT NULL,
	Password VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL
);

INSERT INTO RCustomers (FirstName, LastName, Username, Password, Email) VALUES
('John', 'Doe', 'johndoe', '$2y$07$BCryptRequires22Chrcte/VlQH0piJtjXl.0t1XkA8pw9dMXTpOq', 'johndoe@example.com'),
('Jane', 'Doe', 'janedoe', '$2y$10$Eh9CbonYGsC6y6Jg6EEpbuQnEmPz5SvSd65.HbRh70Fr9XwdLure.', 'janedoe@example.com'),
('Michael', 'Johnson', 'michaelj', '$2y$12$uKJz2sM3O2JWh4s5ln5bIu6U0JF9YsDfj8x.GTJt4rUxrhQ4uOSqK', 'michaelj@example.com'),
('Sarah', 'Lee', 'sarahlee', '$2y$12$FfXxXCHo5/SvSIJqNFX/4uxWYQ1y57fDv6JQ6no98yL5DCoXfiKzi', 'sarahlee@example.com'),
('Daniel', 'Kim', 'danielkim', '$2y$12$zmb8fjUvU7cyKvn/BhXGweu1p8.8NtX/Yd5d5DPWAs5McMqDBRsEy', 'danielkim@example.com'),
('Rachel', 'Chen', 'rachelc', '$2y$12$6p2WTW1ZMvhQ2mtWJ2TgfuQJUCZgfrL4kM7gjWuVm/sHzf9oyC7Oa', 'rachelc@example.com'),
('David', 'Garcia', 'davidg', '$2y$12$/lYOhW6Vf/ql9g/X9CJSt.PpUQVXymUJTK7GmZVmtK0qOjXVU4GmS', 'davidg@example.com'),
('Samantha', 'Brown', 'samanthab', '$2y$12$AStgYIVnZ9QLN4k3i8.Lu.20c4Yn4EDj/m.Ws7w6RXsTlN65P46sG', 'samanthab@example.com'),
('Brian', 'Nguyen', 'brianng', '$2y$12$B0GgoWkqkfpiSMLZxIa7iurIIP/rlZV2mfrltlK6ebqIphE4qfVlG', 'brianng@example.com'),
('Emily', 'Lee', 'emilylee', '$2y$12$3.xzjkiRJzGqyJ.dBwSO..2Y2gV6sn0t/4nXkJR.s7iqEzKfX0jj6', 'emilylee@example.com'),
('Samuel', 'Choi', 'samuelchoi', '$2y$12$uUJH8Q1nkjMNZ.gAZ2NudObhiebq4.Lt89I7/WyP0A6POQXdUcbcy', 'samuelchoi@example.com'),
('Ava', 'Lopez', 'avalopez', '$2y$12$3DIZ6KJY7SkmlZRX1bxW5ONoT.TAyv06umkA94QbWXbYsX1dWpRg2', 'avalopez@example.com'),
('Linda', 'Smith', 'lindasmith', '$2y$12$r0gW8q3tL.1L/44qU1fcROAF6olXEWouh/kpDCsQ0p.8eDqMv0nmK', 'lindasmith@example.com'),
('James', 'Johnson', 'jamesjohnson', '$2y$08$t1W0fDkL8aOU0t7CKDvV.O1Av..b5xyvD2Y8.2YnHOvOs2.Qr4Kd6', 'jamesjohnson@example.com'),
('Kim', 'Lee', 'kimlee', '$2y$09$r8Op7fXuxQu2ZjT4Z/EyHOz6QpxlAPtYrHD7l.qxt0b1r29ysVuHC', 'kimlee@example.com'),
('Robert', 'Davis', 'robertdavis', '$2y$10$tJssFolRdZUEqS8hM/GpfO7QRynkN2Z/2J3qyLr0Db5OV7B8l8gJ6', 'robertdavis@example.com'),
('Amanda', 'Wilson', 'amandawilson', '$2y$11$Sb1xRhe15qLb.RP6/FgVKuZapGsRJzthmFhSS9shbCz9z2F4wP/fm', 'amandawilson@example.com'),
('Brian', 'Taylor', 'briantaylor', '$2y$12$fwV28MF/PhF10nz8eFpK9OjKd2s4V9v4v55D2o5E/tC56ZyBppC8i', 'briantaylor@example.com'),
('Jenny', 'Moore', 'jennymoore', '$2y$07$HsS.9bGkwGKIZYzLZgTXdOZJ0sXNd4M1bBz4c0xAT9gyPTp1GJb0u', 'jennymoore@example.com'),
('David', 'Clark', 'davidclark', '$2y$08$KpLwzqo74a1otSksF2hkLePqsyC41L//sXl4CllEzmhh/zmJh9Fgi', 'davidclark@example.com'),
('Emily', 'Robinson', 'emilyrobinson', '$2y$09$86nsaYHqfMx0HeIyGXlA6elw6vIme5sxScGYq1j71G0g5u5sKbI96', 'emilyrobinson@example.com'),
('Christopher', 'Wright', 'christopherwright', '$2y$10$Klf.CzFyKymhURnFn0NcneKX3zJY7pO5eC40LdmmPv37RZ1xuAn8O', 'christopherwright@example.com');


CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(500) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
	Quantity INT NOT NULL,
	Provider VARCHAR (100)
);

INSERT INTO Products VALUES (1,'iPhone 6s', '4.7-inch display, A9 chip, 12-megapixel camera', 299.99, 100,'Apple');
INSERT INTO Products VALUES (2,'iPhone 7 Plus', '5.5-inch display, A10 chip, dual 12-megapixel cameras', 499.99, 50,'Apple');
INSERT INTO Products VALUES (3,'Nokia 3', '5.0-inch display, MediaTek MT6737, 8-megapixel camera', 129.99, 100,'Nokia');
INSERT INTO Products VALUES (4,'Nokia 8', '5.3-inch display, Qualcomm Snapdragon 835, dual 13-megapixel cameras', 399.99, 20,'Nokia');
INSERT INTO Products VALUES (5,'Oppo A71', '5.2-inch display, MediaTek MT6750, 13-megapixel camera', 199.99, 10,'Oppo');
INSERT INTO Products VALUES (6,'Oppo F3 Plus', '6.0-inch display, Qualcomm Snapdragon 653, dual 16-megapixel cameras', 349.99, 30,'Oppo');
INSERT INTO Products VALUES (7,'Samsung Galaxy J3', '5.0-inch display, Exynos 7570, 8-megapixel camera', 149.99, 5,'Samsung');
INSERT INTO Products VALUES (8,'Samsung Galaxy J7', '5.5-inch display, Exynos 7870, 13-megapixel camera', 249.99, 15,'Samsungo');
INSERT INTO Products VALUES (9,'Samsung Galaxy Note 5', '5.7-inch display, Exynos 7420, 16-megapixel camera', 499.99, 8,'Samsung');
INSERT INTO Products VALUES (10,'Xiaomi Mi A2', '5.99-inch display, Qualcomm Snapdragon 660, dual 12-megapixel cameras', 299.99, 25,'Xiaomi');
INSERT INTO Products VALUES (11,'Xiaomi Redmi 4X', '5.0-inch display, Qualcomm Snapdragon 435, 13-megapixel camera', 129.99, 12,'Xiaomi');
INSERT INTO Products VALUES (12,'Huawei P10', '5.1-inch display, Kirin 960, dual 20-megapixel cameras', 449.99, 7,'Huawei');
INSERT INTO Products VALUES (13,'Huawei P20 Pro', '6.1-inch display, Kirin 970, triple 40/20/8-megapixel cameras', 799.99, 3,'Huawei');
INSERT INTO Products VALUES (14,'Google Pixel 2', '5.0-inch display, Snapdragon 835, 12-megapixel camera', 549.99, 6,'Google');
INSERT INTO Products VALUES (15,'Google Pixel 3 XL', '6.3-inch display, Snapdragon 845, 12.2-megapixel camera', 899.99, 2,'Google');
INSERT INTO Products VALUES (16,'OnePlus 5T', '6.01-inch display, Snapdragon 835, dual 16/20-megapixel cameras', 599.99, 4,'OnePlus');
INSERT INTO Products VALUES (17,'OnePlus 6T', '6.41-inch display, Snapdragon 845, dual 16/20-megapixel cameras', 699.99, 5,'OnePlus');
INSERT INTO Products VALUES (18,'Sony Xperia XZ1', '5.2-inch display, Snapdragon 835, 19-megapixel camera', 599.99, 3,'Sony');
INSERT INTO Products VALUES (19,'Sony Xperia XZ2 Premium', '5.8-inch display, Snapdragon 845, dual 19/12-megapixel cameras', 999.99, 1,'Sony');
INSERT INTO Products VALUES (20,'LG V30+', '6.0-inch display, Snapdragon 835, dual 16-megapixel cameras', 799.99, 2,'LG');

CREATE TABLE ROrders (
    OrderID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATETIME NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES RCustomers(CustomerID)
);

CREATE TABLE cart (
  ID INT PRIMARY KEY AUTO_INCREMENT,
  CustomerID INT NOT NULL,
  ProductID INT NOT NULL,
  Quantity INT NOT NULL,
  FOREIGN KEY (CustomerID) REFERENCES RCustomers(CustomerID),
  FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE ROrderDetails (
    OrderDetailID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES ROrders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Purchase_Orders (
    OrderID INT PRIMARY KEY,
    StaffID INT NOT NULL,
    OrderDate DATE NOT NULL,
    FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID)
);

INSERT INTO Purchase_Orders VALUES(1,1,'2023/04/27');
INSERT INTO Purchase_Orders VALUES(2,2,'2023/04/26');
INSERT INTO Purchase_Orders VALUES(3,3,'2023/04/25');
INSERT INTO Purchase_Orders VALUES(4,1,'2023/05/01');
INSERT INTO Purchase_Orders VALUES(5,4,'2023/04/28');
INSERT INTO Purchase_Orders VALUES(6,2,'2023/04/29');
INSERT INTO Purchase_Orders VALUES(7,5,'2023/05/02');
INSERT INTO Purchase_Orders VALUES(8,3,'2023/05/03');
INSERT INTO Purchase_Orders VALUES(9,1,'2023/05/04');
INSERT INTO Purchase_Orders VALUES(10,4,'2023/05/05');
INSERT INTO Purchase_Orders VALUES(11,2,'2023/05/06');
INSERT INTO Purchase_Orders VALUES(12,5,'2023/05/07');
INSERT INTO Purchase_Orders VALUES(13,3,'2023/05/08');
INSERT INTO Purchase_Orders VALUES(14,1,'2023/05/09');
INSERT INTO Purchase_Orders VALUES(15,4,'2023/05/10');
INSERT INTO Purchase_Orders VALUES(16,2,'2023/05/11');
INSERT INTO Purchase_Orders VALUES(17,5,'2023/05/12');
INSERT INTO Purchase_Orders VALUES(18,3,'2023/05/13');
INSERT INTO Purchase_Orders VALUES(19,1,'2023/05/14');
INSERT INTO Purchase_Orders VALUES(20,4,'2023/05/15');

CREATE TABLE PO_Details (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(19,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Purchase_Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO PO_Details VALUES
(1,1,1,100,600000000),
(2,2,2,50,500000000),
(3, 2, 3, 75, 750000000),
(4, 3, 1, 150, 600000000),
(5, 3, 2, 100, 500000000),
(6, 4, 4, 20, 200000000),
(7, 4, 5, 30, 300000000),
(8, 5, 1, 50, 600000000),
(9, 5, 4, 25, 200000000),
(10, 6, 2, 60, 500000000),
(11, 6, 3, 80, 750000000),
(12, 7, 4, 10, 200000000),
(13, 8, 5, 40, 300000000),
(14, 9, 1, 200, 600000000),
(15, 9, 3, 150, 750000000),
(16, 9, 4, 30, 200000000),
(17, 10, 2, 100, 500000000),
(18, 10, 5, 50, 300000000),
(19, 11, 1, 75, 600000000),
(20, 11, 4, 40, 200000000);


CREATE TABLE Sell_Orders(
	OrderID INT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATE NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Sell_Orders VALUES(1,1,'2023/04/29');
INSERT INTO Sell_Orders VALUES(2,2,'2023/04/26');
INSERT INTO Sell_Orders VALUES(3,3,'2023/04/30');
INSERT INTO Sell_Orders VALUES(4,1,'2023/05/02');
INSERT INTO Sell_Orders VALUES(5,4,'2023/05/01');
INSERT INTO Sell_Orders VALUES(6,2,'2023/05/03');
INSERT INTO Sell_Orders VALUES(7,5,'2023/05/04');
INSERT INTO Sell_Orders VALUES(8,3,'2023/05/05');
INSERT INTO Sell_Orders VALUES(9,1,'2023/05/06');
INSERT INTO Sell_Orders VALUES(10,4,'2023/05/07');
INSERT INTO Sell_Orders VALUES(11,2,'2023/05/08');
INSERT INTO Sell_Orders VALUES(12,5,'2023/05/09');
INSERT INTO Sell_Orders VALUES(13,3,'2023/05/10');
INSERT INTO Sell_Orders VALUES(14,1,'2023/05/11');
INSERT INTO Sell_Orders VALUES(15,4,'2023/05/12');
INSERT INTO Sell_Orders VALUES(16,2,'2023/05/13');
INSERT INTO Sell_Orders VALUES(17,5,'2023/05/14');
INSERT INTO Sell_Orders VALUES(18,3,'2023/05/15');
INSERT INTO Sell_Orders VALUES(19,1,'2023/05/16');
INSERT INTO Sell_Orders VALUES(20,4,'2023/05/17');


CREATE TABLE SO_Details(
	OrderDetailID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(19,2) NOT NULL,
	FOREIGN KEY (OrderID) REFERENCES Sell_Orders(OrderID),
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO SO_Details VALUES(1,1,1,25,150000000);
INSERT INTO SO_Details VALUES(2,2,2,20,200000000);
INSERT INTO SO_Details VALUES(3,3,3,10,300000000);
INSERT INTO SO_Details VALUES(4,4,4,5,750000000);
INSERT INTO SO_Details VALUES(5,5,5,30,120000000);
INSERT INTO SO_Details VALUES(6,6,6,15,90000000);
INSERT INTO SO_Details VALUES(7,7,7,40,50000000);
INSERT INTO SO_Details VALUES(8,8,8,12,180000000);
INSERT INTO SO_Details VALUES(9,9,9,8,250000000);
INSERT INTO SO_Details VALUES(10,10,10,18,80000000);
INSERT INTO SO_Details VALUES(11,11,11,4,450000000);
INSERT INTO SO_Details VALUES(12,12,12,35,100000000);
INSERT INTO SO_Details VALUES(13,13,13,22,180000000);
INSERT INTO SO_Details VALUES(14,14,14,7,350000000);
INSERT INTO SO_Details VALUES(15,15,15,15,90000000);
INSERT INTO SO_Details VALUES(16,16,16,10,50000000);
INSERT INTO SO_Details VALUES(17,17,17,6,75000000);
INSERT INTO SO_Details VALUES(18,18,18,25,120000000);
INSERT INTO SO_Details VALUES(19,19,19,9,300000000);
INSERT INTO SO_Details VALUES(20,20,20,16,150000000);




CREATE TABLE Products_Received (
    ReceivedID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    Quantity INT NOT NULL,
    ReceivedDate DATE NOT NULL,
	FOREIGN KEY (OrderID) REFERENCES Purchase_Orders(OrderID)
);

INSERT INTO Products_Received VALUES(1,1,100,'2023/04/27');
INSERT INTO Products_Received VALUES(2,2,50,'2023/04/26');
INSERT INTO Products_Received VALUES(3,3,75,'2023/04/25');
INSERT INTO Products_Received VALUES(4,4,50,'2023/05/01');
INSERT INTO Products_Received VALUES(5,5,25,'2023/04/28');
INSERT INTO Products_Received VALUES(6,6,30,'2023/04/29');
INSERT INTO Products_Received VALUES(7,7,45,'2023/05/02');
INSERT INTO Products_Received VALUES(8,8,40,'2023/05/03');
INSERT INTO Products_Received VALUES(9,9,30,'2023/05/04');
INSERT INTO Products_Received VALUES(10,10,20,'2023/05/05');
INSERT INTO Products_Received VALUES(11,11,50,'2023/05/06');
INSERT INTO Products_Received VALUES(12,12,35,'2023/05/07');
INSERT INTO Products_Received VALUES(13,13,25,'2023/05/08');
INSERT INTO Products_Received VALUES(14,14,55,'2023/05/09');
INSERT INTO Products_Received VALUES(15,15,65,'2023/05/10');
INSERT INTO Products_Received VALUES(16,16,30,'2023/05/11');
INSERT INTO Products_Received VALUES(17,17,60,'2023/05/12');
INSERT INTO Products_Received VALUES(18,18,70,'2023/05/13');
INSERT INTO Products_Received VALUES(19,19,80,'2023/05/14');
INSERT INTO Products_Received VALUES(20,20,100,'2023/05/15');


CREATE TABLE Products_Delivery (
	DeliveryID INT PRIMARY KEY,
	OrderID INT NOT NULL,
	Quantity INT NOT NULL,
	Delivery INT NOT NULL,
	Payment INT NOT NULL,
	DeliveryDate Date NOT NULL,
	FOREIGN KEY (OrderID) REFERENCES Sell_Orders(OrderID)
);
INSERT INTO Products_Delivery VALUES(1,1,25,1,1,'2023/04/30');
INSERT INTO Products_Delivery VALUES(2,2,20,0,0,'2023/04/30');
INSERT INTO Products_Delivery VALUES(3,3,10,1,1,'2023/05/01');
INSERT INTO Products_Delivery VALUES(4,4,15,1,0,'2023/05/01');
INSERT INTO Products_Delivery VALUES(5,5,8,0,1,'2023/05/02');
INSERT INTO Products_Delivery VALUES(6,6,12,1,1,'2023/05/02');
INSERT INTO Products_Delivery VALUES(7,7,30,1,1,'2023/05/03');
INSERT INTO Products_Delivery VALUES(8,8,5,0,0,'2023/05/03');
INSERT INTO Products_Delivery VALUES(9,9,18,1,1,'2023/05/04');
INSERT INTO Products_Delivery VALUES(10,10,10,0,1,'2023/05/04');
INSERT INTO Products_Delivery VALUES(11,11,22,1,1,'2023/05/05');
INSERT INTO Products_Delivery VALUES(12,12,27,1,0,'2023/05/05');
INSERT INTO Products_Delivery VALUES(13,13,14,0,0,'2023/05/06');
INSERT INTO Products_Delivery VALUES(14,14,9,1,1,'2023/05/06');
INSERT INTO Products_Delivery VALUES(15,15,16,1,1,'2023/05/07');
INSERT INTO Products_Delivery VALUES(16,16,11,0,0,'2023/05/07');
INSERT INTO Products_Delivery VALUES(17,17,19,1,1,'2023/05/08');
INSERT INTO Products_Delivery VALUES(18,18,7,0,1,'2023/05/08');
INSERT INTO Products_Delivery VALUES(19,19,13,1,1,'2023/05/09');
INSERT INTO Products_Delivery VALUES(20,20,21,1,0,'2023/05/09');

/*
delete from Products_Received
select * from Products
select * from Products_Delivery
select * from SO_Details
select * from Products_Received
update Products set Quantity = 100 where ProductID = 1
update Products_Received set Quantity = 100 where ReceivedID = 1
update Products_Delivery set Delivery = 1, Quantity = 50 where DeliveryID = 1
update SO_Details set Quantity = 50 where OrderDetailID = 1
delete from Products_Received where ReceivedID = 3
*/