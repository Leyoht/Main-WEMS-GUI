USE [master]
GO
ALTER TABLE [dbo].[SUPPLIER_ITEM] DROP CONSTRAINT [SIS_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER_ITEM] DROP CONSTRAINT [SILI_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER_EQUIPMENT] DROP CONSTRAINT [SUPPLIER_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER_EQUIPMENT] DROP CONSTRAINT [EQUIPMENT_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER] DROP CONSTRAINT [LINEITEM_ID_FK]
GO
ALTER TABLE [dbo].[PROJECT_QUAL] DROP CONSTRAINT [QualP_ID_FK]
GO
ALTER TABLE [dbo].[PROJECT_QUAL] DROP CONSTRAINT [ContractP_ID_FK]
GO
ALTER TABLE [dbo].[PAYCHECKV1] DROP CONSTRAINT [EMPLOYEE_ID_FK]
GO
ALTER TABLE [dbo].[JOBSITE] DROP CONSTRAINT [CONTRACT_ID_FK]
GO
ALTER TABLE [dbo].[EMPLOYEE_QUAL] DROP CONSTRAINT [Qual_ID_FK]
GO
ALTER TABLE [dbo].[EMPLOYEE_QUAL] DROP CONSTRAINT [Q_EMPLOYEE_ID_FK]
GO
ALTER TABLE [dbo].[EMPLOYEE_CREDENTIALS] DROP CONSTRAINT [EMPLOYEECRED_FK]
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT] DROP CONSTRAINT [C_Jobsite_ID]
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT] DROP CONSTRAINT [C_Employee_ID]
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT] DROP CONSTRAINT [C_Contract_ID]
GO
ALTER TABLE [dbo].[CONTRACT] DROP CONSTRAINT [Client_ID_FK]
GO
ALTER TABLE [dbo].[CLOCKTIME] DROP CONSTRAINT [EmployeeClock_ID_FK]
GO
ALTER TABLE [dbo].[CLIENT_EQUIPMENT] DROP CONSTRAINT [EQUIPMENTC_ID_FK]
GO
ALTER TABLE [dbo].[CLIENT_EQUIPMENT] DROP CONSTRAINT [CLIENTC_ID_FK]
GO
/****** Object:  Table [dbo].[SUPPLIER_ITEM]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[SUPPLIER_ITEM]
GO
/****** Object:  Table [dbo].[SUPPLIER_EQUIPMENT]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[SUPPLIER_EQUIPMENT]
GO
/****** Object:  Table [dbo].[SUPPLIER]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[SUPPLIER]
GO
/****** Object:  Table [dbo].[QUALIFICATION]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[QUALIFICATION]
GO
/****** Object:  Table [dbo].[PROJECT_QUAL]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[PROJECT_QUAL]
GO
/****** Object:  Table [dbo].[PAYCHECKV1]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[PAYCHECKV1]
GO
/****** Object:  Table [dbo].[LINE_ITEM]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[LINE_ITEM]
GO
/****** Object:  Table [dbo].[JOBSITE]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[JOBSITE]
GO
/****** Object:  Table [dbo].[EQUIPMENT]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[EQUIPMENT]
GO
/****** Object:  Table [dbo].[EMPLOYEE_QUAL]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[EMPLOYEE_QUAL]
GO
/****** Object:  Table [dbo].[EMPLOYEE_CREDENTIALS]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[EMPLOYEE_CREDENTIALS]
GO
/****** Object:  Table [dbo].[EMPLOYEE_CONTRACT]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[EMPLOYEE_CONTRACT]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[EMPLOYEE]
GO
/****** Object:  Table [dbo].[CONTRACT]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[CONTRACT]
GO
/****** Object:  Table [dbo].[CLOCKTIME]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[CLOCKTIME]
GO
/****** Object:  Table [dbo].[CLIENT_EQUIPMENT]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[CLIENT_EQUIPMENT]
GO
/****** Object:  Table [dbo].[CLIENT]    Script Date: 4/26/2017 1:36:25 AM ******/
DROP TABLE [dbo].[CLIENT]
GO
/****** Object:  Table [dbo].[CLIENT]    Script Date: 4/26/2017 1:36:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENT](
	[Client_ID] [varchar](5) NOT NULL,
	[Company_Name] [varchar](24) NOT NULL,
	[PhoNum] [varchar](15) NOT NULL,
	[PointOf_Contact] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CLIENT_EQUIPMENT]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENT_EQUIPMENT](
	[Equipment_ID] [varchar](5) NOT NULL,
	[Client_ID] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC,
	[Equipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CLOCKTIME]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLOCKTIME](
	[Clocktime_ID] [varchar](5) NOT NULL,
	[Employee_ID] [varchar](5) NOT NULL,
	[Day] [date] NULL,
	[Clock_In] [datetime] NULL,
	[Clock_Out] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Clocktime_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONTRACT]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTRACT](
	[Contract_ID] [varchar](5) NOT NULL,
	[Client_ID] [varchar](5) NOT NULL,
	[Is_State] [bit] NOT NULL,
	[Is_Accepted] [bit] NOT NULL,
	[Required_Work_Num] [numeric](18, 0) NOT NULL,
	[Job_Name] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Contract_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[Employee_ID] [varchar](5) NOT NULL,
	[First_Name] [varchar](20) NOT NULL,
	[MI] [varchar](20) NOT NULL,
	[Last_Name] [varchar](20) NOT NULL,
	[Minority_Status] [bit] NOT NULL,
	[DOB] [date] NOT NULL,
	[Address] [varchar](50) NULL,
	[Gender] [char](1) NOT NULL,
	[PhoNum] [varchar](15) NULL,
	[is_Supervisor] [bit] NOT NULL,
	[from_Outside] [bit] NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMPLOYEE_CONTRACT]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE_CONTRACT](
	[Employee_ID] [varchar](5) NOT NULL,
	[Jobsite_ID] [varchar](5) NOT NULL,
	[Contract_ID] [varchar](5) NOT NULL,
	[Wage] [numeric](6, 2) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMPLOYEE_CREDENTIALS]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE_CREDENTIALS](
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Employee_ID] [varchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMPLOYEE_QUAL]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE_QUAL](
	[Employee_ID] [varchar](5) NOT NULL,
	[Qual_ID] [varchar](5) NOT NULL,
	[Name] [varchar](20) NOT NULL,
 CONSTRAINT [EMPLOYEE_QUAL_PK] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC,
	[Qual_ID] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EQUIPMENT]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EQUIPMENT](
	[Equipment_ID] [varchar](5) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[isa_Vehicle] [bit] NOT NULL,
	[Status] [varchar](10) NOT NULL,
	[Location] [varchar](20) NOT NULL,
	[Equip_Condition] [varchar](4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Equipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JOBSITE]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JOBSITE](
	[Jobsite_ID] [varchar](5) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Wage_Scale_Form] [xml] NULL,
	[Statement_of_Policies] [xml] NULL,
	[Client_Supervisor] [varchar](30) NOT NULL,
	[Contract_ID] [varchar](5) NOT NULL,
	[Supervisor_ID] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Jobsite_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LINE_ITEM]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LINE_ITEM](
	[Line_Item_ID] [varchar](5) NOT NULL,
	[Description] [varchar](max) NULL,
	[Unit_Measurement] [char](10) NOT NULL,
	[Cheapest_Cost] [numeric](15, 2) NOT NULL,
	[Amount_In_Stock] [numeric](5, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Line_Item_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PAYCHECKV1]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYCHECKV1](
	[Date_Sent] [date] NOT NULL,
	[Employee_ID] [varchar](5) NOT NULL,
	[Total_Amount] [numeric](8, 2) NULL,
	[Base_Pay] [numeric](8, 2) NOT NULL,
	[Hourly_Rate] [numeric](6, 2) NOT NULL,
	[Hours_Worked] [numeric](4, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROJECT_QUAL]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROJECT_QUAL](
	[Contract_ID] [varchar](5) NOT NULL,
	[Qual_ID] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Contract_ID] ASC,
	[Qual_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUALIFICATION]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUALIFICATION](
	[Qual_ID] [varchar](5) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Description] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Qual_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SUPPLIER]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIER](
	[Supplier_ID] [varchar](5) NOT NULL,
	[Supplier_Type] [varchar](10) NOT NULL,
	[Supplier_Name] [varchar](20) NOT NULL,
	[Email] [varchar](20) NOT NULL,
	[Sales_Rep] [varchar](20) NOT NULL,
	[Line_Item_ID] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SUPPLIER_EQUIPMENT]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIER_EQUIPMENT](
	[Supplier_ID] [varchar](5) NOT NULL,
	[Equipment_ID] [varchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SUPPLIER_ITEM]    Script Date: 4/26/2017 1:36:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIER_ITEM](
	[Supplier_ID] [varchar](5) NOT NULL,
	[Line_Item_ID] [varchar](5) NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CLIENT_EQUIPMENT]  WITH CHECK ADD  CONSTRAINT [CLIENTC_ID_FK] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[CLIENT] ([Client_ID])
GO
ALTER TABLE [dbo].[CLIENT_EQUIPMENT] CHECK CONSTRAINT [CLIENTC_ID_FK]
GO
ALTER TABLE [dbo].[CLIENT_EQUIPMENT]  WITH CHECK ADD  CONSTRAINT [EQUIPMENTC_ID_FK] FOREIGN KEY([Equipment_ID])
REFERENCES [dbo].[EQUIPMENT] ([Equipment_ID])
GO
ALTER TABLE [dbo].[CLIENT_EQUIPMENT] CHECK CONSTRAINT [EQUIPMENTC_ID_FK]
GO
ALTER TABLE [dbo].[CLOCKTIME]  WITH CHECK ADD  CONSTRAINT [EmployeeClock_ID_FK] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[EMPLOYEE] ([Employee_ID])
GO
ALTER TABLE [dbo].[CLOCKTIME] CHECK CONSTRAINT [EmployeeClock_ID_FK]
GO
ALTER TABLE [dbo].[CONTRACT]  WITH CHECK ADD  CONSTRAINT [Client_ID_FK] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[CLIENT] ([Client_ID])
GO
ALTER TABLE [dbo].[CONTRACT] CHECK CONSTRAINT [Client_ID_FK]
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT]  WITH CHECK ADD  CONSTRAINT [C_Employee_ID] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[EMPLOYEE] ([Employee_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT] CHECK CONSTRAINT [C_Employee_ID]
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT]  WITH CHECK ADD  CONSTRAINT [C_Jobsite_ID] FOREIGN KEY([Jobsite_ID])
REFERENCES [dbo].[JOBSITE] ([Jobsite_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT] CHECK CONSTRAINT [C_Jobsite_ID]
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT] WITH CHECK ADD CONSTRAINT [C_Contract_ID] FOREIGN KEY([Contract_ID])
REFERENCES [dbo].[CONTRACT] ([Contract_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE_CONTRACT] CHECK CONSTRAINT [C_Contract_ID]
GO
ALTER TABLE [dbo].[EMPLOYEE_CREDENTIALS]  WITH CHECK ADD  CONSTRAINT [EMPLOYEECRED_FK] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[EMPLOYEE] ([Employee_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE_CREDENTIALS] CHECK CONSTRAINT [EMPLOYEECRED_FK]
GO
ALTER TABLE [dbo].[EMPLOYEE_QUAL]  WITH CHECK ADD  CONSTRAINT [Q_EMPLOYEE_ID_FK] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[EMPLOYEE] ([Employee_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE_QUAL] CHECK CONSTRAINT [Q_EMPLOYEE_ID_FK]
GO
ALTER TABLE [dbo].[EMPLOYEE_QUAL]  WITH CHECK ADD  CONSTRAINT [Qual_ID_FK] FOREIGN KEY([Qual_ID])
REFERENCES [dbo].[QUALIFICATION] ([Qual_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE_QUAL] CHECK CONSTRAINT [Qual_ID_FK]
GO
ALTER TABLE [dbo].[JOBSITE]  WITH CHECK ADD  CONSTRAINT [CONTRACT_ID_FK] FOREIGN KEY([Contract_ID])
REFERENCES [dbo].[CONTRACT] ([Contract_ID])
GO
ALTER TABLE [dbo].[JOBSITE] CHECK CONSTRAINT [CONTRACT_ID_FK]
GO
ALTER TABLE [dbo].[PAYCHECKV1]  WITH CHECK ADD  CONSTRAINT [EMPLOYEE_ID_FK] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[EMPLOYEE] ([Employee_ID])
GO
ALTER TABLE [dbo].[PAYCHECKV1] CHECK CONSTRAINT [EMPLOYEE_ID_FK]
GO
ALTER TABLE [dbo].[PROJECT_QUAL]  WITH CHECK ADD  CONSTRAINT [ContractP_ID_FK] FOREIGN KEY([Contract_ID])
REFERENCES [dbo].[CONTRACT] ([Contract_ID])
GO
ALTER TABLE [dbo].[PROJECT_QUAL] CHECK CONSTRAINT [ContractP_ID_FK]
GO
ALTER TABLE [dbo].[PROJECT_QUAL]  WITH CHECK ADD  CONSTRAINT [QualP_ID_FK] FOREIGN KEY([Qual_ID])
REFERENCES [dbo].[QUALIFICATION] ([Qual_ID])
GO
ALTER TABLE [dbo].[PROJECT_QUAL] CHECK CONSTRAINT [QualP_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER]  WITH CHECK ADD  CONSTRAINT [LINEITEM_ID_FK] FOREIGN KEY([Line_Item_ID])
REFERENCES [dbo].[LINE_ITEM] ([Line_Item_ID])
GO
ALTER TABLE [dbo].[SUPPLIER] CHECK CONSTRAINT [LINEITEM_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER_EQUIPMENT]  WITH CHECK ADD  CONSTRAINT [EQUIPMENT_ID_FK] FOREIGN KEY([Equipment_ID])
REFERENCES [dbo].[EQUIPMENT] ([Equipment_ID])
GO
ALTER TABLE [dbo].[SUPPLIER_EQUIPMENT] CHECK CONSTRAINT [EQUIPMENT_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER_EQUIPMENT]  WITH CHECK ADD  CONSTRAINT [SUPPLIER_ID_FK] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[SUPPLIER] ([Supplier_ID])
GO
ALTER TABLE [dbo].[SUPPLIER_EQUIPMENT] CHECK CONSTRAINT [SUPPLIER_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER_ITEM]  WITH CHECK ADD  CONSTRAINT [SILI_ID_FK] FOREIGN KEY([Line_Item_ID])
REFERENCES [dbo].[LINE_ITEM] ([Line_Item_ID])
GO
ALTER TABLE [dbo].[SUPPLIER_ITEM] CHECK CONSTRAINT [SILI_ID_FK]
GO
ALTER TABLE [dbo].[SUPPLIER_ITEM]  WITH CHECK ADD  CONSTRAINT [SIS_ID_FK] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[SUPPLIER] ([Supplier_ID])
GO
ALTER TABLE [dbo].[SUPPLIER_ITEM] CHECK CONSTRAINT [SIS_ID_FK]
GO
INSERT INTO [dbo].[EMPLOYEE] ([Employee_ID], [First_Name], [MI], [Last_Name], [Minority_Status], [DOB], [Address], [Gender], [PhoNum], [is_Supervisor], [from_Outside], [Position]) VALUES (N'12345', N'Steve', N'A', N'Henderson', 0, N'1990-04-15', N'15524 Crestmore Lane', N'M', N'456-123-4589', 1, 0, N'Employee')
INSERT INTO [dbo].[EMPLOYEE] ([Employee_ID], [First_Name], [MI], [Last_Name], [Minority_Status], [DOB], [Address], [Gender], [PhoNum], [is_Supervisor], [from_Outside], [Position]) VALUES (N'12654', N'Rachel', N'B', N'Malkowitz', 0, N'1991-01-10', N'12356 Peach Tree Blvd', N'F', N'215-225-2645', 0, 0, N'Manager')
INSERT INTO [dbo].[EMPLOYEE] ([Employee_ID], [First_Name], [MI], [Last_Name], [Minority_Status], [DOB], [Address], [Gender], [PhoNum], [is_Supervisor], [from_Outside], [Position]) VALUES (N'15267', N'Peter', N'C', N'McCaw', 0, N'1995-12-07', N'1313 Park Drive', N'M', N'555-777-1234', 0, 0, N'Supervisor')
INSERT INTO [dbo].[EMPLOYEE] ([Employee_ID], [First_Name], [MI], [Last_Name], [Minority_Status], [DOB], [Address], [Gender], [PhoNum], [is_Supervisor], [from_Outside], [Position]) VALUES (N'21234', N'Kristen', N'D', N'Howe', 0, N'1992-11-21', N'2319 Farmstead Drive', N'F', N'214-523-1536', 0, 0, N'Bookkeeper')
INSERT INTO [dbo].[EMPLOYEE] ([Employee_ID], [First_Name], [MI], [Last_Name], [Minority_Status], [DOB], [Address], [Gender], [PhoNum], [is_Supervisor], [from_Outside], [Position]) VALUES (N'22345', N'Andrew', N'E', N'Cooper', 1, N'1985-05-20', N'22686 Eagle Road', N'M', N'456-124-5555', 0, 0, N'Supervisor')
INSERT INTO [dbo].[EMPLOYEE] ([Employee_ID], [First_Name], [MI], [Last_Name], [Minority_Status], [DOB], [Address], [Gender], [PhoNum], [is_Supervisor], [from_Outside], [Position]) VALUES (N'25315', N'Jose', N'F', N'Martinez', 1, N'1982-10-03', N'1425 Franks Way', N'M', N'314-556-1526', 1, 0, N'Employee')
INSERT INTO [dbo].[EMPLOYEE] ([Employee_ID], [First_Name], [MI], [Last_Name], [Minority_Status], [DOB], [Address], [Gender], [PhoNum], [is_Supervisor], [from_Outside], [Position]) VALUES (N'78945', N'Andrea', N'G', N'Clarkson', 0, N'1993-06-25', N'3564 Shoreline Ct', N'F', N'316-258-6429', 0, 0, N'Employee')
INSERT INTO [dbo].[QUALIFICATION] ([Qual_ID], [Name], [Description]) VALUES (N'11111', N'Backhoe', N'Allowed to use a backhoe')
INSERT INTO [dbo].[QUALIFICATION] ([Qual_ID], [Name], [Description]) VALUES (N'22222', N'Steamroller', N'Allowed to use a steamroller')
INSERT INTO [dbo].[QUALIFICATION] ([Qual_ID], [Name], [Description]) VALUES (N'33333', N'Dump Truck', N'Allowed to use a dump truck')
INSERT INTO [dbo].[QUALIFICATION] ([Qual_ID], [Name], [Description]) VALUES (N'44444', N'Jackhammer', N'Allowed to use a jackhammer')
INSERT INTO [dbo].[QUALIFICATION] ([Qual_ID], [Name], [Description]) VALUES (N'55555', N'Cement Truck', N'Allowed to use a cement truck')
INSERT INTO [dbo].[QUALIFICATION] ([Qual_ID], [Name], [Description]) VALUES (N'66666', N'Bulldozer', N'Allowed to use a bulldozer')
INSERT INTO [dbo].[QUALIFICATION] ([Qual_ID], [Name], [Description]) VALUES (N'77777', N'Asphalt Truck', N'Allowed to use an asphalt truck')
INSERT INTO [dbo].[EMPLOYEE_QUAL] ([Employee_ID], [Qual_ID], [Name]) VALUES (N'12345', N'11111', N'Backhoe')
INSERT INTO [dbo].[EMPLOYEE_QUAL] ([Employee_ID], [Qual_ID], [Name]) VALUES (N'12654', N'33333', N'Dump Truck')
INSERT INTO [dbo].[EMPLOYEE_QUAL] ([Employee_ID], [Qual_ID], [Name]) VALUES (N'15267', N'55555', N'Cement Truck')
INSERT INTO [dbo].[EMPLOYEE_QUAL] ([Employee_ID], [Qual_ID], [Name]) VALUES (N'21234', N'66666', N'Bulldozer')
INSERT INTO [dbo].[EMPLOYEE_QUAL] ([Employee_ID], [Qual_ID], [Name]) VALUES (N'22345', N'22222', N'Steamroller')
INSERT INTO [dbo].[EMPLOYEE_QUAL] ([Employee_ID], [Qual_ID], [Name]) VALUES (N'25315', N'44444', N'Jackhammer')
INSERT INTO [dbo].[EMPLOYEE_QUAL] ([Employee_ID], [Qual_ID], [Name]) VALUES (N'78945', N'77777', N'Asphalt Truck')
INSERT INTO [dbo].[EQUIPMENT] ([Equipment_ID], [Name], [isa_Vehicle], [Status], [Location], [Equip_Condition]) VALUES (N'11111', N'Bulldozer', 1, N'working', N'location1', N'New')
INSERT INTO [dbo].[EQUIPMENT] ([Equipment_ID], [Name], [isa_Vehicle], [Status], [Location], [Equip_Condition]) VALUES (N'22222', N'Tractor', 1, N'working', N'location2', N'Good')
INSERT INTO [dbo].[EQUIPMENT] ([Equipment_ID], [Name], [isa_Vehicle], [Status], [Location], [Equip_Condition]) VALUES (N'33333', N'Golf Cart', 1, N'working', N'location3', N'New')
INSERT INTO [dbo].[EQUIPMENT] ([Equipment_ID], [Name], [isa_Vehicle], [Status], [Location], [Equip_Condition]) VALUES (N'44444', N'Drill', 0, N'repairing', N'location4', N'Poor')
INSERT INTO [dbo].[EQUIPMENT] ([Equipment_ID], [Name], [isa_Vehicle], [Status], [Location], [Equip_Condition]) VALUES (N'55555', N'Camera', 0, N'working', N'location5', N'New')
INSERT INTO [dbo].[EQUIPMENT] ([Equipment_ID], [Name], [isa_Vehicle], [Status], [Location], [Equip_Condition]) VALUES (N'66666', N'Jackhammer', 0, N'working', N'location6', N'Fair')
INSERT INTO [dbo].[EQUIPMENT] ([Equipment_ID], [Name], [isa_Vehicle], [Status], [Location], [Equip_Condition]) VALUES (N'77777', N'Crane', 1, N'broken', N'location7', N'Poor')
INSERT INTO [dbo].[LINE_ITEM] ([Line_Item_ID], [Description], [Unit_Measurement], [Cheapest_Cost], [Amount_In_Stock]) VALUES (N'11111', N'item1', N'pounds    ', CAST(500.00 AS Decimal(15, 2)), CAST(10 AS Decimal(5, 0)))
INSERT INTO [dbo].[LINE_ITEM] ([Line_Item_ID], [Description], [Unit_Measurement], [Cheapest_Cost], [Amount_In_Stock]) VALUES (N'22222', N'item2', N'pounds    ', CAST(800.00 AS Decimal(15, 2)), CAST(15 AS Decimal(5, 0)))
INSERT INTO [dbo].[LINE_ITEM] ([Line_Item_ID], [Description], [Unit_Measurement], [Cheapest_Cost], [Amount_In_Stock]) VALUES (N'33333', N'item3', N'pounds    ', CAST(100.00 AS Decimal(15, 2)), CAST(3 AS Decimal(5, 0)))
INSERT INTO [dbo].[LINE_ITEM] ([Line_Item_ID], [Description], [Unit_Measurement], [Cheapest_Cost], [Amount_In_Stock]) VALUES (N'44444', N'item4', N'liters    ', CAST(10.00 AS Decimal(15, 2)), CAST(500 AS Decimal(5, 0)))
INSERT INTO [dbo].[LINE_ITEM] ([Line_Item_ID], [Description], [Unit_Measurement], [Cheapest_Cost], [Amount_In_Stock]) VALUES (N'55555', N'item5', N'tons      ', CAST(5000.00 AS Decimal(15, 2)), CAST(6 AS Decimal(5, 0)))
INSERT INTO [dbo].[LINE_ITEM] ([Line_Item_ID], [Description], [Unit_Measurement], [Cheapest_Cost], [Amount_In_Stock]) VALUES (N'66666', N'item6', N'pounds    ', CAST(5000.00 AS Decimal(15, 2)), CAST(6000 AS Decimal(5, 0)))
INSERT INTO [dbo].[LINE_ITEM] ([Line_Item_ID], [Description], [Unit_Measurement], [Cheapest_Cost], [Amount_In_Stock]) VALUES (N'77777', N'item7', N'number    ', CAST(10000.00 AS Decimal(15, 2)), CAST(2 AS Decimal(5, 0)))
INSERT INTO [dbo].[SUPPLIER] ([Supplier_ID], [Supplier_Type], [Supplier_Name], [Email], [Sales_Rep], [Line_Item_ID]) VALUES (N'11111', N'AAA', N'supplier1', N'email1', N'Steve', N'11111')
INSERT INTO [dbo].[SUPPLIER] ([Supplier_ID], [Supplier_Type], [Supplier_Name], [Email], [Sales_Rep], [Line_Item_ID]) VALUES (N'22222', N'AAA', N'supplier2', N'email2', N'Bill', N'22222')
INSERT INTO [dbo].[SUPPLIER] ([Supplier_ID], [Supplier_Type], [Supplier_Name], [Email], [Sales_Rep], [Line_Item_ID]) VALUES (N'33333', N'BBB', N'supplier3', N'email3', N'Brad', N'33333')
INSERT INTO [dbo].[SUPPLIER] ([Supplier_ID], [Supplier_Type], [Supplier_Name], [Email], [Sales_Rep], [Line_Item_ID]) VALUES (N'44444', N'BBB', N'supplier4', N'email4', N'Andrew', N'44444')
INSERT INTO [dbo].[SUPPLIER] ([Supplier_ID], [Supplier_Type], [Supplier_Name], [Email], [Sales_Rep], [Line_Item_ID]) VALUES (N'55555', N'CCC', N'supplier5', N'email5', N'Tracy', N'55555')
INSERT INTO [dbo].[SUPPLIER] ([Supplier_ID], [Supplier_Type], [Supplier_Name], [Email], [Sales_Rep], [Line_Item_ID]) VALUES (N'66666', N'CCC', N'supplier6', N'email6', N'Bob', N'66666')
INSERT INTO [dbo].[SUPPLIER] ([Supplier_ID], [Supplier_Type], [Supplier_Name], [Email], [Sales_Rep], [Line_Item_ID]) VALUES (N'77777', N'DDD', N'supplier7', N'email7', N'Rachel', N'77777')
INSERT INTO [dbo].[SUPPLIER_EQUIPMENT] ([Supplier_ID], [Equipment_ID]) VALUES (N'11111', N'11111')
INSERT INTO [dbo].[SUPPLIER_EQUIPMENT] ([Supplier_ID], [Equipment_ID]) VALUES (N'22222', N'22222')
INSERT INTO [dbo].[SUPPLIER_EQUIPMENT] ([Supplier_ID], [Equipment_ID]) VALUES (N'33333', N'33333')
INSERT INTO [dbo].[SUPPLIER_EQUIPMENT] ([Supplier_ID], [Equipment_ID]) VALUES (N'44444', N'44444')
INSERT INTO [dbo].[SUPPLIER_EQUIPMENT] ([Supplier_ID], [Equipment_ID]) VALUES (N'55555', N'55555')
INSERT INTO [dbo].[SUPPLIER_EQUIPMENT] ([Supplier_ID], [Equipment_ID]) VALUES (N'66666', N'66666')
INSERT INTO [dbo].[SUPPLIER_EQUIPMENT] ([Supplier_ID], [Equipment_ID]) VALUES (N'77777', N'77777')
INSERT INTO [dbo].[CLIENT] ([Client_ID], [Company_Name], [PhoNum], [PointOf_Contact]) VALUES (N'11111', N'Indiana State Contractor', N'765-555-1234', N'Jerome Seeks')
INSERT INTO [dbo].[CLIENT] ([Client_ID], [Company_Name], [PhoNum], [PointOf_Contact]) VALUES (N'22222', N'Ohio State Contractor', N'354-221-2222', N'Darnel Barnes')
INSERT INTO [dbo].[CLIENT] ([Client_ID], [Company_Name], [PhoNum], [PointOf_Contact]) VALUES (N'33333', N'Kansas State Contractor', N'222-321-4213', N'Shavonne Hayes')
INSERT INTO [dbo].[CLIENT] ([Client_ID], [Company_Name], [PhoNum], [PointOf_Contact]) VALUES (N'44444', N'View Group LLC', N'222-984-1983', N'Steven Suk')
INSERT INTO [dbo].[CLIENT] ([Client_ID], [Company_Name], [PhoNum], [PointOf_Contact]) VALUES (N'55555', N'Barnes Group', N'354-900-8970', N'Stash Macy')
INSERT INTO [dbo].[CLIENT] ([Client_ID], [Company_Name], [PhoNum], [PointOf_Contact]) VALUES (N'66666', N'Kansas Dept of Educ', N'222-134-8973', N'Martha Man')
INSERT INTO [dbo].[CLIENT] ([Client_ID], [Company_Name], [PhoNum], [PointOf_Contact]) VALUES (N'77777', N'Royalty Holdings', N'414-340-1235', N'Cesar Gomez')
INSERT INTO [dbo].[CONTRACT] ([Contract_ID], [Client_ID], [Is_State], [Is_Accepted], [Required_Work_Num], [Job_Name]) VALUES (N'11111', N'11111', 1, 1, CAST(3 AS Decimal(18, 0)), N'Accounting')
INSERT INTO [dbo].[CONTRACT] ([Contract_ID], [Client_ID], [Is_State], [Is_Accepted], [Required_Work_Num], [Job_Name]) VALUES (N'22222', N'22222', 1, 0, CAST(4 AS Decimal(18, 0)), N'Tower Construction')
INSERT INTO [dbo].[CONTRACT] ([Contract_ID], [Client_ID], [Is_State], [Is_Accepted], [Required_Work_Num], [Job_Name]) VALUES (N'33333', N'33333', 1, 1, CAST(10 AS Decimal(18, 0)), N'Electrical Engineering')
INSERT INTO [dbo].[CONTRACT] ([Contract_ID], [Client_ID], [Is_State], [Is_Accepted], [Required_Work_Num], [Job_Name]) VALUES (N'44444', N'44444', 0, 1, CAST(5 AS Decimal(18, 0)), N'Emotional Support')
INSERT INTO [dbo].[CONTRACT] ([Contract_ID], [Client_ID], [Is_State], [Is_Accepted], [Required_Work_Num], [Job_Name]) VALUES (N'55555', N'55555', 0, 0, CAST(24 AS Decimal(18, 0)), N'Computer Programmer')
INSERT INTO [dbo].[CONTRACT] ([Contract_ID], [Client_ID], [Is_State], [Is_Accepted], [Required_Work_Num], [Job_Name]) VALUES (N'66666', N'66666', 1, 1, CAST(2 AS Decimal(18, 0)), N'Outside Analyst')
INSERT INTO [dbo].[CONTRACT] ([Contract_ID], [Client_ID], [Is_State], [Is_Accepted], [Required_Work_Num], [Job_Name]) VALUES (N'77777', N'77777', 0, 0, CAST(50 AS Decimal(18, 0)), N'Musician')
INSERT INTO [dbo].[JOBSITE] ([Jobsite_ID], [Name], [Wage_Scale_Form], [Statement_of_Policies], [Client_Supervisor], [Contract_ID], [Supervisor_ID]) VALUES (N'11111', N'Evergreen', NULL, NULL, N'Gary Bullock', N'11111', N'11111')
INSERT INTO [dbo].[JOBSITE] ([Jobsite_ID], [Name], [Wage_Scale_Form], [Statement_of_Policies], [Client_Supervisor], [Contract_ID], [Supervisor_ID]) VALUES (N'22222', N'Vvardenfell', NULL, NULL, N'John Maynes', N'22222', N'22222')
INSERT INTO [dbo].[JOBSITE] ([Jobsite_ID], [Name], [Wage_Scale_Form], [Statement_of_Policies], [Client_Supervisor], [Contract_ID], [Supervisor_ID]) VALUES (N'33333', N'Ta-Koro', NULL, NULL, N'Sally Barnes', N'33333', N'33333')
INSERT INTO [dbo].[JOBSITE] ([Jobsite_ID], [Name], [Wage_Scale_Form], [Statement_of_Policies], [Client_Supervisor], [Contract_ID], [Supervisor_ID]) VALUES (N'44444', N'Laffy-Town', NULL, NULL, N'Richard Daws', N'44444', N'44444')
INSERT INTO [dbo].[JOBSITE] ([Jobsite_ID], [Name], [Wage_Scale_Form], [Statement_of_Policies], [Client_Supervisor], [Contract_ID], [Supervisor_ID]) VALUES (N'55555', N'Kokiri Village', NULL, NULL, N'Trisha Lashone', N'55555', N'55555')
INSERT INTO [dbo].[JOBSITE] ([Jobsite_ID], [Name], [Wage_Scale_Form], [Statement_of_Policies], [Client_Supervisor], [Contract_ID], [Supervisor_ID]) VALUES (N'66666', N'Air Base', NULL, NULL, N'Sally Barnes', N'66666', N'66666')
INSERT INTO [dbo].[JOBSITE] ([Jobsite_ID], [Name], [Wage_Scale_Form], [Statement_of_Policies], [Client_Supervisor], [Contract_ID], [Supervisor_ID]) VALUES (N'77777', N'Lumbridge', NULL, NULL, N'Norm McDonald', N'77777', N'77777')
INSERT INTO [dbo].[EMPLOYEE_CONTRACT] ([Employee_ID], [Jobsite_ID], [Wage], [Contract_ID]) VALUES (N'12345', N'11111', CAST(7.25 AS Decimal(6, 2)), N'11111')
INSERT INTO [dbo].[EMPLOYEE_CONTRACT] ([Employee_ID], [Jobsite_ID], [Wage], [Contract_ID]) VALUES (N'22345', N'22222', CAST(10.00 AS Decimal(6, 2)), N'22222')
INSERT INTO [dbo].[EMPLOYEE_CONTRACT] ([Employee_ID], [Jobsite_ID], [Wage], [Contract_ID]) VALUES (N'12654', N'33333', CAST(17.25 AS Decimal(6, 2)), N'33333')
INSERT INTO [dbo].[EMPLOYEE_CONTRACT] ([Employee_ID], [Jobsite_ID], [Wage], [Contract_ID]) VALUES (N'25315', N'44444', CAST(100.42 AS Decimal(6, 2)), N'44444')
INSERT INTO [dbo].[EMPLOYEE_CONTRACT] ([Employee_ID], [Jobsite_ID], [Wage], [Contract_ID]) VALUES (N'15267', N'55555', CAST(9999.99 AS Decimal(6, 2)), N'55555')
INSERT INTO [dbo].[EMPLOYEE_CONTRACT] ([Employee_ID], [Jobsite_ID], [Wage], [Contract_ID]) VALUES (N'21234', N'66666', CAST(2.00 AS Decimal(6, 2)), N'66666')
INSERT INTO [dbo].[EMPLOYEE_CONTRACT] ([Employee_ID], [Jobsite_ID], [Wage], [Contract_ID]) VALUES (N'78945', N'77777', CAST(4000.00 AS Decimal(6, 2)), N'77777')
INSERT INTO [dbo].[PAYCHECKV1] ([Date_Sent], [Employee_ID], [Total_Amount], [Base_Pay], [Hourly_Rate], [Hours_Worked]) VALUES (N'2017-04-14', N'12345', CAST(50.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(15.00 AS Decimal(6, 2)), NULL)
INSERT INTO [dbo].[PAYCHECKV1] ([Date_Sent], [Employee_ID], [Total_Amount], [Base_Pay], [Hourly_Rate], [Hours_Worked]) VALUES (N'2017-04-14', N'22345', CAST(50.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(39.35 AS Decimal(6, 2)), NULL)
INSERT INTO [dbo].[PAYCHECKV1] ([Date_Sent], [Employee_ID], [Total_Amount], [Base_Pay], [Hourly_Rate], [Hours_Worked]) VALUES (N'2017-04-14', N'12654', CAST(50.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(25.35 AS Decimal(6, 2)), NULL)
INSERT INTO [dbo].[PAYCHECKV1] ([Date_Sent], [Employee_ID], [Total_Amount], [Base_Pay], [Hourly_Rate], [Hours_Worked]) VALUES (N'2017-04-14', N'25315', CAST(50.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(29.99 AS Decimal(6, 2)), NULL)
INSERT INTO [dbo].[PAYCHECKV1] ([Date_Sent], [Employee_ID], [Total_Amount], [Base_Pay], [Hourly_Rate], [Hours_Worked]) VALUES (N'2017-04-14', N'21234', CAST(50.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(15.15 AS Decimal(6, 2)), NULL)
INSERT INTO [dbo].[PAYCHECKV1] ([Date_Sent], [Employee_ID], [Total_Amount], [Base_Pay], [Hourly_Rate], [Hours_Worked]) VALUES (N'2017-04-14', N'15267', CAST(50.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(50.00 AS Decimal(6, 2)), NULL)
INSERT INTO [dbo].[PAYCHECKV1] ([Date_Sent], [Employee_ID], [Total_Amount], [Base_Pay], [Hourly_Rate], [Hours_Worked]) VALUES (N'2017-04-14', N'78945', CAST(50.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(40.15 AS Decimal(6, 2)), NULL)
INSERT INTO [dbo].[SUPPLIER_ITEM] ([Supplier_ID], [Line_Item_ID]) VALUES (N'11111', N'11111')
INSERT INTO [dbo].[SUPPLIER_ITEM] ([Supplier_ID], [Line_Item_ID]) VALUES (N'22222', N'22222')
INSERT INTO [dbo].[SUPPLIER_ITEM] ([Supplier_ID], [Line_Item_ID]) VALUES (N'33333', N'33333')
INSERT INTO [dbo].[SUPPLIER_ITEM] ([Supplier_ID], [Line_Item_ID]) VALUES (N'44444', N'44444')
INSERT INTO [dbo].[SUPPLIER_ITEM] ([Supplier_ID], [Line_Item_ID]) VALUES (N'55555', N'55555')
INSERT INTO [dbo].[SUPPLIER_ITEM] ([Supplier_ID], [Line_Item_ID]) VALUES (N'66666', N'66666')
INSERT INTO [dbo].[SUPPLIER_ITEM] ([Supplier_ID], [Line_Item_ID]) VALUES (N'77777', N'77777')
INSERT INTO [dbo].[CLIENT_EQUIPMENT] ([Equipment_ID], [Client_ID]) VALUES (N'11111', N'11111')
INSERT INTO [dbo].[CLIENT_EQUIPMENT] ([Equipment_ID], [Client_ID]) VALUES (N'22222', N'22222')
INSERT INTO [dbo].[CLIENT_EQUIPMENT] ([Equipment_ID], [Client_ID]) VALUES (N'33333', N'33333')
INSERT INTO [dbo].[CLIENT_EQUIPMENT] ([Equipment_ID], [Client_ID]) VALUES (N'44444', N'44444')
INSERT INTO [dbo].[CLIENT_EQUIPMENT] ([Equipment_ID], [Client_ID]) VALUES (N'55555', N'55555')
INSERT INTO [dbo].[CLIENT_EQUIPMENT] ([Equipment_ID], [Client_ID]) VALUES (N'66666', N'66666')
INSERT INTO [dbo].[CLIENT_EQUIPMENT] ([Equipment_ID], [Client_ID]) VALUES (N'77777', N'77777')
INSERT INTO [dbo].[EMPLOYEE_CREDENTIALS] ([Username], [Password], [Employee_ID]) VALUES (N'steve.henderson', N'pineapples', N'12345')
INSERT INTO [dbo].[EMPLOYEE_CREDENTIALS] ([Username], [Password], [Employee_ID]) VALUES (N'rachel.malkowitz', N'wiiwouldliketoplay', N'12654')
INSERT INTO [dbo].[EMPLOYEE_CREDENTIALS] ([Username], [Password], [Employee_ID]) VALUES (N'peter.mccaw', N'whipitwhipitgood', N'15267')
INSERT INTO [dbo].[EMPLOYEE_CREDENTIALS] ([Username], [Password], [Employee_ID]) VALUES (N'kristen.howe', N'Mom''sSpaghetti', N'21234')
INSERT INTO [dbo].[EMPLOYEE_CREDENTIALS] ([Username], [Password], [Employee_ID]) VALUES (N'andrew.cooper', N'withgr8p0wE&', N'22345')
INSERT INTO [dbo].[EMPLOYEE_CREDENTIALS] ([Username], [Password], [Employee_ID]) VALUES (N'jose.martinez', N'ImmaSc@tm4n', N'25315')
INSERT INTO [dbo].[EMPLOYEE_CREDENTIALS] ([Username], [Password], [Employee_ID]) VALUES (N'andrea.clarkson', N'Pinkiepie', N'78945')
INSERT INTO [dbo].[PROJECT_QUAL] ([Contract_ID], [Qual_ID]) VALUES (N'11111', N'11111')
INSERT INTO [dbo].[PROJECT_QUAL] ([Contract_ID], [Qual_ID]) VALUES (N'22222', N'22222')
INSERT INTO [dbo].[PROJECT_QUAL] ([Contract_ID], [Qual_ID]) VALUES (N'33333', N'33333')
INSERT INTO [dbo].[PROJECT_QUAL] ([Contract_ID], [Qual_ID]) VALUES (N'44444', N'44444')
INSERT INTO [dbo].[PROJECT_QUAL] ([Contract_ID], [Qual_ID]) VALUES (N'55555', N'55555')
INSERT INTO [dbo].[PROJECT_QUAL] ([Contract_ID], [Qual_ID]) VALUES (N'66666', N'66666')
INSERT INTO [dbo].[PROJECT_QUAL] ([Contract_ID], [Qual_ID]) VALUES (N'77777', N'77777')
INSERT INTO [dbo].[CLOCKTIME] ([Clocktime_ID], [Employee_ID], [Day], [Clock_In], [Clock_Out]) VALUES (N'11111', N'12345', N'2015-04-10', N'2015-04-10 17:30:00', N'2015-04-10 19:20:00')
INSERT INTO [dbo].[CLOCKTIME] ([Clocktime_ID], [Employee_ID], [Day], [Clock_In], [Clock_Out]) VALUES (N'22222', N'12654', N'2015-04-20', N'2015-04-20 16:29:48', N'2015-04-20 20:30:24')
INSERT INTO [dbo].[CLOCKTIME] ([Clocktime_ID], [Employee_ID], [Day], [Clock_In], [Clock_Out]) VALUES (N'33333', N'15267', N'2014-07-10', N'2014-07-10 13:30:58', N'2014-07-10 15:30:08')
INSERT INTO [dbo].[CLOCKTIME] ([Clocktime_ID], [Employee_ID], [Day], [Clock_In], [Clock_Out]) VALUES (N'44444', N'21234', N'1994-01-06', N'1994-01-06 05:40:10', N'1994-01-06 08:00:24')
INSERT INTO [dbo].[CLOCKTIME] ([Clocktime_ID], [Employee_ID], [Day], [Clock_In], [Clock_Out]) VALUES (N'55555', N'22345', N'2014-12-29', N'2014-12-29 18:40:10', N'2014-12-29 22:40:25')
INSERT INTO [dbo].[CLOCKTIME] ([Clocktime_ID], [Employee_ID], [Day], [Clock_In], [Clock_Out]) VALUES (N'66666', N'25315', N'2011-10-21', N'2011-10-21 15:20:21', N'2011-10-21 17:08:40')
INSERT INTO [dbo].[CLOCKTIME] ([Clocktime_ID], [Employee_ID], [Day], [Clock_In], [Clock_Out]) VALUES (N'77777', N'78945', N'1998-08-20', N'1998-08-20 01:50:48', N'1998-08-20 05:40:30')
GO