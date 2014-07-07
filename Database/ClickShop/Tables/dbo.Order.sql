CREATE TABLE [dbo].[Order]
(
[OrderId] [int] NOT NULL,
[UserId] [uniqueidentifier] NOT NULL,
[TableId] [int] NOT NULL,
[DateCreate] [date] NULL,
[Total] [int] NULL,
[IsPaid] [bit] NOT NULL CONSTRAINT [DF_Order_IsPaid] DEFAULT ((0)),
[Note] [nvarchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Promotion] [int] NULL CONSTRAINT [DF_Order_Promotion] DEFAULT ((0))
) ON [PRIMARY]
ALTER TABLE [dbo].[Order] ADD 
CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED  ([OrderId]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Order] ADD CONSTRAINT [FK_Order_iTable] FOREIGN KEY ([TableId]) REFERENCES [dbo].[iTable] ([TableId])
GO
