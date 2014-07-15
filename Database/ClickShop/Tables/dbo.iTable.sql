CREATE TABLE [dbo].[iTable]
(
[TableId] [int] NOT NULL,
[TableName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[IsActive] [bit] NOT NULL CONSTRAINT [DF_iTable_IsActive] DEFAULT ((1))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[iTable] ADD CONSTRAINT [PK_iTable] PRIMARY KEY CLUSTERED  ([TableId]) ON [PRIMARY]
GO
