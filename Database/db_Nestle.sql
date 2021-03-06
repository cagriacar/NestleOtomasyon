USE [master]
GO
/****** Object:  Database [db_Nestle2]    Script Date: 13.05.2019 19:25:31 ******/
CREATE DATABASE [db_Nestle2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_Nestle2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_Nestle2.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_Nestle2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_Nestle2_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_Nestle2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_Nestle2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_Nestle2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_Nestle2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_Nestle2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_Nestle2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_Nestle2] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_Nestle2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_Nestle2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [db_Nestle2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_Nestle2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_Nestle2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_Nestle2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_Nestle2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_Nestle2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_Nestle2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_Nestle2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_Nestle2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_Nestle2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_Nestle2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_Nestle2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_Nestle2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_Nestle2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_Nestle2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_Nestle2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_Nestle2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_Nestle2] SET  MULTI_USER 
GO
ALTER DATABASE [db_Nestle2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_Nestle2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_Nestle2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_Nestle2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
/****** Object:  Login [NT Service\MSSQLSERVER]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [NT Service\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\ReportServer]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [NT SERVICE\ReportServer] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [DESKTOP-JBCRQ6H\cagri]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [DESKTOP-JBCRQ6H\cagri] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [BUILTIN\Users]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [BUILTIN\Users] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'±z²âV·¨¾w«àÿ1X¬hyiyëÀ¿çM', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 13.05.2019 19:25:31 ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'iô§&ê8ÃÃ5íyÜùvÄlÏ)d+LYèÎÛ~ç', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER AUTHORIZATION ON DATABASE::[db_Nestle2] TO [DESKTOP-JBCRQ6H\cagri]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQLSERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [DESKTOP-JBCRQ6H\cagri]
GO
USE [db_Nestle2]
GO
/****** Object:  Table [dbo].[tbl_BasvuruForm]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BasvuruForm](
	[basvuru_id] [int] IDENTITY(1,1) NOT NULL,
	[basvuruAdi] [nvarchar](50) NOT NULL,
	[basvuruSoyadi] [nvarchar](50) NOT NULL,
	[basvuruDogumTarihi] [date] NOT NULL,
	[basvuruCinsiyet] [nchar](10) NOT NULL,
	[basvuruYabanciDil] [nvarchar](50) NOT NULL,
	[basvuruAskerlikDurumu] [nvarchar](50) NOT NULL,
	[basvuruMedeniDurum] [nvarchar](50) NOT NULL,
	[basvuruEgitim] [nvarchar](50) NOT NULL,
	[basvuruDeneyim] [nvarchar](max) NOT NULL,
	[basvuruAdres] [nvarchar](max) NOT NULL,
	[basvuruTelefon] [nvarchar](50) NOT NULL,
	[basvuruMail] [nvarchar](50) NOT NULL,
	[basvuruResim] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_BasvuruForm] PRIMARY KEY CLUSTERED 
(
	[basvuru_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_BasvuruForm] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_Departman]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Departman](
	[departman_id] [int] IDENTITY(1,1) NOT NULL,
	[departmanAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Departman] PRIMARY KEY CLUSTERED 
(
	[departman_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_Departman] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_Depolama]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Depolama](
	[depo_id] [int] IDENTITY(1,1) NOT NULL,
	[depoAdi] [nvarchar](50) NOT NULL,
	[depoAdres] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Depolama] PRIMARY KEY CLUSTERED 
(
	[depo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_Depolama] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_İnsanKaynaklari]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_İnsanKaynaklari](
	[ik_id] [int] IDENTITY(1,1) NOT NULL,
	[per_id] [int] NOT NULL,
	[basvuru_id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_İnsanKaynaklari] PRIMARY KEY CLUSTERED 
(
	[ik_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_İnsanKaynaklari] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_KullaniciBilgileri]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KullaniciBilgileri](
	[kullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [nvarchar](250) NOT NULL,
	[sifre] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_tbl_KullaniciBilgileri] PRIMARY KEY CLUSTERED 
(
	[kullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_KullaniciBilgileri] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_Kurumsal]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Kurumsal](
	[kurumsal_id] [int] IDENTITY(1,1) NOT NULL,
	[hakkinda] [nvarchar](max) NOT NULL,
	[slogan] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_Kurumsal] PRIMARY KEY CLUSTERED 
(
	[kurumsal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_Kurumsal] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_Lojistik]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Lojistik](
	[lojistik_id] [int] IDENTITY(1,1) NOT NULL,
	[lojistikTuru] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Lojistik] PRIMARY KEY CLUSTERED 
(
	[lojistik_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_Lojistik] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_PersonelBilgileri]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PersonelBilgileri](
	[per_id] [int] IDENTITY(1,1) NOT NULL,
	[perAdi] [nvarchar](50) NOT NULL,
	[perSoyadi] [nvarchar](50) NOT NULL,
	[perDogumTarihi] [date] NOT NULL,
	[perTcno] [nvarchar](11) NOT NULL,
	[perUnvan] [nvarchar](50) NOT NULL,
	[perTelefon] [nvarchar](50) NOT NULL,
	[perAdres] [nvarchar](max) NOT NULL,
	[peril] [nvarchar](50) NOT NULL,
	[perilce] [nvarchar](50) NOT NULL,
	[perUlke] [nvarchar](50) NOT NULL,
	[departman_id] [int] NOT NULL,
	[perMail] [nvarchar](100) NOT NULL,
	[perResim] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_PersonelBilgileri] PRIMARY KEY CLUSTERED 
(
	[per_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_PersonelBilgileri] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_Satis]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Satis](
	[satis_id] [int] IDENTITY(1,1) NOT NULL,
	[FirmaAdi] [nvarchar](100) NOT NULL,
	[SatisTarihi] [date] NOT NULL,
	[TeslimAdresi] [nvarchar](50) NOT NULL,
	[TeslimSehir] [nvarchar](50) NOT NULL,
	[TeslimUlke] [nchar](10) NOT NULL,
	[TeslimTarihi] [date] NOT NULL,
	[urun_id] [int] NOT NULL,
	[satAdet] [int] NOT NULL,
	[satisDurumu_id] [int] NOT NULL,
	[SatisTutari] [money] NULL,
 CONSTRAINT [PK_tbl_Satis] PRIMARY KEY CLUSTERED 
(
	[satis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_Satis] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_SatisDurumu]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SatisDurumu](
	[satisDurumu_id] [int] IDENTITY(1,1) NOT NULL,
	[satisDurumu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_SatisDurumu] PRIMARY KEY CLUSTERED 
(
	[satisDurumu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_SatisDurumu] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_Sevkiyat]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Sevkiyat](
	[sev_id] [int] IDENTITY(1,1) NOT NULL,
	[satis_id] [int] NOT NULL,
	[lojistik_id] [int] NOT NULL,
	[urun_id] [int] NOT NULL,
	[sevAdres] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_tbl_Sevkiyat] PRIMARY KEY CLUSTERED 
(
	[sev_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_Sevkiyat] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_Teklif]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Teklif](
	[teklif_id] [int] IDENTITY(1,1) NOT NULL,
	[teklifNo] [nvarchar](50) NOT NULL,
	[tekFirmaAdi] [nvarchar](50) NOT NULL,
	[urun_id] [int] NOT NULL,
	[tekUrunMiktar] [int] NOT NULL,
	[teklifTutar] [money] NOT NULL,
 CONSTRAINT [PK_tbl_Teklif] PRIMARY KEY CLUSTERED 
(
	[teklif_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_Teklif] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_UrunBilgisi]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_UrunBilgisi](
	[urun_id] [int] IDENTITY(1,1) NOT NULL,
	[urun_adi] [nvarchar](50) NOT NULL,
	[uruntur_id] [int] NOT NULL,
	[urunUretimTarihi] [date] NOT NULL,
	[urunFiyati] [money] NOT NULL,
	[urunMiktari] [int] NOT NULL,
	[depo_id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_UrunBilgisi] PRIMARY KEY CLUSTERED 
(
	[urun_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_UrunBilgisi] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_UrunTuru]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_UrunTuru](
	[uruntur_id] [int] IDENTITY(1,1) NOT NULL,
	[uruntur_adi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_UrunTuru] PRIMARY KEY CLUSTERED 
(
	[uruntur_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[tbl_UrunTuru] TO  SCHEMA OWNER 
GO
SET IDENTITY_INSERT [dbo].[tbl_BasvuruForm] ON 

INSERT [dbo].[tbl_BasvuruForm] ([basvuru_id], [basvuruAdi], [basvuruSoyadi], [basvuruDogumTarihi], [basvuruCinsiyet], [basvuruYabanciDil], [basvuruAskerlikDurumu], [basvuruMedeniDurum], [basvuruEgitim], [basvuruDeneyim], [basvuruAdres], [basvuruTelefon], [basvuruMail], [basvuruResim]) VALUES (2, N'Ayşe', N'Boldemir', CAST(0xD31B0B00 AS Date), N'Kadın     ', N'İngizlice', N'Tecilli', N'Bekar', N'Lisans', N'2 Yıl', N'Pendik/İstanbul', N'5556663322', N'cacar@mail.com', N'E:\Resimler\kopek.jpg')
INSERT [dbo].[tbl_BasvuruForm] ([basvuru_id], [basvuruAdi], [basvuruSoyadi], [basvuruDogumTarihi], [basvuruCinsiyet], [basvuruYabanciDil], [basvuruAskerlikDurumu], [basvuruMedeniDurum], [basvuruEgitim], [basvuruDeneyim], [basvuruAdres], [basvuruTelefon], [basvuruMail], [basvuruResim]) VALUES (3, N'Ayşe', N'Boldemir', CAST(0xD31B0B00 AS Date), N'Kadın     ', N'İngizlice', N'Tecilli', N'Bekar', N'Lisans', N'2 Yıl', N'Pendik/İstanbul', N'5556663322', N'cacar@mail.com', N'E:\Resimler\kopek.jpg')
INSERT [dbo].[tbl_BasvuruForm] ([basvuru_id], [basvuruAdi], [basvuruSoyadi], [basvuruDogumTarihi], [basvuruCinsiyet], [basvuruYabanciDil], [basvuruAskerlikDurumu], [basvuruMedeniDurum], [basvuruEgitim], [basvuruDeneyim], [basvuruAdres], [basvuruTelefon], [basvuruMail], [basvuruResim]) VALUES (5, N'zeliş', N'Boldemir', CAST(0xD31B0B00 AS Date), N'Kadın     ', N'İngizlice', N'Tecilli', N'Bekar', N'Lisans', N'2 Yıl', N'Pendik/İstanbul', N'5556663322', N'cacar@mail.com', N'E:\Resimler\kopek.jpg')
INSERT [dbo].[tbl_BasvuruForm] ([basvuru_id], [basvuruAdi], [basvuruSoyadi], [basvuruDogumTarihi], [basvuruCinsiyet], [basvuruYabanciDil], [basvuruAskerlikDurumu], [basvuruMedeniDurum], [basvuruEgitim], [basvuruDeneyim], [basvuruAdres], [basvuruTelefon], [basvuruMail], [basvuruResim]) VALUES (6, N'zeooo', N'Boldemir', CAST(0xD31B0B00 AS Date), N'Kadın     ', N'İngizlice', N'Tecilli', N'Bekar', N'Lisans', N'2 Yıl', N'Pendik/İstanbul', N'5556663322', N'cacar@mail.com', N'C:\Users\cagri\OneDrive\Resimler\FOTOGRAFLAR\IMG_5639.JPG')
SET IDENTITY_INSERT [dbo].[tbl_BasvuruForm] OFF
SET IDENTITY_INSERT [dbo].[tbl_Departman] ON 

INSERT [dbo].[tbl_Departman] ([departman_id], [departmanAdi]) VALUES (1, N'Üretim')
INSERT [dbo].[tbl_Departman] ([departman_id], [departmanAdi]) VALUES (2, N'İnsan Kaynakları')
INSERT [dbo].[tbl_Departman] ([departman_id], [departmanAdi]) VALUES (3, N'Satış')
INSERT [dbo].[tbl_Departman] ([departman_id], [departmanAdi]) VALUES (4, N'Depolama')
INSERT [dbo].[tbl_Departman] ([departman_id], [departmanAdi]) VALUES (5, N'Lojistik')
SET IDENTITY_INSERT [dbo].[tbl_Departman] OFF
SET IDENTITY_INSERT [dbo].[tbl_Depolama] ON 

INSERT [dbo].[tbl_Depolama] ([depo_id], [depoAdi], [depoAdres]) VALUES (4, N'Pendik', N'aaaa.mah')
INSERT [dbo].[tbl_Depolama] ([depo_id], [depoAdi], [depoAdres]) VALUES (5, N'Kartal', N'bbbb.mah')
INSERT [dbo].[tbl_Depolama] ([depo_id], [depoAdi], [depoAdres]) VALUES (6, N'Maltepe', N'ccccc.mah')
INSERT [dbo].[tbl_Depolama] ([depo_id], [depoAdi], [depoAdres]) VALUES (7, N'Bostancı', N'ddddd.mah')
INSERT [dbo].[tbl_Depolama] ([depo_id], [depoAdi], [depoAdres]) VALUES (8, N'Kadıköy', N'ee.mah')
INSERT [dbo].[tbl_Depolama] ([depo_id], [depoAdi], [depoAdres]) VALUES (10, N'Tuzla', N'ffff.mah')
SET IDENTITY_INSERT [dbo].[tbl_Depolama] OFF
SET IDENTITY_INSERT [dbo].[tbl_KullaniciBilgileri] ON 

INSERT [dbo].[tbl_KullaniciBilgileri] ([kullaniciId], [kullaniciAdi], [sifre]) VALUES (1, N'cagri', N'1234')
INSERT [dbo].[tbl_KullaniciBilgileri] ([kullaniciId], [kullaniciAdi], [sifre]) VALUES (2, N'admin', N'1234')
INSERT [dbo].[tbl_KullaniciBilgileri] ([kullaniciId], [kullaniciAdi], [sifre]) VALUES (3, N'user', N'1234')
SET IDENTITY_INSERT [dbo].[tbl_KullaniciBilgileri] OFF
SET IDENTITY_INSERT [dbo].[tbl_Kurumsal] ON 

INSERT [dbo].[tbl_Kurumsal] ([kurumsal_id], [hakkinda], [slogan]) VALUES (1, N'100 yılı aşkın süredir Türkiye ‘de
Türk tüketicisiyle ilk olarak 1875 yılında piyasaya sunduğu bebek maması ürünleriyle tanışan Nestlé, o tarihten bu yana tüketicileriyle kurduğu derin bağlarla Türkiye’deki faaliyetlerine devam etmektedir. Türkiye’deki ilk ofisini 1909 yılında İstanbul Karaköy’de açan Nestlé’nin Türkiye’deki gelişimi ilk’lerle, doludur.

Nestlé, Cumhuriyet’le birlikte Türkiye’deki hizmet ağını İzmir, Samsun ve Trabzon temsilcilikleriyle genişletti.

Nestlé, 1927 yılında, Cumhuriyet’in ilk sanayi yatırımlarından biri olan Türkiye’deki ilk çikolata fabrikasını İstanbul Feriköy’de açtı. Bütün dünyada olduğu gibi Türkiye’de de çikolata denildiğinde ilk akla gelen isim olan Nestlé, bilinen markalarının yanı sıra DAMAK ve CHOKELLA gibi Türk tüketicisine özel ürettiği markaları da tüketicinin beğenisine sundu.

İlklerin, yeniliklerin öncüsü Nestlé
Nestlé’nin tüketicilere hep yeni ürünler, yeni lezzetler sunma çabası Türkiye’de sonuçlarını verdi. 1932’de ilk fıstıklı çikolata DAMAK, 1968''de ilk sürme çikolata olan CHOKELLA, 1984''te ilk hazır kahve olan NESCAFE, 1986''da ilk çikolatalı toz içecek olan NESQUIK, 1989''da ilk kahve kreması COFEE MATE, 2001 yılında NESCAFE 3ü1 Arada ile devam etti.

2001 yılında NESTLE PURE LIFE markasıyla su kategorisine giren Nestlé, 2006 yılında ERİKLİ''yle birleşti. 2007 yılında Novartis Medikal Beslenme Birimi''ni bünyesine katan Nestlé, tıbbi beslenme alanında da faaliyet göstermeye başladı. Nestlé 2012 yılında Pfizer Nutrisyon''un global olarak satın alımını gerçekleştirerek Türkiye’nin bebek maması SMA markasını bünyesine kattı.

İş ortaklarıyla birlikte 7,000 kişiye iş imkânı sağlayan büyük bir aile
Tüketicilerin sevgisi ve ilgisiyle 100 yılı aşkın süredir Türkiye’ye hizmet etmeyi sürdüren Nestlé, üretimini, yüzde 92 oranında yerel hammadde kullanarak, Bursa Karacabey ve Bursa Kestel’deki 2 fabrikasında gerçekleştiriyor. 1927’de Türkiye’deki ilk çikolata fabrikasını kurarak üretime başlayan Nestlé, bugün 12 kategoride 800’ün üzerinde ürünü ve 50’ye yakın markasıyla faaliyet gösteriyor. Halen 3800 kişiye doğrudan, 7,000 üzerinde kişiye dolaylı olarak istihdam sağlıyor.

Sosyal Sorumluluk Anlayışıyla Ortak Değer Yaratıyor
Nestlé, dünya genelinde kırsal kalkınma, su ve beslenme alanlarında sürdürülebilirlik çalışmaları yürütmekte; toplumun sosyal ve ekonomik refahının yükselmesine katkıda bulunuyor. “Fıstığımız Bol Olsun Projesi” ile Gaziantep ve Şanlıurfa illerinde, Antep fıstığı üretiminde kalite ve verimliliği artırmaya yönelik somut hedeflerle yoluna devam ediyor. “Beslenebilirim Projesi” ile, Milli Eğitim Bakanlığı işbirliğinde ilköğretim çağındaki çocukların beslenme konusunda bilinçlenmelerini ve doğru beslenme alışkanlıkları kazanmalarını sağlıyor.', N'İyi Beslen,Mutlu Yaşa')
SET IDENTITY_INSERT [dbo].[tbl_Kurumsal] OFF
SET IDENTITY_INSERT [dbo].[tbl_Lojistik] ON 

INSERT [dbo].[tbl_Lojistik] ([lojistik_id], [lojistikTuru]) VALUES (1, N'Kara yolu')
INSERT [dbo].[tbl_Lojistik] ([lojistik_id], [lojistikTuru]) VALUES (2, N'Demir yolu')
INSERT [dbo].[tbl_Lojistik] ([lojistik_id], [lojistikTuru]) VALUES (3, N'Hava yolu')
INSERT [dbo].[tbl_Lojistik] ([lojistik_id], [lojistikTuru]) VALUES (4, N'Deniz yolu')
SET IDENTITY_INSERT [dbo].[tbl_Lojistik] OFF
SET IDENTITY_INSERT [dbo].[tbl_PersonelBilgileri] ON 

INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (3, N'Çağrı', N'DAAAc', CAST(0xBD180B00 AS Date), N'56479812345', N'Satış', N'6546465423', N'Maltepe', N'İstanbul', N'Maltepe', N'Türkiye', 3, N'designeruser@mail.com', N'C:\Users\cagri\OneDrive\Resimler\FOTOGRAFLAR\cv1.jpg')
INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (4, N'Developer', N'User', CAST(0xC3150B00 AS Date), N'98765432101', N'Satış', N'5646451324', N'Kartal', N'İstanbul', N'Kartal', N'Türkiye', 3, N'developeruser@mail.com', N'C:\Users\cagri\OneDrive\Resimler\FOTOGRAFLAR\IMG_5638.JPG')
INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (5, N'Designer', N'User', CAST(0xBD180B00 AS Date), N'56479812345', N'Satış', N'6546465423', N'Maltepe', N'İstanbul', N'Maltepe', N'Türkiye', 3, N'designeruser@mail.com', N'C:\Users\cagri\OneDrive\Resimler\cagri\_MG_4546.JPG')
INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (7, N'rrrrr', N'eeee', CAST(0x1E1C0B00 AS Date), N'12332112342', N'at', N'1233212233', N'aaaa', N'qqqqqq', N'sssss', N'Azerbeycqn', 2, N'eeeee', N'C:\Users\cagri\OneDrive\Resimler\cagri\IMG_4209.JPG')
INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (9, N'awww', N'aaaa', CAST(0x2F240B00 AS Date), N'12311112343', N'aaaaa', N'2233342211', N'aaaaa', N'aaaa', N'aaa', N'Azerbeycqn', 1, N'aaaa', N'C:\Users\cagri\OneDrive\Resimler\cagri\_MG_4548.JPG')
INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (11, N'adamsen', N'aaaa', CAST(0x2F240B00 AS Date), N'12311112343', N'aaaaa', N'2233342211', N'aaaaa', N'aaaa', N'aaa', N'Azerbeycqn', 1, N'aaaa', N'C:\Users\cagri\OneDrive\Resimler\FOTOGRAFLAR\IMG_5646.JPG')
INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (13, N'yetneeee', N'aaaa', CAST(0x2F240B00 AS Date), N'12311112343', N'aaaaa', N'2233342211', N'aaaaa', N'aaaa', N'aaa', N'Azerbeycqn', 1, N'aaaa', N'C:\Users\cagri\OneDrive\Resimler\cagri\_MG_4478.JPG')
INSERT [dbo].[tbl_PersonelBilgileri] ([per_id], [perAdi], [perSoyadi], [perDogumTarihi], [perTcno], [perUnvan], [perTelefon], [perAdres], [peril], [perilce], [perUlke], [departman_id], [perMail], [perResim]) VALUES (14, N'hazar', N'aaaa', CAST(0x2F240B00 AS Date), N'12311112343', N'aaaaa', N'2233342211', N'aaaaa', N'aaaa', N'aaa', N'Azerbeycqn', 1, N'aaaa', N'C:\Users\cagri\OneDrive\Resimler\FOTOGRAFLAR\IMG_5625.jpg')
SET IDENTITY_INSERT [dbo].[tbl_PersonelBilgileri] OFF
SET IDENTITY_INSERT [dbo].[tbl_Satis] ON 

INSERT [dbo].[tbl_Satis] ([satis_id], [FirmaAdi], [SatisTarihi], [TeslimAdresi], [TeslimSehir], [TeslimUlke], [TeslimTarihi], [urun_id], [satAdet], [satisDurumu_id], [SatisTutari]) VALUES (4, N'Ulker', CAST(0xA13F0B00 AS Date), N'AA MAH. A SK. 10 AVCILAR', N'ISTANBUL', N'Türkiye   ', CAST(0xAC3F0B00 AS Date), 2, 5, 1, 20.0000)
INSERT [dbo].[tbl_Satis] ([satis_id], [FirmaAdi], [SatisTarihi], [TeslimAdresi], [TeslimSehir], [TeslimUlke], [TeslimTarihi], [urun_id], [satAdet], [satisDurumu_id], [SatisTutari]) VALUES (5, N'FIBO', CAST(0xA23F0B00 AS Date), N'hel.mah.ca sk.10-a

Seattle', N'helsinki', N'Finlandiya', CAST(0xB93F0B00 AS Date), 3, 11, 1, 44.0000)
INSERT [dbo].[tbl_Satis] ([satis_id], [FirmaAdi], [SatisTarihi], [TeslimAdresi], [TeslimSehir], [TeslimUlke], [TeslimTarihi], [urun_id], [satAdet], [satisDurumu_id], [SatisTutari]) VALUES (6, N'Ekinox', CAST(0xA33F0B00 AS Date), N'ZZZ MAH.', N'Edirne', N'Türkiye   ', CAST(0xB93F0B00 AS Date), 3, 8, 1, 32.0000)
INSERT [dbo].[tbl_Satis] ([satis_id], [FirmaAdi], [SatisTarihi], [TeslimAdresi], [TeslimSehir], [TeslimUlke], [TeslimTarihi], [urun_id], [satAdet], [satisDurumu_id], [SatisTutari]) VALUES (10, N'mmmm', CAST(0xA43F0B00 AS Date), N'kkkkkkk', N'', N'          ', CAST(0xA43F0B00 AS Date), 2, 0, 1, 0.0000)
INSERT [dbo].[tbl_Satis] ([satis_id], [FirmaAdi], [SatisTarihi], [TeslimAdresi], [TeslimSehir], [TeslimUlke], [TeslimTarihi], [urun_id], [satAdet], [satisDurumu_id], [SatisTutari]) VALUES (11, N'şakir bey', CAST(0xA43F0B00 AS Date), N'Maltepe', N'İstanbul', N'Türkiye   ', CAST(0xA43F0B00 AS Date), 4, 4, 1, 32.0000)
SET IDENTITY_INSERT [dbo].[tbl_Satis] OFF
SET IDENTITY_INSERT [dbo].[tbl_SatisDurumu] ON 

INSERT [dbo].[tbl_SatisDurumu] ([satisDurumu_id], [satisDurumu]) VALUES (1, N'Onaylandı')
INSERT [dbo].[tbl_SatisDurumu] ([satisDurumu_id], [satisDurumu]) VALUES (2, N'Teklif Ver')
SET IDENTITY_INSERT [dbo].[tbl_SatisDurumu] OFF
SET IDENTITY_INSERT [dbo].[tbl_Sevkiyat] ON 

INSERT [dbo].[tbl_Sevkiyat] ([sev_id], [satis_id], [lojistik_id], [urun_id], [sevAdres]) VALUES (1, 4, 1, 2, N'Harmandere Mah.Ambar sk.
No:75 Atarlar/İstanbul')
INSERT [dbo].[tbl_Sevkiyat] ([sev_id], [satis_id], [lojistik_id], [urun_id], [sevAdres]) VALUES (3, 6, 3, 2, N'abii')
INSERT [dbo].[tbl_Sevkiyat] ([sev_id], [satis_id], [lojistik_id], [urun_id], [sevAdres]) VALUES (4, 5, 1, 2, N'ccccccccccccccccc')
SET IDENTITY_INSERT [dbo].[tbl_Sevkiyat] OFF
SET IDENTITY_INSERT [dbo].[tbl_Teklif] ON 

INSERT [dbo].[tbl_Teklif] ([teklif_id], [teklifNo], [tekFirmaAdi], [urun_id], [tekUrunMiktar], [teklifTutar]) VALUES (3, N'A2', N'Bakkal Köy', 5, 9, 72.0000)
INSERT [dbo].[tbl_Teklif] ([teklif_id], [teklifNo], [tekFirmaAdi], [urun_id], [tekUrunMiktar], [teklifTutar]) VALUES (5, N'A3', N'ZORLU GIDA', 1002, 28, 280.0000)
INSERT [dbo].[tbl_Teklif] ([teklif_id], [teklifNo], [tekFirmaAdi], [urun_id], [tekUrunMiktar], [teklifTutar]) VALUES (19, N'A1', N'dd', 4, 10, 80.0000)
INSERT [dbo].[tbl_Teklif] ([teklif_id], [teklifNo], [tekFirmaAdi], [urun_id], [tekUrunMiktar], [teklifTutar]) VALUES (20, N'A4', N'dd', 4, 10, 80.0000)
SET IDENTITY_INSERT [dbo].[tbl_Teklif] OFF
SET IDENTITY_INSERT [dbo].[tbl_UrunBilgisi] ON 

INSERT [dbo].[tbl_UrunBilgisi] ([urun_id], [urun_adi], [uruntur_id], [urunUretimTarihi], [urunFiyati], [urunMiktari], [depo_id]) VALUES (2, N'Nesquik', 1, CAST(0x9F3F0B00 AS Date), 5.0000, 5, 4)
INSERT [dbo].[tbl_UrunBilgisi] ([urun_id], [urun_adi], [uruntur_id], [urunUretimTarihi], [urunFiyati], [urunMiktari], [depo_id]) VALUES (3, N'Haribo', 6, CAST(0x9F3F0B00 AS Date), 4.0000, 1, 5)
INSERT [dbo].[tbl_UrunBilgisi] ([urun_id], [urun_adi], [uruntur_id], [urunUretimTarihi], [urunFiyati], [urunMiktari], [depo_id]) VALUES (4, N'Nesfit', 7, CAST(0x9F3F0B00 AS Date), 8.0000, 296, 4)
INSERT [dbo].[tbl_UrunBilgisi] ([urun_id], [urun_adi], [uruntur_id], [urunUretimTarihi], [urunFiyati], [urunMiktari], [depo_id]) VALUES (5, N'Corn Flakes', 7, CAST(0x9F3F0B00 AS Date), 8.0000, 200, 4)
INSERT [dbo].[tbl_UrunBilgisi] ([urun_id], [urun_adi], [uruntur_id], [urunUretimTarihi], [urunFiyati], [urunMiktari], [depo_id]) VALUES (1002, N'Damak', 1, CAST(0xA23F0B00 AS Date), 10.0000, 100, 5)
SET IDENTITY_INSERT [dbo].[tbl_UrunBilgisi] OFF
SET IDENTITY_INSERT [dbo].[tbl_UrunTuru] ON 

INSERT [dbo].[tbl_UrunTuru] ([uruntur_id], [uruntur_adi]) VALUES (1, N'Çikolata  ')
INSERT [dbo].[tbl_UrunTuru] ([uruntur_id], [uruntur_adi]) VALUES (2, N'Gofret    ')
INSERT [dbo].[tbl_UrunTuru] ([uruntur_id], [uruntur_adi]) VALUES (3, N'Süt       ')
INSERT [dbo].[tbl_UrunTuru] ([uruntur_id], [uruntur_adi]) VALUES (4, N'Dondurma  ')
INSERT [dbo].[tbl_UrunTuru] ([uruntur_id], [uruntur_adi]) VALUES (5, N'Yoğurt    ')
INSERT [dbo].[tbl_UrunTuru] ([uruntur_id], [uruntur_adi]) VALUES (6, N'Jelibon   ')
INSERT [dbo].[tbl_UrunTuru] ([uruntur_id], [uruntur_adi]) VALUES (7, N'Tahıl     ')
SET IDENTITY_INSERT [dbo].[tbl_UrunTuru] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_Teklif]    Script Date: 13.05.2019 19:25:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_Teklif] ON [dbo].[tbl_Teklif]
(
	[teklifNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_İnsanKaynaklari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_İnsanKaynaklari_tbl_BasvuruForm] FOREIGN KEY([basvuru_id])
REFERENCES [dbo].[tbl_BasvuruForm] ([basvuru_id])
GO
ALTER TABLE [dbo].[tbl_İnsanKaynaklari] CHECK CONSTRAINT [FK_tbl_İnsanKaynaklari_tbl_BasvuruForm]
GO
ALTER TABLE [dbo].[tbl_İnsanKaynaklari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_İnsanKaynaklari_tbl_PersonelBilgileri] FOREIGN KEY([per_id])
REFERENCES [dbo].[tbl_PersonelBilgileri] ([per_id])
GO
ALTER TABLE [dbo].[tbl_İnsanKaynaklari] CHECK CONSTRAINT [FK_tbl_İnsanKaynaklari_tbl_PersonelBilgileri]
GO
ALTER TABLE [dbo].[tbl_PersonelBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PersonelBilgileri_tbl_Departman] FOREIGN KEY([departman_id])
REFERENCES [dbo].[tbl_Departman] ([departman_id])
GO
ALTER TABLE [dbo].[tbl_PersonelBilgileri] CHECK CONSTRAINT [FK_tbl_PersonelBilgileri_tbl_Departman]
GO
ALTER TABLE [dbo].[tbl_Satis]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Satis_tbl_SatisDurumu] FOREIGN KEY([satisDurumu_id])
REFERENCES [dbo].[tbl_SatisDurumu] ([satisDurumu_id])
GO
ALTER TABLE [dbo].[tbl_Satis] CHECK CONSTRAINT [FK_tbl_Satis_tbl_SatisDurumu]
GO
ALTER TABLE [dbo].[tbl_Satis]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Satis_tbl_UrunBilgisi1] FOREIGN KEY([urun_id])
REFERENCES [dbo].[tbl_UrunBilgisi] ([urun_id])
GO
ALTER TABLE [dbo].[tbl_Satis] CHECK CONSTRAINT [FK_tbl_Satis_tbl_UrunBilgisi1]
GO
ALTER TABLE [dbo].[tbl_Sevkiyat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sevkiyat_tbl_Lojistik] FOREIGN KEY([lojistik_id])
REFERENCES [dbo].[tbl_Lojistik] ([lojistik_id])
GO
ALTER TABLE [dbo].[tbl_Sevkiyat] CHECK CONSTRAINT [FK_tbl_Sevkiyat_tbl_Lojistik]
GO
ALTER TABLE [dbo].[tbl_Sevkiyat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sevkiyat_tbl_Satis] FOREIGN KEY([satis_id])
REFERENCES [dbo].[tbl_Satis] ([satis_id])
GO
ALTER TABLE [dbo].[tbl_Sevkiyat] CHECK CONSTRAINT [FK_tbl_Sevkiyat_tbl_Satis]
GO
ALTER TABLE [dbo].[tbl_Sevkiyat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sevkiyat_tbl_UrunBilgisi] FOREIGN KEY([urun_id])
REFERENCES [dbo].[tbl_UrunBilgisi] ([urun_id])
GO
ALTER TABLE [dbo].[tbl_Sevkiyat] CHECK CONSTRAINT [FK_tbl_Sevkiyat_tbl_UrunBilgisi]
GO
ALTER TABLE [dbo].[tbl_Teklif]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Teklif_tbl_UrunBilgisi] FOREIGN KEY([urun_id])
REFERENCES [dbo].[tbl_UrunBilgisi] ([urun_id])
GO
ALTER TABLE [dbo].[tbl_Teklif] CHECK CONSTRAINT [FK_tbl_Teklif_tbl_UrunBilgisi]
GO
ALTER TABLE [dbo].[tbl_UrunBilgisi]  WITH CHECK ADD  CONSTRAINT [FK_tbl_UrunBilgisi_tbl_Depolama] FOREIGN KEY([depo_id])
REFERENCES [dbo].[tbl_Depolama] ([depo_id])
GO
ALTER TABLE [dbo].[tbl_UrunBilgisi] CHECK CONSTRAINT [FK_tbl_UrunBilgisi_tbl_Depolama]
GO
ALTER TABLE [dbo].[tbl_UrunBilgisi]  WITH CHECK ADD  CONSTRAINT [FK_tbl_UrunBilgisi_tbl_UrunTuru] FOREIGN KEY([uruntur_id])
REFERENCES [dbo].[tbl_UrunTuru] ([uruntur_id])
GO
ALTER TABLE [dbo].[tbl_UrunBilgisi] CHECK CONSTRAINT [FK_tbl_UrunBilgisi_tbl_UrunTuru]
GO
/****** Object:  Trigger [dbo].[trg_SatisStok]    Script Date: 13.05.2019 19:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_SatisStok]
ON [dbo].[tbl_Satis]
AFTER INSERT 
AS
DECLARE @urunId INT
DECLARE @satisAdet INT 
SELECT @urunId=urun_id,@satisAdet=satAdet FROM inserted
UPDATE tbl_UrunBilgisi
SET urunMiktari=urunMiktari-@satisAdet
WHERE urun_id=@urunId

GO
USE [master]
GO
ALTER DATABASE [db_Nestle2] SET  READ_WRITE 
GO
