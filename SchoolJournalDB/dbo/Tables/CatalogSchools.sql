CREATE TABLE [dbo].[CatalogSchools] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [SchoolName] NVARCHAR (250) NULL,
    [AddDate]    DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

