--
-- Create table [dbo].[ProductCategory]
--
PRINT (N'Create table [dbo].[ProductCategory]')
GO
CREATE TABLE dbo.ProductCategory (
  ProductId int NOT NULL,
  CategoryId int NOT NULL
)
ON [PRIMARY]
GO

--
-- Create foreign key [FK_ProductCategory_Categories] on table [dbo].[ProductCategory]
--
PRINT (N'Create foreign key [FK_ProductCategory_Categories] on table [dbo].[ProductCategory]')
GO
ALTER TABLE dbo.ProductCategory
  ADD CONSTRAINT FK_ProductCategory_Categories FOREIGN KEY (CategoryId) REFERENCES dbo.Categories (Id)
GO

--
-- Create foreign key [FK_ProductCategory_Products] on table [dbo].[ProductCategory]
--
PRINT (N'Create foreign key [FK_ProductCategory_Products] on table [dbo].[ProductCategory]')
GO
ALTER TABLE dbo.ProductCategory
  ADD CONSTRAINT FK_ProductCategory_Products FOREIGN KEY (ProductId) REFERENCES dbo.Products (Id)
GO