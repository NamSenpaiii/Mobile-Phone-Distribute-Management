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

INSERT INTO Staffs(StaffID,UserName,FirstName,LastName,Email,Password) values(1,'U001','Nam','Nhat','94.nguyenhonhatnam@gmail.com','12345')
INSERT INTO Staffs(StaffID,UserName,FirstName,LastName,Email,Password) values(2,'U002','User','Test','testuser@gmail.com','12345')

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CompanyName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
	Password VARCHAR(50) NOT NULL
);

INSERT INTO Customers VALUES(1,'The Gioi Di Dong','tgdd123@gmail.com','12345')
INSERT INTO Customers VALUES(2,'CellphoneS','cellphones123@gmail.com','12345')


CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(500) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
	Quantity INT NOT NULL,
	Provider VARCHAR (100)
);

INSERT INTO Products VALUES (1,'IPhone 11','Used', 6000000, 100,'Apple')
INSERT INTO Products VALUES (2,'Xiaomi 11T','New', 10000000, 50,'Xiaomi')

CREATE TABLE Purchase_Orders (
    OrderID INT PRIMARY KEY,
    StaffID INT NOT NULL,
    OrderDate DATE NOT NULL,
    FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID)
);

INSERT INTO Purchase_Orders VALUES(1,1,'2023/04/27')
INSERT INTO Purchase_Orders VALUES(2,2,'2023/04/26')

CREATE TABLE PO_Details (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(19,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Purchase_Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
INSERT INTO PO_Details VALUES(1,1,1,100,600000000)
INSERT INTO PO_Details VALUES(2,2,2,50,500000000)

CREATE TABLE Sell_Orders(
	OrderID INT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATE NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Sell_Orders VALUES(1,1,'2023/04/29')
INSERT INTO Sell_Orders VALUES(2,2,'2023/04/26')


CREATE TABLE SO_Details(
	OrderDetailID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(19,2) NOT NULL,
	FOREIGN KEY (OrderID) REFERENCES Sell_Orders(OrderID),
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO SO_Details VALUES(1,1,1,25,150000000)
INSERT INTO SO_Details VALUES(2,2,2,20,200000000)


CREATE TABLE Products_Received (
    ReceivedID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    Quantity INT NOT NULL,
    ReceivedDate DATE NOT NULL,
	FOREIGN KEY (OrderID) REFERENCES Purchase_Orders(OrderID)
);

INSERT INTO Products_Received VALUES(1,1,100,'2023/04/27')
INSERT INTO Products_Received VALUES(2,2,50,'2023/04/26')

CREATE TABLE Products_Delivery (
	DeliveryID INT PRIMARY KEY,
	OrderID INT NOT NULL,
	Quantity INT NOT NULL,
	Delivery INT NOT NULL,
	Payment INT NOT NULL,
	DeliveryDate Date NOT NULL,
	FOREIGN KEY (OrderID) REFERENCES Sell_Orders(OrderID)
);
INSERT INTO Products_Delivery VALUES(1,1,25,1,1,'2023/04/30')
INSERT INTO Products_Delivery VALUES(2,2,20,0,0,'2023/04/30')
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