using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    public partial class TestRunScriptSql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = @"
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([Id], [Name]) VALUES (1, N'BMW')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (2, N'NISSAN')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (3, N'BYD')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (4, N'Tesla')
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (2, N'BMW202', N'BMW_Type_1', CAST(N'2020-12-08T00:00:00.0000000' AS DateTime2), N'5Power', 1, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (6, N'BMW2020', N'BMW_Tpe2', CAST(N'2020-12-12T00:00:00.0000000' AS DateTime2), N'6power', 1, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (7, N'NISSAN202', N'NISSAN_typ1', CAST(N'2002-12-02T00:00:00.0000000' AS DateTime2), N'4power', 2, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (8, N'NISSAN2023', N'NISSAN_typ2', CAST(N'2020-12-02T00:00:00.0000000' AS DateTime2), N'3power', 2, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (9, N'BYD2000', N'BYD_Type1', CAST(N'2008-12-08T00:00:00.0000000' AS DateTime2), N'5power', 3, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (10, N'BYD2009', N'BYD_Type1', CAST(N'2008-12-08T00:00:00.0000000' AS DateTime2), N'5power', 3, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (11, N'BYD2010', N'BYD_Type2', CAST(N'2008-12-08T00:00:00.0000000' AS DateTime2), N'3power', 3, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (12, N'BYD2030', N'BYD_Type3', CAST(N'2008-12-08T00:00:00.0000000' AS DateTime2), N'5power', 3, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (13, N'Tesla1900', N'Tesla_type0', CAST(N'2023-12-12T00:00:00.0000000' AS DateTime2), N'20power', 4, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (14, N'Tesla2020', N'Tesla_type1', CAST(N'2023-12-12T00:00:00.0000000' AS DateTime2), N'30power', 4, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (15, N'Tesla1001', N'Tesla_type2', CAST(N'2023-12-12T00:00:00.0000000' AS DateTime2), N'2power', 4, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (16, N'Tesla2024', N'Tesla_type5', CAST(N'2023-12-12T00:00:00.0000000' AS DateTime2), N'30power', 4, NULL)
INSERT [dbo].[Cars] ([Id], [ModelName], [ModelType], [ModelYear], [Power], [BrandId], [AppUserId]) VALUES (17, N'Tesla1996', N'Tesla_type4', CAST(N'2023-12-12T00:00:00.0000000' AS DateTime2), N'30power', 4, NULL)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Nationalities] ON 

INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (1, N'Italian')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (2, N'Spanish')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (3, N'Egyptian')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (4, N'Indian')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (5, N'Italian')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (6, N'Japanese')
SET IDENTITY_INSERT [dbo].[Nationalities] OFF
GO
SET IDENTITY_INSERT [dbo].[BookingMasters] ON 

INSERT [dbo].[BookingMasters] ([Id], [CustomerName], [TransactionDate], [CustomerDrivingLicenseNo], [Payment], [NationalityId]) VALUES (1, N'Saleh Abdelrahem', CAST(N'2023-08-03T21:00:00.0000000' AS DateTime2), N'CDLN111', N'Visa', 3)
INSERT [dbo].[BookingMasters] ([Id], [CustomerName], [TransactionDate], [CustomerDrivingLicenseNo], [Payment], [NationalityId]) VALUES (2, N'Hema', CAST(N'2023-08-15T03:04:18.0600000' AS DateTime2), N'CDLN123', N'MasterCard', 3)
INSERT [dbo].[BookingMasters] ([Id], [CustomerName], [TransactionDate], [CustomerDrivingLicenseNo], [Payment], [NationalityId]) VALUES (3, N'Rov', CAST(N'2023-08-08T21:00:00.0000000' AS DateTime2), N'CDLN111', N'Visa', 3)
SET IDENTITY_INSERT [dbo].[BookingMasters] OFF
GO
SET IDENTITY_INSERT [dbo].[BookingDetails] ON 

INSERT [dbo].[BookingDetails] ([Id], [CarName], [Quantity], [RentDuration], [BookingMasterId]) VALUES (1, N'NISSAN202', 1, CAST(N'2023-08-15T02:08:33.3620000' AS DateTime2), 1)
INSERT [dbo].[BookingDetails] ([Id], [CarName], [Quantity], [RentDuration], [BookingMasterId]) VALUES (2, N'BMW202', 3, CAST(N'2023-08-15T02:28:04.6890000' AS DateTime2), 1)
INSERT [dbo].[BookingDetails] ([Id], [CarName], [Quantity], [RentDuration], [BookingMasterId]) VALUES (3, N'BYD2009', 10, CAST(N'2023-08-15T03:04:18.0600000' AS DateTime2), 2)
INSERT [dbo].[BookingDetails] ([Id], [CarName], [Quantity], [RentDuration], [BookingMasterId]) VALUES (4, N'BYD2010', 0, CAST(N'2023-08-15T03:05:02.8870000' AS DateTime2), 2)
INSERT [dbo].[BookingDetails] ([Id], [CarName], [Quantity], [RentDuration], [BookingMasterId]) VALUES (5, N'Tesla2020', 2, CAST(N'2023-08-22T21:00:00.0000000' AS DateTime2), 3)
INSERT [dbo].[BookingDetails] ([Id], [CarName], [Quantity], [RentDuration], [BookingMasterId]) VALUES (6, N'Tesla1996', 10, CAST(N'2023-08-07T21:00:00.0000000' AS DateTime2), 3)
SET IDENTITY_INSERT [dbo].[BookingDetails] OFF
GO


 ";
            migrationBuilder.Sql(sql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.sql("")
        }
    }
}
