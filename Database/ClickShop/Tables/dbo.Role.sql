CREATE TABLE [dbo].[Role]
(
[RoleID] [uniqueidentifier] NOT NULL,
[RoleName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Role] ADD CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED  ([RoleID]) ON [PRIMARY]
GO
