USE master
GO
CREATE DATABASE KuzeyYeli
GO
CREATE TABLE Kategoriler(
ID INT PRIMARY KEY IDENTITY,
KategoriAdi NVARCHAR(30) unique NOT NULL,
Aciklama NVARCHAR(max),
EklenmeTarihi SMALLDATETIME DEFAULT GETDATE()
)
GO 
CREATE TABLE Urunler(
ID INT PRIMARY KEY IDENTITY,
UrunAdi NVARCHAR(75) UNIQUE NOT NULL,
Fiyat DECIMAL(7,2) DEFAULT 0 CHECK (Fiyat>=0),
Stok INT DEFAULT 0 CHECK (Stok>=0),
KategoriID INT  NULL REFERENCES Kategoriler(ID),
EklenmeTarihi SMALLDATETIME DEFAULT GETDATE(),
AktifMi BIT DEFAULT 1
)
USE KuzeyYeli
INSERT INTO Kategoriler (KategoriAdi,Aciklama) VALUES ('Meyve','Meyveler')
INSERT INTO Kategoriler (KategoriAdi,Aciklama) VALUES ('Sebze','Sebzeler')

ALTER TABLE Kategoriler
ALTER COLUMN EklenmeTarihi smalldatetime NOT NULL 

ALTER TABLE Kategoriler
ALTER COLUMN EklenmeTarihi  SMALLDATETIME NOT null