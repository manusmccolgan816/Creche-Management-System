CREATE TABLE [dbo].[StaffGroup] (
    [StaffGroupID] INT          NOT NULL,
    [StaffID]      INT          NOT NULL,
    [GroupID]      INT          NOT NULL,
    [Date]         VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([StaffGroupID] ASC),	
	CONSTRAINT [StaffGroupIDForeignKey] FOREIGN KEY ([StaffID]) REFERENCES [dbo].[Staff] ([StaffID])
);

