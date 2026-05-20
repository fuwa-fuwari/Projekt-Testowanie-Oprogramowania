USE [master]
GO
/****** Object:  Database [MagazynDB]    Script Date: 20.05.2026 18:10:40 ******/
CREATE DATABASE [MagazynDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MagazynDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\MagazynDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MagazynDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\MagazynDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MagazynDB] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MagazynDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MagazynDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MagazynDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MagazynDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MagazynDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MagazynDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MagazynDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MagazynDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MagazynDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MagazynDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MagazynDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MagazynDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MagazynDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MagazynDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MagazynDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MagazynDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MagazynDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MagazynDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MagazynDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MagazynDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MagazynDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MagazynDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MagazynDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MagazynDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MagazynDB] SET  MULTI_USER 
GO
ALTER DATABASE [MagazynDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MagazynDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MagazynDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MagazynDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MagazynDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MagazynDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MagazynDB] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [MagazynDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MagazynDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MagazynDB]
GO
/****** Object:  Table [dbo].[HistoriaHasel]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoriaHasel](
	[HistoriaID] [int] IDENTITY(1,1) NOT NULL,
	[UzytkownikID] [int] NOT NULL,
	[HasloHash] [nvarchar](255) NOT NULL,
	[DataZmiany] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PozycjeSprzedazy]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PozycjeSprzedazy](
	[PozycjaID] [int] IDENTITY(1,1) NOT NULL,
	[SprzedazID] [int] NOT NULL,
	[TowarID] [int] NOT NULL,
	[Ilosc] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PozycjaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RejestracjaDostaw]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RejestracjaDostaw](
	[RejestracjaID] [int] IDENTITY(1,1) NOT NULL,
	[TowarID] [int] NOT NULL,
	[Ilosc] [decimal](18, 2) NOT NULL,
	[CenaNetto] [decimal](18, 2) NOT NULL,
	[ZastosowanyVAT] [decimal](5, 2) NOT NULL,
	[Dostawca] [nvarchar](255) NOT NULL,
	[DataDostawy] [date] NOT NULL,
	[DataRejestracji] [datetime] NOT NULL,
	[RejestrujacyUzytkownikID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RejestracjaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RodzajeTowarow]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RodzajeTowarow](
	[RodzajID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RodzajID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sprzedaz]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sprzedaz](
	[SprzedazID] [int] IDENTITY(1,1) NOT NULL,
	[NazwaKlienta] [nvarchar](255) NOT NULL,
	[AdresKlienta] [nvarchar](255) NOT NULL,
	[DataSprzedazy] [datetime] NOT NULL,
	[SprzedawcaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SprzedazID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StanyMagazynowe]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StanyMagazynowe](
	[TowarID] [int] NOT NULL,
	[IloscDostepna] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TowarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StawkiVAT]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StawkiVAT](
	[StawkaID] [int] IDENTITY(1,1) NOT NULL,
	[TowarID] [int] NOT NULL,
	[WartoscVAT] [decimal](5, 2) NOT NULL,
	[ObowiazujeOd] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StawkaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Towary]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towary](
	[TowarID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](255) NOT NULL,
	[RodzajID] [int] NOT NULL,
	[JednostkaMiary] [nvarchar](20) NOT NULL,
	[Opis] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TowarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uprawnienia]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uprawnienia](
	[UprawnienieID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UprawnienieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uzytkownicy]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uzytkownicy](
	[UzytkownikID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[HasloHash] [nvarchar](255) NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Miejscowosc] [nvarchar](100) NOT NULL,
	[KodPocztowy] [nvarchar](6) NOT NULL,
	[Ulica] [nvarchar](100) NULL,
	[NumerPosesji] [nvarchar](10) NOT NULL,
	[NumerLokalu] [nvarchar](10) NULL,
	[PESEL] [char](11) NOT NULL,
	[DataUrodzenia] [date] NOT NULL,
	[Plec] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Telefon] [char](9) NOT NULL,
	[LiczbaBlednychLogowan] [int] NULL,
	[KontoZablokowaneDo] [datetime] NULL,
	[CzyZapomniany] [bit] NULL,
	[DataZapomnienia] [datetime] NULL,
	[ZapomnianyPrzezID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UzytkownikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uzytkownicy_Uprawnienia]    Script Date: 20.05.2026 18:10:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uzytkownicy_Uprawnienia](
	[UzytkownikID] [int] NOT NULL,
	[UprawnienieID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UzytkownikID] ASC,
	[UprawnienieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HistoriaHasel] ON 

INSERT [dbo].[HistoriaHasel] ([HistoriaID], [UzytkownikID], [HasloHash], [DataZmiany]) VALUES (1, 1, N'starehash1!', CAST(N'2024-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[HistoriaHasel] ([HistoriaID], [UzytkownikID], [HasloHash], [DataZmiany]) VALUES (2, 1, N'starehash2!', CAST(N'2024-06-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[HistoriaHasel] OFF
GO
SET IDENTITY_INSERT [dbo].[PozycjeSprzedazy] ON 

INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (1, 1, 1, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (2, 1, 8, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (3, 2, 2, CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (4, 2, 6, CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (5, 3, 3, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (6, 4, 4, CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (7, 5, 6, CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (8, 5, 4, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (9, 5, 10, CAST(2.50 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (10, 6, 5, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (11, 7, 7, CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (12, 8, 15, CAST(2.55 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (13, 9, 14, CAST(10.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (14, 9, 7, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (15, 9, 12, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (16, 10, 2, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (17, 11, 15, CAST(2.50 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (18, 12, 14, CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (19, 13, 13, CAST(10.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (20, 14, 13, CAST(10.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (21, 14, 7, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PozycjeSprzedazy] ([PozycjaID], [SprzedazID], [TowarID], [Ilosc]) VALUES (22, 14, 12, CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[PozycjeSprzedazy] OFF
GO
SET IDENTITY_INSERT [dbo].[RejestracjaDostaw] ON 

INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (1, 1, CAST(19.00 AS Decimal(18, 2)), CAST(2100.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'Hurtownia RTV', CAST(N'2025-01-15' AS Date), CAST(N'2025-01-15T12:00:00.000' AS DateTime), 3)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (2, 2, CAST(35.00 AS Decimal(18, 2)), CAST(3200.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'Hurtownia IT', CAST(N'2025-01-20' AS Date), CAST(N'2025-01-20T12:00:00.000' AS DateTime), 3)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (3, 3, CAST(11.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'AGD Hurt', CAST(N'2025-02-01' AS Date), CAST(N'2025-02-01T12:00:00.000' AS DateTime), 3)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (4, 4, CAST(5.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'AGD Hurt', CAST(N'2025-02-05' AS Date), CAST(N'2025-02-05T12:00:00.000' AS DateTime), 3)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (5, 5, CAST(20.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'Meblex', CAST(N'2025-02-10' AS Date), CAST(N'2025-02-10T12:00:00.000' AS DateTime), 4)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (6, 6, CAST(55.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'Meblex', CAST(N'2025-02-10' AS Date), CAST(N'2025-02-10T12:00:00.000' AS DateTime), 4)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (7, 7, CAST(40.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'Narzedziownia', CAST(N'2025-02-15' AS Date), CAST(N'2025-02-15T12:00:00.000' AS DateTime), 4)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (8, 8, CAST(27.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'Narzedziownia', CAST(N'2025-02-15' AS Date), CAST(N'2025-02-15T12:00:00.000' AS DateTime), 4)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (9, 9, CAST(100.50 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)), CAST(8.00 AS Decimal(5, 2)), N'Bud-Pol', CAST(N'2025-02-20' AS Date), CAST(N'2025-02-20T12:00:00.000' AS DateTime), 4)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (10, 10, CAST(200.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(5, 2)), N'Bud-Pol', CAST(N'2025-02-20' AS Date), CAST(N'2025-02-20T12:00:00.000' AS DateTime), 4)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (11, 4, CAST(2.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'AGD Hurt', CAST(N'2026-05-11' AS Date), CAST(N'2026-05-13T14:17:02.597' AS DateTime), 1)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (12, 11, CAST(13.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'DomPol', CAST(N'2026-05-05' AS Date), CAST(N'2026-05-13T14:30:14.890' AS DateTime), 1)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (13, 11, CAST(1.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'DomPol', CAST(N'2026-05-11' AS Date), CAST(N'2026-05-13T14:30:41.530' AS DateTime), 1)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (14, 3, CAST(2.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'AGD Hurt', CAST(N'2026-05-13' AS Date), CAST(N'2026-05-13T16:34:25.697' AS DateTime), 1)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (15, 12, CAST(35.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'BudPol', CAST(N'2026-05-11' AS Date), CAST(N'2026-05-13T16:35:17.503' AS DateTime), 1)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (16, 13, CAST(100.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'BudPol', CAST(N'2026-05-18' AS Date), CAST(N'2026-05-20T14:32:12.667' AS DateTime), 1)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (17, 14, CAST(150.00 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'BudPol', CAST(N'2026-05-20' AS Date), CAST(N'2026-05-20T14:33:10.283' AS DateTime), 1)
INSERT [dbo].[RejestracjaDostaw] ([RejestracjaID], [TowarID], [Ilosc], [CenaNetto], [ZastosowanyVAT], [Dostawca], [DataDostawy], [DataRejestracji], [RejestrujacyUzytkownikID]) VALUES (18, 15, CAST(45.00 AS Decimal(18, 2)), CAST(9.50 AS Decimal(18, 2)), CAST(23.00 AS Decimal(5, 2)), N'ARTEX', CAST(N'2026-05-12' AS Date), CAST(N'2026-05-20T14:35:05.770' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[RejestracjaDostaw] OFF
GO
SET IDENTITY_INSERT [dbo].[RodzajeTowarow] ON 

INSERT [dbo].[RodzajeTowarow] ([RodzajID], [Nazwa]) VALUES (2, N'AGD')
INSERT [dbo].[RodzajeTowarow] ([RodzajID], [Nazwa]) VALUES (1, N'Elektronika')
INSERT [dbo].[RodzajeTowarow] ([RodzajID], [Nazwa]) VALUES (5, N'Materialy budowlane')
INSERT [dbo].[RodzajeTowarow] ([RodzajID], [Nazwa]) VALUES (3, N'Meble')
INSERT [dbo].[RodzajeTowarow] ([RodzajID], [Nazwa]) VALUES (4, N'Narzedzia')
SET IDENTITY_INSERT [dbo].[RodzajeTowarow] OFF
GO
SET IDENTITY_INSERT [dbo].[Sprzedaz] ON 

INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (1, N'Janusz Kowalski', N'ul. Polna 1, 00-001 Warszawa', CAST(N'2025-03-01T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (2, N'Firma XYZ Sp. z o.o.', N'ul. Lesna 5, 30-002 Krakow', CAST(N'2025-03-10T00:00:00.000' AS DateTime), 7)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (3, N'Anna Nowak', N'ul. Krotka 2, 80-003 Gdansk', CAST(N'2025-03-15T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (4, N'KomPol', N'Bukowa 12, Skierniewice', CAST(N'2026-05-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (5, N'Adam Witkowski', N'Polna 2, Toruń', CAST(N'2026-05-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (6, N'MlekPol', N'Wiśniowa 3, Tczew', CAST(N'2026-05-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (7, N'Mudar Sp. Z.O.O', N'ul. Sosnowa 97, 56-129 Kalisz', CAST(N'2026-05-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (8, N'MexBud', N'ul. Wiśniowa 14, 34-551 Szczecin', CAST(N'2026-05-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (9, N'Mudar Sp. Z.O.O', N'ul. Sosnowa 97, 56-129 Kalisz', CAST(N'2026-05-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (10, N'KomPol', N'Bukowa 12, Skierniewice', CAST(N'2026-05-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (11, N'F.H.U. Bud-Max', N'ul. Przemysłowa 12, 00-001 Warszawa', CAST(N'2026-05-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (12, N'Auto-Serwis Janusz', N'ul. Warsztatowa 1, 60-123 Poznań', CAST(N'2026-05-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (13, N'P.P.H.U Kowalski', N'ul. Polna 5, 30-002 Kraków', CAST(N'2026-05-21T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Sprzedaz] ([SprzedazID], [NazwaKlienta], [AdresKlienta], [DataSprzedazy], [SprzedawcaID]) VALUES (14, N'Hurtownia "Złoty Zbijak"', N'al. Piłsudskiego 10, 90-001 Łódź', CAST(N'2026-05-20T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Sprzedaz] OFF
GO
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (1, CAST(18.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (2, CAST(28.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (3, CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (4, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (5, CAST(18.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (6, CAST(47.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (7, CAST(74.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (8, CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (9, CAST(100.50 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (10, CAST(197.50 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (11, CAST(75.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (12, CAST(96.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (13, CAST(80.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (14, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[StanyMagazynowe] ([TowarID], [IloscDostepna]) VALUES (15, CAST(39.95 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[StawkiVAT] ON 

INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (1, 1, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (2, 2, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (3, 3, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (4, 4, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (5, 5, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (6, 6, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (7, 7, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (8, 8, CAST(23.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (9, 9, CAST(8.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (10, 10, CAST(8.00 AS Decimal(5, 2)), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (11, 11, CAST(23.00 AS Decimal(5, 2)), CAST(N'2026-05-13' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (12, 12, CAST(23.00 AS Decimal(5, 2)), CAST(N'2026-05-13' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (13, 13, CAST(23.00 AS Decimal(5, 2)), CAST(N'2026-05-20' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (14, 14, CAST(23.00 AS Decimal(5, 2)), CAST(N'2026-05-20' AS Date))
INSERT [dbo].[StawkiVAT] ([StawkaID], [TowarID], [WartoscVAT], [ObowiazujeOd]) VALUES (15, 15, CAST(23.00 AS Decimal(5, 2)), CAST(N'2026-05-20' AS Date))
SET IDENTITY_INSERT [dbo].[StawkiVAT] OFF
GO
SET IDENTITY_INSERT [dbo].[Towary] ON 

INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (1, N'Telewizor 55 cali', 1, N'Sztuki', N'Smart TV 4K, czarny')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (2, N'Laptop Biurowy', 1, N'Sztuki', N'16GB RAM, 512GB SSD')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (3, N'Pralka Automatyczna', 2, N'Sztuki', N'Ladowana od frontu, 7kg')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (4, N'Lodowka No Frost', 2, N'Sztuki', N'Wysokosc 180cm, srebrna')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (5, N'Biurko Narozne', 3, N'Sztuki', N'Drewniane z metalowymi nogami')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (6, N'Krzeslo Obrotowe', 3, N'Sztuki', N'Ergonomiczne, czarne')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (7, N'Wiertarka Udarowa', 4, N'Sztuki', N'Moc 800W, w walizce')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (8, N'Zestaw Kluczy', 4, N'Sztuki', N'108 elementow ze stali')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (9, N'Gwozdzie Stalowe', 5, N'Kilogramy', N'Dlugosc 50mm, ocynkowane')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (10, N'Klej do plytek', 5, N'Kilogramy', N'Worek 25kg, elastyczny')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (11, N'Ekspres do kawy', 2, N'Sztuki', N'Nowoczesny ekspres na kapsułki')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (12, N'Młotek Ciesielski', 5, N'Sztuki', N'Młotek z drewnianym uchwytem')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (13, N'Śruby M84', 5, N'Sztuki', N'Typowe śruby w standardzie M84')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (14, N'Śruby M8', 5, N'Sztuki', N'Śruby w standardzie M8')
INSERT [dbo].[Towary] ([TowarID], [Nazwa], [RodzajID], [JednostkaMiary], [Opis]) VALUES (15, N'Farba akrylowa biała', 5, N'Litry', N'Biała farba akrylowa do dekoracji oraz prac budowlanych')
SET IDENTITY_INSERT [dbo].[Towary] OFF
GO
SET IDENTITY_INSERT [dbo].[Uprawnienia] ON 

INSERT [dbo].[Uprawnienia] ([UprawnienieID], [Nazwa]) VALUES (1, N'Administrator')
INSERT [dbo].[Uprawnienia] ([UprawnienieID], [Nazwa]) VALUES (2, N'Kierownik magazynu')
INSERT [dbo].[Uprawnienia] ([UprawnienieID], [Nazwa]) VALUES (4, N'Kierownik sprzedazy')
INSERT [dbo].[Uprawnienia] ([UprawnienieID], [Nazwa]) VALUES (3, N'Pracownik magazynu')
INSERT [dbo].[Uprawnienia] ([UprawnienieID], [Nazwa]) VALUES (5, N'Sprzedawca')
SET IDENTITY_INSERT [dbo].[Uprawnienia] OFF
GO
SET IDENTITY_INSERT [dbo].[Uzytkownicy] ON 

INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (1, N'admin1', N'$MYHASH$V1$10000$II1qT0FbjfgzCRkK4fmstreqgqpwhy+Zv8p2Xv/SVHalAktO', N'Jan', N'Kowalski', N'Warszawa', N'00-001', N'Zlota', N'11', N'1', N'80010112319', CAST(N'1980-01-01' AS Date), N'mężczyzna', N'admin1@firma.pl', N'123456789', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (2, N'kier_mag1', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Anna', N'Nowak', N'Krakow', N'30-001', N'Florianska', N'22', NULL, N'85020212329', CAST(N'1985-02-02' AS Date), N'kobieta', N'anna.n@firma.pl', N'987654321', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (3, N'prac_mag1', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Piotr', N'Wisniewski', N'Poznan', N'60-001', N'Polna', N'33', N'12', N'90030312338', CAST(N'1990-03-03' AS Date), N'mężczyzna', N'piotr.w@firma.pl', N'500600700', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (4, N'prac_mag2', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Katarzyna', N'Wojcik', N'Wroclaw', N'50-001', N'Dluga', N'44', N'5a', N'92040412347', CAST(N'1992-04-04' AS Date), N'kobieta', N'kasia.w@firma.pl', N'600700800', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (5, N'kier_sprz1', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Tomasz', N'Kaminski', N'Gdansk', N'80-001', N'Morska', N'55', NULL, N'88050512355', CAST(N'1988-05-05' AS Date), N'mężczyzna', N'tomek.k@firma.pl', N'700800900', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (6, N'sprz1', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Magdalena', N'Lewandowska', N'Lublin', N'20-001', N'Krotka', N'66', N'3', N'95060612368', CAST(N'1995-06-06' AS Date), N'kobieta', N'magda.l@firma.pl', N'800900111', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (7, N'sprz2', N'$MYHASH$V1$10000$snnhUorHWHcSWcn29vmdwnLpNoVSurwGvCB7yXOnlTX85ONN', N'Michal', N'Zielinski', N'Szczecin', N'70-001', N'Waska', N'77', NULL, N'93070712379', CAST(N'1993-07-07' AS Date), N'mężczyzna', N'michal.z@firma.pl', N'555666777', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (8, N'user8', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Agnieszka', N'Szymanska', N'Bydgoszcz', N'85-001', N'Szeroka', N'88', N'14', N'91080812380', CAST(N'1991-08-08' AS Date), N'kobieta', N'aga.s@firma.pl', N'444555666', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (9, N'user9', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Krzysztof', N'Dabrowski', N'Katowice', N'40-001', N'Stroma', N'99', NULL, N'89090912392', CAST(N'1989-09-09' AS Date), N'mężczyzna', N'krzys.d@firma.pl', N'333444555', 0, NULL, 0, NULL, NULL)
INSERT [dbo].[Uzytkownicy] ([UzytkownikID], [Login], [HasloHash], [Imie], [Nazwisko], [Miejscowosc], [KodPocztowy], [Ulica], [NumerPosesji], [NumerLokalu], [PESEL], [DataUrodzenia], [Plec], [Email], [Telefon], [LiczbaBlednychLogowan], [KontoZablokowaneDo], [CzyZapomniany], [DataZapomnienia], [ZapomnianyPrzezID]) VALUES (10, N'user10', N'$MYHASH$V1$10000$4sAlMriOanF2RRXenkq4yeVm0g/NYJYNtVUkQObVooipl4vb', N'Monika', N'Kozlowska', N'Lodz', N'90-001', N'Piotrkowska', N'100', N'2', N'94101000025', CAST(N'1994-10-10' AS Date), N'kobieta', N'monika.k@firma.pl', N'222333444', 0, NULL, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Uzytkownicy] OFF
GO
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (1, 1)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (1, 2)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (1, 3)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (1, 4)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (1, 5)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (2, 2)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (3, 1)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (3, 3)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (4, 3)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (5, 4)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (6, 5)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (7, 5)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (8, 3)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (9, 5)
INSERT [dbo].[Uzytkownicy_Uprawnienia] ([UzytkownikID], [UprawnienieID]) VALUES (10, 3)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__RodzajeT__602223FF438A19AF]    Script Date: 20.05.2026 18:10:40 ******/
ALTER TABLE [dbo].[RodzajeTowarow] ADD UNIQUE NONCLUSTERED 
(
	[Nazwa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Uprawnie__602223FFB6A1131D]    Script Date: 20.05.2026 18:10:40 ******/
ALTER TABLE [dbo].[Uprawnienia] ADD UNIQUE NONCLUSTERED 
(
	[Nazwa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Uzytkown__4F16EE7F18580E7B]    Script Date: 20.05.2026 18:10:40 ******/
ALTER TABLE [dbo].[Uzytkownicy] ADD UNIQUE NONCLUSTERED 
(
	[PESEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Uzytkown__5E55825BB5B3B568]    Script Date: 20.05.2026 18:10:40 ******/
ALTER TABLE [dbo].[Uzytkownicy] ADD UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Uzytkown__A9D105344D241739]    Script Date: 20.05.2026 18:10:40 ******/
ALTER TABLE [dbo].[Uzytkownicy] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HistoriaHasel] ADD  DEFAULT (getdate()) FOR [DataZmiany]
GO
ALTER TABLE [dbo].[RejestracjaDostaw] ADD  DEFAULT (getdate()) FOR [DataRejestracji]
GO
ALTER TABLE [dbo].[Sprzedaz] ADD  DEFAULT (getdate()) FOR [DataSprzedazy]
GO
ALTER TABLE [dbo].[StanyMagazynowe] ADD  DEFAULT ((0)) FOR [IloscDostepna]
GO
ALTER TABLE [dbo].[Towary] ADD  DEFAULT ('Brak opisu') FOR [Opis]
GO
ALTER TABLE [dbo].[Uzytkownicy] ADD  DEFAULT ((0)) FOR [LiczbaBlednychLogowan]
GO
ALTER TABLE [dbo].[Uzytkownicy] ADD  DEFAULT ((0)) FOR [CzyZapomniany]
GO
ALTER TABLE [dbo].[HistoriaHasel]  WITH CHECK ADD FOREIGN KEY([UzytkownikID])
REFERENCES [dbo].[Uzytkownicy] ([UzytkownikID])
GO
ALTER TABLE [dbo].[PozycjeSprzedazy]  WITH CHECK ADD FOREIGN KEY([SprzedazID])
REFERENCES [dbo].[Sprzedaz] ([SprzedazID])
GO
ALTER TABLE [dbo].[PozycjeSprzedazy]  WITH CHECK ADD FOREIGN KEY([TowarID])
REFERENCES [dbo].[Towary] ([TowarID])
GO
ALTER TABLE [dbo].[RejestracjaDostaw]  WITH CHECK ADD FOREIGN KEY([RejestrujacyUzytkownikID])
REFERENCES [dbo].[Uzytkownicy] ([UzytkownikID])
GO
ALTER TABLE [dbo].[RejestracjaDostaw]  WITH CHECK ADD FOREIGN KEY([TowarID])
REFERENCES [dbo].[Towary] ([TowarID])
GO
ALTER TABLE [dbo].[Sprzedaz]  WITH CHECK ADD FOREIGN KEY([SprzedawcaID])
REFERENCES [dbo].[Uzytkownicy] ([UzytkownikID])
GO
ALTER TABLE [dbo].[StanyMagazynowe]  WITH CHECK ADD FOREIGN KEY([TowarID])
REFERENCES [dbo].[Towary] ([TowarID])
GO
ALTER TABLE [dbo].[StawkiVAT]  WITH CHECK ADD FOREIGN KEY([TowarID])
REFERENCES [dbo].[Towary] ([TowarID])
GO
ALTER TABLE [dbo].[Towary]  WITH CHECK ADD FOREIGN KEY([RodzajID])
REFERENCES [dbo].[RodzajeTowarow] ([RodzajID])
GO
ALTER TABLE [dbo].[Uzytkownicy_Uprawnienia]  WITH CHECK ADD FOREIGN KEY([UprawnienieID])
REFERENCES [dbo].[Uprawnienia] ([UprawnienieID])
GO
ALTER TABLE [dbo].[Uzytkownicy_Uprawnienia]  WITH CHECK ADD FOREIGN KEY([UzytkownikID])
REFERENCES [dbo].[Uzytkownicy] ([UzytkownikID])
GO
USE [master]
GO
ALTER DATABASE [MagazynDB] SET  READ_WRITE 
GO
