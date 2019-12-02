CREATE TABLE [dbo].[Class102146016]
(
	[ClassCode] varchar(6) PRIMARY KEY,
    [Name] varchar(50),
    [Building] VARCHAR(2),
    [RoomNo] int,
    FOREIGN KEY (Building, RoomNo) REFERENCES Room102146016(Building, RoomNo)
)
