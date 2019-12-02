CREATE TABLE [dbo].[Computer102146016]
(
	[Number] int,
    [AssembledYear] int,
    [Building] VARCHAR(2),
    [RoomNo] int,
    FOREIGN KEY (Building, RoomNo) REFERENCES Room102146016(Building, RoomNo),
    Primary Key ([Number], Building, RoomNo)
)
