CREATE TABLE [dbo].[Group] (
    [GroupID]   INT        NOT NULL,
    [MaxNoKids] INT        NOT NULL,
    [AgeRange]  VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([GroupID] ASC)
);

