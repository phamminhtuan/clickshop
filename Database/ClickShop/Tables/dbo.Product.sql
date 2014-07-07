CREATE TABLE [dbo].[Product]
(
[ProductId] [int] NOT NULL,
[ProductName] [nchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[CategoryId] [int] NOT NULL,
[Price] [int] NULL,
[Unit] [nchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[IsActive] [bit] NOT NULL CONSTRAINT [DF_Product_IsActive] DEFAULT ((1))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product] ADD CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED  ([ProductId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product] ADD CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id])
GO
