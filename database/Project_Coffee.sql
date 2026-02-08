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