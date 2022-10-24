CREATE TABLE [dbo].[Kid] (
    [KidID]       INT          NOT NULL,
    [ParentID]    INT          NOT NULL,
    [Forename]    VARCHAR(30)   NOT NULL,
    [Surname]     VARCHAR(30)   NOT NULL,
    [DateOfBirth] VARCHAR (30) NOT NULL,
    [Deleted]     BIT          NULL,
    PRIMARY KEY CLUSTERED ([KidID] ASC),
    CONSTRAINT [ParentIDForeignKey] FOREIGN KEY ([ParentID]) REFERENCES [dbo].[Parent] ([ParentID])
);

