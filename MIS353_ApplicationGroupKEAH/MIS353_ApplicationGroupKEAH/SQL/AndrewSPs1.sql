use AdventureWV
go


--Update activity columns
create proc UpdateActivities
@AID int
,@AName nvarchar(255)
,@LID int
AS

Begin 
Update ACTIVITIES
SET AName = @AName, LID = @LID
Where AID = @AID
END
GO
--Changes activity column
/*
Exec UpdateActivities @AID=2, @AName='Boating', @LID=2
GO
*/
