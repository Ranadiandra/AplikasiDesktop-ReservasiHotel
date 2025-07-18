USE [ProjekAkhir_AplikasiHotel]
GO
/****** Object:  Table [dbo].[DataCustomer]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataCustomer](
	[Id_Customer] [int] IDENTITY(1,1) NOT NULL,
	[NIK] [varchar](16) NULL,
	[Nama] [varchar](50) NULL,
	[Alamat] [varchar](50) NULL,
	[No_HP] [varchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KelolaKamar]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KelolaKamar](
	[Id_Kamar] [int] IDENTITY(1,1) NOT NULL,
	[nokamar] [int] NULL,
	[tipekamar] [varchar](20) NULL,
	[fasilitas] [varchar](200) NULL,
	[harga] [decimal](18, 2) NULL,
	[status] [varchar](20) NULL,
	[gambar] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Kamar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogKamar]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogKamar](
	[Id_Log] [int] IDENTITY(1,1) NOT NULL,
	[aksi] [varchar](50) NULL,
	[nokamar] [int] NULL,
	[tipekamar] [varchar](20) NULL,
	[fasilitas] [varchar](200) NULL,
	[harga] [decimal](18, 2) NULL,
	[status] [varchar](20) NULL,
	[waktu] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Log] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id_Menu] [int] IDENTITY(1,1) NOT NULL,
	[Nama_Menu] [varchar](50) NULL,
	[Kategori] [varchar](50) NULL,
	[Harga] [decimal](18, 2) NULL,
	[Stok] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pengguna]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pengguna](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pesanan]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pesanan](
	[Id_Pesanan] [int] IDENTITY(1,1) NOT NULL,
	[Id_Menu] [int] NULL,
	[Id_Customer] [int] NULL,
	[Total_harga] [decimal](18, 2) NULL,
	[PPN] [decimal](18, 2) NULL,
	[Total_Bayar] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pesanan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservasi]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservasi](
	[Id_Reservasi] [int] IDENTITY(1,1) NOT NULL,
	[Id_Customer] [int] NULL,
	[Id_Kamar] [int] NULL,
	[Tanggal_Checkin] [date] NULL,
	[Tanggal_Checkout] [date] NULL,
	[HargaPerHari] [decimal](18, 2) NULL,
	[PPN] [decimal](18, 2) NULL,
	[Total_Harga] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Reservasi] PRIMARY KEY CLUSTERED 
(
	[Id_Reservasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaksi]    Script Date: 11/06/2025 22:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaksi](
	[Id_Transaksi] [int] IDENTITY(1,1) NOT NULL,
	[Id_Customer] [int] NULL,
	[Id_Reservasi] [int] NULL,
	[Metode_Pembayaran] [varchar](50) NULL,
	[Total_Bayar] [decimal](18, 2) NULL,
	[Uang_Bayar] [decimal](18, 2) NULL,
	[Kembalian] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Transaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pesanan]  WITH CHECK ADD FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[DataCustomer] ([Id_Customer])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Pesanan]  WITH CHECK ADD FOREIGN KEY([Id_Menu])
REFERENCES [dbo].[Menu] ([Id_Menu])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Reservasi]  WITH NOCHECK ADD  CONSTRAINT [FK_Reservasi_DataCustomer] FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[DataCustomer] ([Id_Customer])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Reservasi] CHECK CONSTRAINT [FK_Reservasi_DataCustomer]
GO
ALTER TABLE [dbo].[Reservasi]  WITH CHECK ADD  CONSTRAINT [FK_Reservasi_Kamar] FOREIGN KEY([Id_Kamar])
REFERENCES [dbo].[KelolaKamar] ([Id_Kamar])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Reservasi] CHECK CONSTRAINT [FK_Reservasi_Kamar]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_Customer] FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[DataCustomer] ([Id_Customer])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_Customer]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_Reservasi] FOREIGN KEY([Id_Reservasi])
REFERENCES [dbo].[Reservasi] ([Id_Reservasi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_Reservasi]
GO
