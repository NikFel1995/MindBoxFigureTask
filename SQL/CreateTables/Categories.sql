--
-- Create table [dbo].[Categories]
--
PRINT (N'Create table [dbo].[Categories]')
GO
CREATE TABLE dbo.Categories (
  Id int IDENTITY,
  Name nvarchar(50) NOT NULL,
  CONSTRAINT PK_Categories PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO