--
-- Create table [dbo].[Products]
--
PRINT (N'Create table [dbo].[Products]')
GO
CREATE TABLE dbo.Products (
  Id int IDENTITY,
  Name nvarchar(50) NOT NULL,
  CONSTRAINT PK_Products PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO