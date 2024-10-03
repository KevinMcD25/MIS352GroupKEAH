use AdventureWV
GO



create table [LANDMARKS](
[LID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
[LName] nvarchar(255) NOT NULL,
[LType] nvarchar(255) NOT NULL,
)
GO

create table [ACTIVITIES] (
    [AID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [AName] nvarchar(255) NOT NULL,
    [LID] int NOT NULL,  
    FOREIGN KEY ([LID]) REFERENCES [LANDMARKS]([LID])
)
GO

create table  [HOSPITALITY] (
[HID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
[HName] nvarchar(255) NOT NULL,
[HType] nvarchar(255) NOT NULL,
[HRating] int,
[LID] int NOT NULL,
 FOREIGN KEY ([LID]) REFERENCES [LANDMARKS]([LID])
)
GO

create table [TRAVELPLAN] (
[PID] int primary key not null,
[HID] int not null,
[AID] int not null,
[PDatetime] datetime not null,
FOREIGN KEY ([HID]) REFERENCES [HOSPITALITY]([HID]),
FOREIGN KEY ([AID]) REFERENCES [ACTIVITIES]([AID])
)
GO

create table [USERDATA] (
[UID] int primary key not null,
[PID] int not null,
[UFName] nvarchar(255) not null,
[ULName] nvarchar(255) not null,
[UEmail] nvarchar(255) not null,
[UPhone] int not null
FOREIGN KEY ([PID]) REFERENCES [TRAVELPLAN]([PID])

)
GO

DROP TABLE USERDATA
GO
DROP TABLE [PLAN]
GO

-- Insert into LANDMARKS
INSERT INTO [LANDMARKS] ([LName], [LType]) VALUES
('Grand Canyon', 'Natural'),
('Statue of Liberty', 'Monument'),
('Eiffel Tower', 'Monument');

-- Insert into ACTIVITIES
INSERT INTO [ACTIVITIES] ([AName], [LID]) VALUES
('Hiking', 1),  -- Hiking at Grand Canyon
('Sightseeing', 2),  -- Sightseeing at Statue of Liberty
('Photography', 3);  -- Photography at Eiffel Tower

-- Insert into HOSPITALITY
INSERT INTO [HOSPITALITY] ([HName], [HType], [HRating], [LID]) VALUES
('Canyon Hotel', 'Hotel', 5, 1),  -- Associated with Grand Canyon
('Liberty Inn', 'Inn', 4, 2),  -- Associated with Statue of Liberty
('Parisian Stay', 'Hotel', 4, 3);  -- Associated with Eiffel Tower

-- Insert into PLAN
INSERT INTO [TRAVELPLAN] ([PID], [HID], [AID], [PDatetime]) VALUES
(1, 1, 1, '2024-10-10 10:00:00'),  -- Plan for Hiking with Canyon Hotel
(2, 2, 2, '2024-10-12 12:00:00'),  -- Plan for Sightseeing with Liberty Inn
(3, 3, 3, '2024-10-15 14:00:00');  -- Plan for Photography with Parisian Stay

-- Insert into USERDATA
INSERT INTO [USERDATA] ([UID], [PID], [UFName], [ULName], [UEmail], [UPhone]) VALUES
(1, 1, 'John', 'Doe', 'john.doe@example.com', 1234567890),
(2, 2, 'Jane', 'Smith', 'jane.smith@example.com', 2345678901),
(3, 3, 'Alice', 'Johnson', 'alice.johnson@example.com', 3456789012);
GO

SELECT * FROM [TRAVELPLAN]
GO

create proc DeleteTravelPlan
@PID int
AS
delete from TRAVELPLAN where PID = @PID
GO

-- Proc 1 Kevin McDonald
--exec DeleteTravelPLan 1
-- go

create proc AddTravelPlan
@PID int,
@HID int,
@AID int,
@PDatetime datetime
AS
BEGIN
	INSERT INTO [TRAVELPLAN] ([PID], [HID], [AID], [PDateTime])
	VALUES (@PID, @HID, @AID, @PDatetime)
	END
	GO


-- PROC 2 Kevin McDonald
--EXEC AddTravelPlan @PID = 4, @HID = 1, @AID = 1, @PDateTime = '2024-10-21 12:00:00';

