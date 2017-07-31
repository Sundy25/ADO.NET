
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/04/2017 12:14:23
-- Generated from EDMX file: D:\Yazılım Kayıtları\03 ADO\DataAccess502s Disconnect kısmı çalışmıyor\DataAccess502s\KuzeyModelIF\KuzeyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [modeltest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KategoriSet'
CREATE TABLE [dbo].[KategoriSet] (
    [KategoriID] int IDENTITY(1,1) NOT NULL,
    [KategoriAdi] nvarchar(max)  NOT NULL,
    [Aciklama] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UrunSet'
CREATE TABLE [dbo].[UrunSet] (
    [UrunID] int IDENTITY(1,1) NOT NULL,
    [UrunAdi] nvarchar(50)  NOT NULL,
    [Fiyat] decimal(7,2)  NOT NULL,
    [KategoriID] int  NOT NULL,
    [KategoriKategoriID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [KategoriID] in table 'KategoriSet'
ALTER TABLE [dbo].[KategoriSet]
ADD CONSTRAINT [PK_KategoriSet]
    PRIMARY KEY CLUSTERED ([KategoriID] ASC);
GO

-- Creating primary key on [UrunID] in table 'UrunSet'
ALTER TABLE [dbo].[UrunSet]
ADD CONSTRAINT [PK_UrunSet]
    PRIMARY KEY CLUSTERED ([UrunID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KategoriKategoriID] in table 'UrunSet'
ALTER TABLE [dbo].[UrunSet]
ADD CONSTRAINT [FK_KategoriUrun]
    FOREIGN KEY ([KategoriKategoriID])
    REFERENCES [dbo].[KategoriSet]
        ([KategoriID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KategoriUrun'
CREATE INDEX [IX_FK_KategoriUrun]
ON [dbo].[UrunSet]
    ([KategoriKategoriID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------