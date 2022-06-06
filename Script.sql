USE [insightsql01]
GO

CREATE TABLE [dbo].[Products] (
	product_id INT IDENTITY (1, 1) PRIMARY KEY,
	product_name VARCHAR (255) NOT NULL,
	product_description VARCHAR (255) NOT NULL,
	brand_name VARCHAR (255) NOT NULL,
	category_name VARCHAR (255) NOT NULL,
	model_year INT NOT NULL,
	product_price DECIMAL (10, 2) NOT NULL,
	Currency VARCHAR(3) NOT NULL
);

GO

INSERT INTO [dbo].[Products]
           ([product_name]
           ,[product_description]
           ,[brand_name]
           ,[category_name]
		   ,[model_year]
		   ,[product_price]
		   ,[Currency])
     VALUES
           ('Samsung Galaxy'
           ,'Samsung Mobile Phone'
           ,'Samsung'
           ,'Mobile'
		   ,2021
		   ,50000.00
		   ,'INR')

GO

INSERT INTO [dbo].[Products]
           ([product_name]
           ,[product_description]
           ,[brand_name]
           ,[category_name]
		   ,[model_year]
		   ,[product_price]
		   ,[Currency])
     VALUES
           ('HP'
           ,'HP Laptop'
           ,'HP'
           ,'Laptop'
		   ,2022
		   ,60000.00
		   ,'INR')

GO

INSERT INTO [dbo].[Products]
           ([product_name]
           ,[product_description]
           ,[brand_name]
           ,[category_name]
		   ,[model_year]
		   ,[product_price]
		   ,[Currency])
     VALUES
           ('Hitachi AC'
           ,'Hitachi Air Conditioner'
           ,'Hitachi'
           ,'Air Conditioner'
		   ,2021
		   ,40000.00
		   ,'INR')
