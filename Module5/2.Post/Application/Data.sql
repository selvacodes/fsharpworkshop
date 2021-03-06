USE [FSharpIntro]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 16/09/2014 10:01:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] NOT NULL,
	[IsVip] [bit] NOT NULL,
	[Credit] [float] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Customers] ([Id], [IsVip], [Credit]) VALUES (1, 0, 0)
GO
INSERT [dbo].[Customers] ([Id], [IsVip], [Credit]) VALUES (2, 0, 10)
GO
INSERT [dbo].[Customers] ([Id], [IsVip], [Credit]) VALUES (3, 0, 30)
GO
INSERT [dbo].[Customers] ([Id], [IsVip], [Credit]) VALUES (4, 1, 50)
GO
