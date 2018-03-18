
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/05/2018 13:48:07
-- Generated from EDMX file: K:\MyDVDs\MyDVDs\BuildMyDVDs\MyDVDs\MyDVDsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyDVDs];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CaseToDisc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Discs] DROP CONSTRAINT [FK_CaseToDisc];
GO
IF OBJECT_ID(N'[dbo].[FK_DVDIconToCase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cases] DROP CONSTRAINT [FK_DVDIconToCase];
GO
IF OBJECT_ID(N'[dbo].[FK_StorageBoxToCase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cases] DROP CONSTRAINT [FK_StorageBoxToCase];
GO
IF OBJECT_ID(N'[dbo].[FK_DiscToContents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents] DROP CONSTRAINT [FK_DiscToContents];
GO
IF OBJECT_ID(N'[dbo].[FK_DVDIconToContents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents] DROP CONSTRAINT [FK_DVDIconToContents];
GO
IF OBJECT_ID(N'[dbo].[FK_GenreContents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents] DROP CONSTRAINT [FK_GenreContents];
GO
IF OBJECT_ID(N'[dbo].[FK_RatingToContents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents] DROP CONSTRAINT [FK_RatingToContents];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cases];
GO
IF OBJECT_ID(N'[dbo].[Contents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contents];
GO
IF OBJECT_ID(N'[dbo].[Discs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discs];
GO
IF OBJECT_ID(N'[dbo].[DVDIcons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DVDIcons];
GO
IF OBJECT_ID(N'[dbo].[Genres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Genres];
GO
IF OBJECT_ID(N'[dbo].[Ratings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ratings];
GO
IF OBJECT_ID(N'[dbo].[StorageBoxes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StorageBoxes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cases'
CREATE TABLE [dbo].[Cases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CaseNumber] int  NOT NULL,
    [CaseType] nvarchar(25)  NOT NULL,
    [TotalDiscs] int  NOT NULL,
    [Notes] nvarchar(250)  NOT NULL,
    [IsABoxset] bit  NOT NULL,
    [Title] nvarchar(250)  NOT NULL,
    [StorageBoxId] int  NOT NULL,
    [DVDIconId] int  NOT NULL
);
GO

-- Creating table 'Contents'
CREATE TABLE [dbo].[Contents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ContentNumber] int  NOT NULL,
    [Notes] nvarchar(250)  NOT NULL,
    [Title] nvarchar(250)  NOT NULL,
    [Year] nvarchar(25)  NOT NULL,
    [Cast] nvarchar(250)  NOT NULL,
    [Director] nvarchar(250)  NOT NULL,
    [DiscId] int  NOT NULL,
    [GenreId] int  NOT NULL,
    [RatingId] int  NOT NULL,
    [DVDIconId] int  NOT NULL
);
GO

-- Creating table 'Discs'
CREATE TABLE [dbo].[Discs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DiscNumber] int  NOT NULL,
    [TotalContents] int  NOT NULL,
    [Notes] nvarchar(250)  NOT NULL,
    [IsACollection] bit  NOT NULL,
    [Title] nvarchar(250)  NOT NULL,
    [CaseId] int  NOT NULL
);
GO

-- Creating table 'DVDIcons'
CREATE TABLE [dbo].[DVDIcons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(250)  NOT NULL,
    [Icon] varbinary(max)  NOT NULL
);
GO

-- Creating table 'Genres'
CREATE TABLE [dbo].[Genres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'Ratings'
CREATE TABLE [dbo].[Ratings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MPAACode] nvarchar(50)  NOT NULL,
    [Description] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'StorageBoxes'
CREATE TABLE [dbo].[StorageBoxes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BoxNumber] int  NOT NULL,
    [BoxType] nvarchar(25)  NOT NULL,
    [TotalCases] int  NOT NULL,
    [Notes] nvarchar(250)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cases'
ALTER TABLE [dbo].[Cases]
ADD CONSTRAINT [PK_Cases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [PK_Contents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Discs'
ALTER TABLE [dbo].[Discs]
ADD CONSTRAINT [PK_Discs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DVDIcons'
ALTER TABLE [dbo].[DVDIcons]
ADD CONSTRAINT [PK_DVDIcons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Genres'
ALTER TABLE [dbo].[Genres]
ADD CONSTRAINT [PK_Genres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ratings'
ALTER TABLE [dbo].[Ratings]
ADD CONSTRAINT [PK_Ratings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StorageBoxes'
ALTER TABLE [dbo].[StorageBoxes]
ADD CONSTRAINT [PK_StorageBoxes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CaseId] in table 'Discs'
ALTER TABLE [dbo].[Discs]
ADD CONSTRAINT [FK_CaseToDisc]
    FOREIGN KEY ([CaseId])
    REFERENCES [dbo].[Cases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CaseToDisc'
CREATE INDEX [IX_FK_CaseToDisc]
ON [dbo].[Discs]
    ([CaseId]);
GO

-- Creating foreign key on [DVDIconId] in table 'Cases'
ALTER TABLE [dbo].[Cases]
ADD CONSTRAINT [FK_DVDIconToCase]
    FOREIGN KEY ([DVDIconId])
    REFERENCES [dbo].[DVDIcons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DVDIconToCase'
CREATE INDEX [IX_FK_DVDIconToCase]
ON [dbo].[Cases]
    ([DVDIconId]);
GO

-- Creating foreign key on [StorageBoxId] in table 'Cases'
ALTER TABLE [dbo].[Cases]
ADD CONSTRAINT [FK_StorageBoxToCase]
    FOREIGN KEY ([StorageBoxId])
    REFERENCES [dbo].[StorageBoxes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StorageBoxToCase'
CREATE INDEX [IX_FK_StorageBoxToCase]
ON [dbo].[Cases]
    ([StorageBoxId]);
GO

-- Creating foreign key on [DiscId] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [FK_DiscToContents]
    FOREIGN KEY ([DiscId])
    REFERENCES [dbo].[Discs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiscToContents'
CREATE INDEX [IX_FK_DiscToContents]
ON [dbo].[Contents]
    ([DiscId]);
GO

-- Creating foreign key on [DVDIconId] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [FK_DVDIconToContents]
    FOREIGN KEY ([DVDIconId])
    REFERENCES [dbo].[DVDIcons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DVDIconToContents'
CREATE INDEX [IX_FK_DVDIconToContents]
ON [dbo].[Contents]
    ([DVDIconId]);
GO

-- Creating foreign key on [GenreId] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [FK_GenreContents]
    FOREIGN KEY ([GenreId])
    REFERENCES [dbo].[Genres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GenreContents'
CREATE INDEX [IX_FK_GenreContents]
ON [dbo].[Contents]
    ([GenreId]);
GO

-- Creating foreign key on [RatingId] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [FK_RatingToContents]
    FOREIGN KEY ([RatingId])
    REFERENCES [dbo].[Ratings]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RatingToContents'
CREATE INDEX [IX_FK_RatingToContents]
ON [dbo].[Contents]
    ([RatingId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------