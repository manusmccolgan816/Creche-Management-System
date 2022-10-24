CREATE TABLE [dbo].[Booking] (
    [BookingID] INT          NOT NULL,
    [KidID]     INT          NOT NULL,
    [GroupID]   INT          NOT NULL,
    [StartDate] VARCHAR (30) NOT NULL,
    [EndDate]   VARCHAR (30) NOT NULL,
    [Mon]       BIT          NULL,
    [Tue]       BIT          NULL,
    [Wed]       BIT          NULL,
    [Thurs]     BIT          NULL,
    [Fri]       BIT          NULL,
    [Deleted] BIT NULL, 
    PRIMARY KEY CLUSTERED ([BookingID] ASC)
);

