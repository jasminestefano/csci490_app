CREATE TABLE [dbo].[Table4]
(
	[TicketID] INT NOT NULL PRIMARY KEY, 
    [PassengerID] INT NULL, 
    [TrainID] INT NULL, 
    [PurchaseTime] DATETIME NULL, 
    [SeatNumber] VARCHAR(50) NULL, 
    [Fare] DECIMAL(10, 2) NULL
)
