USE [master]
GO
/****** Object:  Database [QuanLyQuanKaraoke]    Script Date: 4/20/2019 3:58:31 PM ******/
CREATE DATABASE [QuanLyQuanKaraoke]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanKaraoke', FILENAME = N'.\QuanLyQuanKaraoke.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanKaraoke_log', FILENAME = N'.\QuanLyQuanKaraoke_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanKaraoke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET QUERY_STORE = OFF
GO
USE [QuanLyQuanKaraoke]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[userName] [char](10) NOT NULL,
	[displayName] [nvarchar](10) NOT NULL,
	[pass] [char](1000) NOT NULL,
	[typeAccount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[idBill] [int] IDENTITY(1,1) NOT NULL,
	[timeCheckIn] [datetime] NULL,
	[timeCheckOut] [datetime] NULL,
	[idRoom] [int] NOT NULL,
	[stat] [int] NOT NULL,
	[foodPrice] [int] NULL,
	[numberTimes] [varchar](6) NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[idBillInfo] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[countFood] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBillInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[idFood] [int] IDENTITY(1,1) NOT NULL,
	[nameFood] [nvarchar](100) NOT NULL,
	[idFoodCategory] [int] NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idFood] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[idFoodCategory] [int] IDENTITY(1,1) NOT NULL,
	[nameCategory] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idFoodCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[idRoom] [int] IDENTITY(1,1) NOT NULL,
	[nameRoom] [nvarchar](100) NULL,
	[stat] [nvarchar](100) NULL,
	[price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([userName], [displayName], [pass], [typeAccount]) VALUES (N'admin     ', N'AD', N'123                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', 1)
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (1, CAST(N'2019-04-13T22:49:18.943' AS DateTime), CAST(N'2019-04-14T11:01:17.490' AS DateTime), 1, 1, 0, N'11113', 1102017)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (2, CAST(N'2019-04-14T11:01:33.407' AS DateTime), CAST(N'2019-04-14T11:02:51.320' AS DateTime), 1, 1, 35000, N'113', 37017)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (3, CAST(N'2019-04-15T08:20:03.253' AS DateTime), CAST(N'2019-04-15T08:38:50.317' AS DateTime), 1, 1, 0, N'83849', 864631)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (4, CAST(N'2019-04-15T08:38:55.890' AS DateTime), CAST(N'2019-04-15T08:39:00.127' AS DateTime), 1, 1, 0, N'3', 81)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (5, CAST(N'2019-04-15T08:39:04.210' AS DateTime), CAST(N'2019-04-15T08:39:07.570' AS DateTime), 2, 1, 0, N'2', 54)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (6, CAST(N'2019-04-15T08:39:11.527' AS DateTime), CAST(N'2019-04-15T08:39:14.900' AS DateTime), 7, 1, 0, N'2', 54)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (7, CAST(N'2019-04-15T08:39:27.513' AS DateTime), CAST(N'2019-04-15T08:39:29.150' AS DateTime), 8, 1, 0, N'1', 27)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (8, CAST(N'2019-04-15T08:39:37.423' AS DateTime), CAST(N'2019-04-15T08:39:40.727' AS DateTime), 9, 1, 0, N'2', 54)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (9, CAST(N'2019-04-15T08:39:57.137' AS DateTime), CAST(N'2019-04-15T08:39:58.347' AS DateTime), 8, 1, 0, N'0', 0)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (10, CAST(N'2019-04-15T08:40:05.443' AS DateTime), CAST(N'2019-04-15T08:40:08.997' AS DateTime), 8, 1, 0, N'2', 54)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (11, CAST(N'2019-04-15T08:40:18.610' AS DateTime), CAST(N'2019-04-15T08:40:21.160' AS DateTime), 11, 1, 0, N'1', 22)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (12, CAST(N'2019-04-15T08:40:37.043' AS DateTime), CAST(N'2019-04-15T08:40:43.543' AS DateTime), 6, 1, 0, N'5', 135)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (13, CAST(N'2019-04-15T08:40:48.203' AS DateTime), CAST(N'2019-04-15T08:40:51.060' AS DateTime), 5, 1, 0, N'2', 54)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (14, CAST(N'2019-04-15T13:01:28.710' AS DateTime), CAST(N'2019-04-15T13:01:32.693' AS DateTime), 1, 1, 0, N'2', 54)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (15, CAST(N'2019-04-15T13:01:39.963' AS DateTime), CAST(N'2019-04-15T13:01:48.353' AS DateTime), 1, 1, 0, N'7', 189)
INSERT [dbo].[Bill] ([idBill], [timeCheckIn], [timeCheckOut], [idRoom], [stat], [foodPrice], [numberTimes], [totalPrice]) VALUES (16, CAST(N'2019-04-15T13:04:28.673' AS DateTime), CAST(N'2019-04-15T13:04:37.317' AS DateTime), 1, 1, 20000, N'8', 20216)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idFood], [countFood]) VALUES (1, 2, 7, 1)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idFood], [countFood]) VALUES (2, 16, 1, 1)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([idFood], [nameFood], [idFoodCategory], [price]) VALUES (1, N'Snack', 1, 20000)
INSERT [dbo].[Food] ([idFood], [nameFood], [idFoodCategory], [price]) VALUES (2, N'Khoai tây chiên', 1, 30000)
INSERT [dbo].[Food] ([idFood], [nameFood], [idFoodCategory], [price]) VALUES (3, N'Xúc xích', 1, 20000)
INSERT [dbo].[Food] ([idFood], [nameFood], [idFoodCategory], [price]) VALUES (4, N'Bia', 2, 30000)
INSERT [dbo].[Food] ([idFood], [nameFood], [idFoodCategory], [price]) VALUES (5, N'Nước suối', 2, 20000)
INSERT [dbo].[Food] ([idFood], [nameFood], [idFoodCategory], [price]) VALUES (7, N'Soda Kiwi', 2, 35000)
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([idFoodCategory], [nameCategory]) VALUES (1, N'Đồ ăn vặt')
INSERT [dbo].[FoodCategory] ([idFoodCategory], [nameCategory]) VALUES (2, N'Nước ')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (1, N'Phòng 1', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (2, N'Phòng 2', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (3, N'Phòng 3', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (4, N'Phòng 4', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (5, N'Phòng 5', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (6, N'Phòng 6', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (7, N'Phòng 7', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (8, N'Phòng 8', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (9, N'Phòng 9', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (10, N'Phòng 10', N'Trống', 100000)
INSERT [dbo].[Room] ([idRoom], [nameRoom], [stat], [price]) VALUES (11, N'Phòng 11', N'Trống', 80000)
SET IDENTITY_INSERT [dbo].[Room] OFF
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Admin') FOR [displayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ('null') FOR [pass]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [typeAccount]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((1)) FOR [stat]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa có tên') FOR [nameFood]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa có tên') FOR [nameCategory]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT (N'Chưa có tên') FOR [nameRoom]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ('Tr?ng') FOR [stat]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idRoom])
REFERENCES [dbo].[Room] ([idRoom])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([idBill])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([idFood])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idFoodCategory])
REFERENCES [dbo].[FoodCategory] ([idFoodCategory])
GO
/****** Object:  StoredProcedure [dbo].[book]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[book](@idBill int)
as
begin
	update Bill set timeCheckIn =getdate()  where idBill = @idBill
end
GO
/****** Object:  StoredProcedure [dbo].[checkout]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkout](@idBill int)
as
begin
	update Bill set timeCheckOut =getDate()  where idBill = @idBill
end
GO
/****** Object:  StoredProcedure [dbo].[GetListBillByDate]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListBillByDate](@timeIn Date,@timeOut Date)
as
Begin
select Room.nameRoom as [Phòng] ,timeCheckIn as [Vào],timeCheckOut as [Ra],totalPrice[Tổng tiền] from Bill,Room  where timeCheckIn>=@timeIn and timeCheckOut<=@timeOut and Bill.stat=1 and Bill.idRoom = Room.idRoom;
End
GO
/****** Object:  StoredProcedure [dbo].[GetListBillByDateAndPage]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.idBill, t.nameRoom AS [Tên bàn], b.totalPrice AS [Tổng tiền], timeCheckIn AS [Ngày vào], timeCheckOut AS [Ngày ra]
	FROM dbo.Bill AS b,Room AS t
	WHERE timeCheckIn >= @checkIn AND timeCheckOut <= timeCheckOut AND b.stat = 1
	AND t.idRoom = b.idRoom)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE idBill NOT IN (SELECT TOP (@exceptRows) idBill FROM BillShow)
END
GO
/****** Object:  StoredProcedure [dbo].[GetNumBillByDate]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetNumBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,Room AS t
	WHERE timeCheckIn >= @checkIn AND timeCheckOut <= @checkOut AND b.stat = 1
	AND t.idRoom = b.idRoom
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateAccount] (@userName char(10), @displayName nvarchar(10), @password char(1000), @newPassword char(1000))
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND pass = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, pass = @newPassword WHERE UserName = @userName
	end
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName char(10)
AS 
BEGIN
	SELECT * FROM Account WHERE userName = @userName
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetRoomList]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetRoomList]
AS
BEGIN
	SELECT * FROM Room
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill](@idRoom int)
AS
BEGIn
	insert into Bill values(null,null,@idRoom,0,0,null,0) -- stat,foodPrice,numberTimes,totalPrice
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillInfo](@idBill int,@idFood int,@count int)
AS
BEGIN
	declare @i int;
	declare @c int =1;
	select @i=count(*) from BillInfo where idBill=@idBill and idFood=@idFood
	if(@i>0)
	begin
		declare @nc INT=@count +@c
		if(@nc>0)
			update BillInfo set countFood =@count +@c where idFood=@idFood;
		else
			delete BillInfo where idBill=@idBill and idFood=@idFood
	end
	else
	Begin
		insert into BillInfo values(@idBill,@idFood,@count)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 4/20/2019 3:58:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE UserName = @userName AND pass = @passWord
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET  READ_WRITE 
GO
