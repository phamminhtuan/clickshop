CREATE TABLE [dbo].[OrderDetail]
(
[OrderId] [int] NOT NULL,
[ProductId] [int] NOT NULL,
[Quality] [int] NULL CONSTRAINT [DF_OrderDetail_Quality] DEFAULT ((0))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderDetail] ADD CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED  ([OrderId], [ProductId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderDetail] ADD CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] ADD CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
GO
