USE [dzstore]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_sell_detail_create_date]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_sell_detail] DROP CONSTRAINT [DF_tbl_sell_detail_create_date]
END

GO

USE [dzstore]
GO

/****** Object:  Table [dbo].[tbl_sell_detail]    Script Date: 12/31/2012 12:07:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_sell_detail]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_sell_detail]
GO

USE [dzstore]
GO

/****** Object:  Table [dbo].[tbl_sell_detail]    Script Date: 12/31/2012 12:07:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_sell_detail](
	[detail_id] [int] NOT NULL,
	[sell_id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[product_name] [nvarchar](256) NULL,
	[customer_code] [varchar](50) NULL,
	[sell_number] [int] NOT NULL,
	[price] [float] NULL,
	[discount] [float] NOT NULL,
	[sum_money] [float] NULL,
	[create_date] [datetime] NULL,
 CONSTRAINT [PK_tbl_sell_detail] PRIMARY KEY CLUSTERED 
(
	[detail_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_sell_detail] ADD  CONSTRAINT [DF_tbl_sell_detail_create_date]  DEFAULT (getdate()) FOR [create_date]
GO

