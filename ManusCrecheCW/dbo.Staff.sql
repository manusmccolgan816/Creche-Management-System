CREATE TABLE [dbo].[Staff] (
    [StaffID]  INT        IDENTITY (1, 1) NOT NULL,
    [Forename] VARCHAR (30) NOT NULL,
    [Surname]  VARCHAR (30) NOT NULL,
    [TelNo]    VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([StaffID] ASC)
);

