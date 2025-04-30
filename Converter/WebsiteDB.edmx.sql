
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2023 14:47:32
-- Generated from EDMX file: F:\MyProjects\Gurukul\Sangli Website\Converter\WebsiteDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [microte2_ZPSangli22_23];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Result]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Result];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [SudentId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Taluka] nvarchar(max)  NULL,
    [Dist] nvarchar(max)  NULL,
    [standard] int  NULL,
    [rollnumber] int  NULL,
    [barcode1] nvarchar(max)  NULL,
    [barcode2] nvarchar(max)  NULL,
    [correctans1] int  NULL,
    [correctans2] int  NULL,
    [marks1] int  NULL,
    [marks2] int  NULL,
    [staterank] int  NULL,
    [distrank] int  NOT NULL,
    [talukarank] int  NULL,
    [percentage] float  NULL,
    [total] int  NULL,
    [DateOfBirth] datetime  NULL,
    [SchoolName] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SudentId] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([SudentId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------