CREATE TABLE [dbo].[Category]
(
[Id] [int] NOT NULL,
[CategoryName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Category] ADD CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Category] ADD CONSTRAINT [IX_Category] UNIQUE NONCLUSTERED  ([CategoryName]) ON [PRIMARY]
GO
