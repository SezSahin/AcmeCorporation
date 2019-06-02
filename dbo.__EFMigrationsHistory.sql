USE [AcmeCorporationDb]
GO

/****** Object: Table [dbo].[__EFMigrationsHistory] Script Date: 02-06-2019 18:33:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[__EFMigrationsHistory] (
    [MigrationId]    NVARCHAR (150) NOT NULL,
    [ProductVersion] NVARCHAR (32)  NOT NULL
);


