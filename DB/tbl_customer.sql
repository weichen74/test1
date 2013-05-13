USE [bookstore]
GO

/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 12/27/2012 13:51:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Customer](
	[USER_ID] [int] NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Levels] [smallint] NOT NULL,
	[Gender] [int] NULL,
	[Birthday] [smalldatetime] NULL,
	[Degree] [nvarchar](20) NULL,
	[Addres] [nvarchar](256) NULL,
	[Telephone] [nvarchar](20) NULL,
	[Password] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Score] [int] NULL,
 CONSTRAINT [PK_TBL_Customer] PRIMARY KEY CLUSTERED 
(
	[USER_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

