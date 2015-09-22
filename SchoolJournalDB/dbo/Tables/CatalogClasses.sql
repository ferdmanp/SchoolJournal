CREATE TABLE [dbo].[CatalogClasses] (
    [Id]            INT      IDENTITY (1, 1) NOT NULL,
    [SchoolId]      INT      NOT NULL,
    [ClassNum]      INT      NULL,
    [ClassLetter]   CHAR (1) NULL,
    [ClassYear]     INT      NULL,
    [FullClassName] AS       ((((CONVERT([char](2),[ClassNum])+[ClassLetter])+'(')+CONVERT([char](1),[ClassYear]))+')'),
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[CatalogSchools] ([Id])
);

