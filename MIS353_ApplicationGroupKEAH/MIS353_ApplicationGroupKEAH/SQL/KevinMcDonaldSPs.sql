use AdventureWV
GO


create proc DeleteTravelPlan
@PID int
AS
delete from UserTravel where PID = @PID
GO

-- Proc 1 Kevin McDonald
--exec DeleteTravelPLan 1
-- go

create proc AddUserTravel
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