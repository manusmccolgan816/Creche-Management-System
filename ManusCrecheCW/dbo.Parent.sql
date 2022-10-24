CREATE TABLE [dbo].[Parent] (
    [ParentID] INT        IDENTITY (1, 1) NOT NULL,
    [Forename] VARCHAR(30) NOT NULL,
    [Surname]  VARCHAR(30) NOT NULL,
    [TelNo]    VARCHAR(30) NULL,
    [City]     VARCHAR (30) NOT NULL,
    [Postcode] VARCHAR (30) NOT NULL,
    [Address]  VARCHAR (50) NOT NULL,
    [Deleted]  BIT        NULL,
    PRIMARY KEY CLUSTERED ([ParentID] ASC)
);

