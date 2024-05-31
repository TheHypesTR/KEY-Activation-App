USE [AktivasyonUyg]
GO

/****** Object:  Table [dbo].[KeyMgmt]    Script Date: 31.05.2024 12:44:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KeyMgmt](
	[KeyID] [int] IDENTITY(1,1) NOT NULL,
	[KeyCode] [varchar](19) NOT NULL,
	[MacAddress] [varchar](12) NULL,
	[KeyCreateDate] [datetime] NULL,
	[UserRegisterDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[KeyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[KeyMgmt] ADD  DEFAULT ((0)) FOR [MacAddress]
GO

ALTER TABLE [dbo].[KeyMgmt] ADD  DEFAULT (getdate()) FOR [KeyCreateDate]
GO

