USE master;


IF EXISTS ( SELECT  name
            FROM    master.dbo.sysdatabases
            WHERE   name = N'EmpresaBD' )
    DROP DATABASE EmpresaBD;

CREATE DATABASE EmpresaBD;
GO

USE EmpresaBD;
GO

CREATE TABLE Product
    (
      Id INT PRIMARY KEY
             IDENTITY ,
      Name VARCHAR(70) NOT NULL ,
      Price DECIMAL(10, 2) NOT NULL ,
      Quantity INT NOT NULL ,
      CreationDate DATE
    );

	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'Nokia 1',1000,2,GETDATE())
	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'Nokia 2',2000,3,GETDATE())

	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'SamSung 1',3000,4,GETDATE())
	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'SamSung 2',4000,5,GETDATE())

	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'Apple 1',5000,6,GETDATE())
	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'Apple 2',5000,6,GETDATE())
	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'Apple 3',5000,6,GETDATE())
	INSERT INTO dbo.Product ( Name, Price, Quantity, CreationDate )	VALUES  ( 'Apple 4',5000,6,GETDATE())

	SELECT * FROM dbo.Product;

	select * from Product;