IF DB_ID('WebDemo') IS NULL
    CREATE DATABASE WebDemo;
GO

USE WebDemo;
GO

CREATE TABLE Users (
    Id INT IDENTITY PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

INSERT INTO Users VALUES
('admin','123456','Admin'),
('user1','123456','User');

-- PRODUCTS
CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(18,0) NOT NULL,
    Image NVARCHAR(200),
    Description NVARCHAR(500)
    );
-- ORDERS
CREATE TABLE Orders (
    Id INT IDENTITY PRIMARY KEY,
    Username NVARCHAR(50),
    Total DECIMAL(18,0),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- ORDER DETAILS
CREATE TABLE OrderDetails (
    Id INT IDENTITY PRIMARY KEY,
    OrderId INT,
    ProductId INT,
    Price DECIMAL(18,0),
    Quantity INT
);
USE WebDemo;
GO

ALTER TABLE Products
ADD Description NVARCHAR(500);
GO

INSERT INTO Products (Name, Price)
VALUES 
(N'Cà phê sữa', 20000),
(N'Cà phê thịt người', 25000),
(N'Cà phê đen', 15000);

