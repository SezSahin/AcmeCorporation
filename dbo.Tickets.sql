USE [AcmeCorporationDb]
GO

/****** Object: Table [dbo].[Tickets] Script Date: 02-06-2019 18:32:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tickets] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [FirstName]    NVARCHAR (MAX)   NULL,
    [LastName]     NVARCHAR (50)    NULL,
    [Email]        NVARCHAR (MAX)   NULL,
    [PhoneNumber]  NVARCHAR (11)    NULL,
    [DateOfBirth]  NVARCHAR (MAX)   NULL,
    [SerialNumber] NVARCHAR (MAX)   NOT NULL
);


