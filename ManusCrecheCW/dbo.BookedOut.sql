CREATE TABLE [dbo].[BookedOut] (
    [BookedOutID] INT          NOT NULL,
    [BookingID]   INT          NOT NULL,
    [Date]        VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([BookedOutID] ASC),
	CONSTRAINT [BookingIDForeignKey] FOREIGN KEY ([BookingID]) REFERENCES [dbo].[Booking] ([BookingID])
);

