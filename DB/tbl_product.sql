USE [bookstore]
GO

/****** Object:  Table [dbo].[Book]    Script Date: 12/27/2012 13:59:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_product](
	[product_id] [int] NOT NULL,
	
	[product_name] [nvarchar](256) NOT NULL,
	[product_category] [int] NOT NULL,
	
	[Create_Data] [smalldatetime] NULL,
	[Price] [smallmoney] NOT NULL,
	
	[Barcode] [nchar](13) NOT NULL,
	
	[Storage] [int] NOT NULL,
 CONSTRAINT [PK_tbl_product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [CK_Storage] CHECK  (([Storage]>=(0)))
GO

ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [CK_Storage]
GO

