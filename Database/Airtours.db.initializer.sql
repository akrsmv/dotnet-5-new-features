CREATE TABLE [dbo].[Country] (
    [Id]       INT NOT NULL IDENTITY,
    [Name]     VARCHAR(10) NOT NULL UNIQUE,
    [Code]     VARCHAR(10) NOT NULL UNIQUE,
    [Currency] VARCHAR(10) NOT NULL UNIQUE,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

