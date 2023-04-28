CREATE DATABASE MobilePhoneDistributeManagement;

USE MobilePhoneDistributeManagement;

CREATE TABLE Staffs (
    StaffID INT IDENTITY(1,1) PRIMARY KEY,
	Username VARCHAR(50) NOT NULL UNIQUE,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
	Password VARCHAR(50) NOT NULL
);

INSERT INTO Staffs(UserName,FirstName,LastName,Email,Password) values('U001','Nam','Nhat','94.nguyenhonhatnam@gmail.com','12345')
INSERT INTO Staffs(UserName,FirstName,LastName,Email,Password) values('U002','User','Test','testuser@gmail.com','12345')
select * from Staffs

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
	Password VARCHAR(50) NOT NULL
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(500) NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    StaffID INT NOT NULL,
    OrderDate DATE NOT NULL,
    FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID)
);

CREATE TABLE Products_Received (
    ReceivedID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    Quantity INT NOT NULL,
    ReceivedDate DATE NOT NULL,
);

insert into Products_Received values(1,1,100,'2023/04/27')
insert into Products_Received values(2,2,50,'2023/04/26')

select * from Products_Received
delete from Products_Received where ReceivedID = 2

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);