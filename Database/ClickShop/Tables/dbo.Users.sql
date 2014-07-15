CREATE TABLE [dbo].[Users]
(
[Id] [uniqueidentifier] NOT NULL,
[UserName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[PassWord] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[FullName] [nvarchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Email] [nvarchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Phone] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[IsActive] [bit] NOT NULL CONSTRAINT [DF_Users_IsActive] DEFAULT ((1))
) ON [PRIMARY]
ALTER TABLE [dbo].[Users] ADD 
CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
