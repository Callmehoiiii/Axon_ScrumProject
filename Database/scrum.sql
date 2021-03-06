USE [Scrum_StudentAccomodation]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/25/2019 11:48:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID_Acc] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID_Acc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[House]    Script Date: 4/25/2019 11:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[House](
	[ID_House] [int] NOT NULL,
	[ID_Acc] [int] NOT NULL,
	[ID_Type] [int] NOT NULL,
	[Adress] [nvarchar](50) NULL,
	[Area] [nvarchar](50) NULL,
	[Price] [nchar](10) NULL,
	[Contact] [nvarchar](50) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_House] PRIMARY KEY CLUSTERED 
(
	[ID_House] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HouseType]    Script Date: 4/25/2019 11:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HouseType](
	[ID_Type] [int] NOT NULL,
	[Type] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_HouseType] PRIMARY KEY CLUSTERED 
(
	[ID_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/25/2019 11:48:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID_Acc] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID_Acc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([ID_Acc], [UserName], [Password]) VALUES (0, N'abc', N'123')
INSERT [dbo].[Account] ([ID_Acc], [UserName], [Password]) VALUES (1, N'kim', N'123')
INSERT [dbo].[Account] ([ID_Acc], [UserName], [Password]) VALUES (2, N'the', N'123')
INSERT [dbo].[House] ([ID_House], [ID_Acc], [ID_Type], [Adress], [Area], [Price], [Contact], [Image]) VALUES (0, 1, 0, N'12 Vo Van Ngan, Thu Duc', N'8 x 4', N'2000000   ', N'0912345678', N'1.jpg')
INSERT [dbo].[House] ([ID_House], [ID_Acc], [ID_Type], [Adress], [Area], [Price], [Contact], [Image]) VALUES (1, 0, 0, N'23 Thanh Da, Binh Phuoc', N'6 x 5', N'3000000   ', N'023423423', N'2.jpg')
INSERT [dbo].[House] ([ID_House], [ID_Acc], [ID_Type], [Adress], [Area], [Price], [Contact], [Image]) VALUES (2, 0, 1, N'20 D2, Quận Bình Thạnh', N'3 x 4', N'1300000   ', N'0542135487', N'3.jpg')
INSERT [dbo].[House] ([ID_House], [ID_Acc], [ID_Type], [Adress], [Area], [Price], [Contact], [Image]) VALUES (3, 1, 1, N'200 Bác Ái, Quận Thủ Đức', N'4 x 5', N'2000000   ', N'0321654987', N'4.jpg')
INSERT [dbo].[House] ([ID_House], [ID_Acc], [ID_Type], [Adress], [Area], [Price], [Contact], [Image]) VALUES (4, 2, 0, N'23 Độc Lập, Quận Thủ Đức', N'5 x 4', N'2000000   ', N'0785462165', N'5.jpg')
INSERT [dbo].[HouseType] ([ID_Type], [Type], [Description]) VALUES (0, N'nhà trọ', N'vân vân mây mây')
INSERT [dbo].[HouseType] ([ID_Type], [Type], [Description]) VALUES (1, N'chung cư', N'cung chư')
INSERT [dbo].[User] ([ID_Acc], [Name], [Phone]) VALUES (0, N'Nguyen Van A', N'098246566')
INSERT [dbo].[User] ([ID_Acc], [Name], [Phone]) VALUES (1, N'Tran Thi B', N'098765432')
INSERT [dbo].[User] ([ID_Acc], [Name], [Phone]) VALUES (2, N'Le Van C', N'9876548677')
ALTER TABLE [dbo].[House]  WITH CHECK ADD  CONSTRAINT [FK_House_Account] FOREIGN KEY([ID_Acc])
REFERENCES [dbo].[Account] ([ID_Acc])
GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_Account]
GO
ALTER TABLE [dbo].[House]  WITH CHECK ADD  CONSTRAINT [FK_House_HouseType1] FOREIGN KEY([ID_Type])
REFERENCES [dbo].[HouseType] ([ID_Type])
GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_HouseType1]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Account1] FOREIGN KEY([ID_Acc])
REFERENCES [dbo].[Account] ([ID_Acc])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Account1]
GO
