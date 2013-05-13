USE [bookstore]
GO

/****** Object:  Table [dbo].[tbl_Sell]    Script Date: 12/27/2012 13:53:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Sell](
	[SELL_ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SumMoney] [smallmoney] NOT NULL,
	[SELL_Time] [smalldatetime] NOT NULL
) ON [PRIMARY]

GO

