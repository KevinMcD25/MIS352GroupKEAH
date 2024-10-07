use AdventureWV
go


Select * From [ACTIVITIES]
go

create proc UpdateActivities
@AID int
,@AName nvarchar(255)
,@LID int
AS
BEGIN
Update ACTIVITIES
set AName = @AName

where AID = @AID and LID = @LID
END
GO

exec UpdateActivities @AID=
