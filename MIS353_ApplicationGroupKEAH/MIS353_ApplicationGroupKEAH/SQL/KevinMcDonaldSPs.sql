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

create proc AddTravelPlan1
@PID int,
@HID int,
@AID int,
@PDatetime datetime
AS
BEGIN
	INSERT INTO [TRAVELPLAN] ([PID], [HID], [AID])
	VALUES (@PID, @HID, @AID, @PDatetime)
	END
	GO


-- PROC 2 Kevin McDonald
--EXEC AddTravelPlan @PID = 4, @HID = 1, @AID = 1, @PDateTime = '2024-10-21 12:00:00';





create proc AddUser
@UFname nvarchar(255),
@ULname nvarchar(255),
@UEmail nvarchar(255),
@UPhone nvarchar(255)
AS
BEGIN
	INSERT INTO [UserData]  ([UFName], [ULName], [UEmail], [UPhone])
	VALUES (@UFname,@ULname,@UEmail,@UPhone)
	END
	GO


--PROC 3 Kevin McDonald
--EXEC AddUser @Ufname = 'Kevin', @Ulname = 'McDonald', @Uemail = 'kevinmcdonald@gmail.com', @Uphone = 7242443522;

use AdventureWV
go


create proc UserTravelAdd
@PID int,
@UID int,
@UTDateTime datetime
AS
BEGIN
INSERT INTO [UserTravel] ([PID], [UID], [UTDateTime]) 
Values(@PID, @UID, @UTDateTime)
end
go