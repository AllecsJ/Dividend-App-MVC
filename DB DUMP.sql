USE [Dividends_DB]
GO
/****** Object:  User [root]    Script Date: 9/26/2022 5:04:44 AM ******/
CREATE USER [root] FOR LOGIN [root] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[dividends]    Script Date: 9/26/2022 5:04:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dividends](
	[div_id] [int] IDENTITY(1,1) NOT NULL,
	[symbol_code] [varchar](20) NULL,
	[payment_date] [date] NULL,
	[record_date] [date] NULL,
	[status_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[div_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[securities]    Script Date: 9/26/2022 5:04:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[securities](
	[symbol_code] [varchar](20) NOT NULL,
	[description] [text] NOT NULL,
	[status_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[symbol_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status_codes]    Script Date: 9/26/2022 5:04:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status_codes](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[dividends] ON 
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (2, N'AFS', CAST(N'2022-09-02' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (3, N'BAX', CAST(N'2022-09-03' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (4, N'BNSJ-VP', CAST(N'2022-09-24' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (5, N'BILVPB', CAST(N'2022-10-07' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (6, N'BBY', CAST(N'2022-09-11' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (7, N'AVT', CAST(N'2022-09-24' AS Date), CAST(N'2022-09-24' AS Date), 3)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (9, N'AVT', CAST(N'2022-09-13' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (10, N'AEE', CAST(N'2022-09-24' AS Date), CAST(N'2022-09-24' AS Date), 3)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (11, N'AEE', CAST(N'2022-09-24' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (14, N'BUTCGF', CAST(N'2022-09-26' AS Date), CAST(N'2022-09-24' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (15, N'BUTCGF', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-24' AS Date), 2)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (17, N'AVT', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-25' AS Date), 2)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (19, N'AEE', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-25' AS Date), 2)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (20, N'BRG', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-25' AS Date), 1)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (21, N'AEE', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-25' AS Date), 2)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (23, N'AEE', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-25' AS Date), 2)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (25, N'AVT', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-25' AS Date), 2)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (27, N'AEE', CAST(N'2022-09-25' AS Date), CAST(N'2022-09-25' AS Date), 2)
GO
INSERT [dbo].[dividends] ([div_id], [symbol_code], [payment_date], [record_date], [status_id]) VALUES (30, N'BNSJVP', CAST(N'2022-09-26' AS Date), CAST(N'2022-09-26' AS Date), 2)
GO
SET IDENTITY_INSERT [dbo].[dividends] OFF
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'AEE', N'AMEREN CORP', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'AFS', N'Access Financial Services', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'AHL', N'ANGOSTURA HOLDINGS LIMITED', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'ALKALI LTD.', N'ALKALI LIMITED', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'AMG', N'AMG Packaging & Paper Company Limited', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'AMT', N'AMERICAN TOWER CORP', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'AVT', N'AVNET INC.', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BAX', N'CALL BAXTER INTERNATIONAL', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BBY', N'BEST BUY CO. INC.', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BERGER', N'BERGER PAINTS JA. LTD.', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BIL', N'BARITA INVESTMENTS LIMITED ', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BILVPA', N'Barita Investments Ltd. Pref Shares', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BILVPB', N'BILVPB', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BNS', N'BANK OF NOVA SCOTIA JA. LTD', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BNSJ', N'BANK OF NOVA SCOTIA JA. LTD', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BNSJ-VP', N'B.N.S. JA. LTD PREFERENCE S', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BNSJVP', N'BNS Variable Pref Share', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BPOW', N'Blue Power', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BRG', N'Berger PAints', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BST', N'BARBADOS SHIPPING & TDG CO.', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BUTCGF', N'BUT Capital Growth Fund', 5)
GO
INSERT [dbo].[securities] ([symbol_code], [description], [status_id]) VALUES (N'BUTMMF', N'BUT Money Market Fund', 5)
GO
SET IDENTITY_INSERT [dbo].[status_codes] ON 
GO
INSERT [dbo].[status_codes] ([status_id], [status_name]) VALUES (1, N'PENDING')
GO
INSERT [dbo].[status_codes] ([status_id], [status_name]) VALUES (2, N'ACTIVE')
GO
INSERT [dbo].[status_codes] ([status_id], [status_name]) VALUES (3, N'CANCELLED')
GO
SET IDENTITY_INSERT [dbo].[status_codes] OFF
GO
ALTER TABLE [dbo].[securities] ADD  DEFAULT (NULL) FOR [status_id]
GO
