CREATE TABLE [dbo].[Setting]
(
[SettingName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[SettingValue] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Description] [nvarchar] (150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Setting] ADD CONSTRAINT [PK_Setting] PRIMARY KEY CLUSTERED  ([SettingName]) ON [PRIMARY]
GO
