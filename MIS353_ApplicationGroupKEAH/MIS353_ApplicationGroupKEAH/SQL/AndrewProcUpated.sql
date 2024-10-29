use AdventureWV
go




-- Allows you to add activity
create or alter proc AddActivity2
@AName nvarchar(255)
,@LID int
AS
BEGIN
	
	insert into ACTIVITIES(AName,LID)
	VALUES (@AName,@LID)
	
END
GO
--Adds an activity
/*
Exec AddActivity2
@AName = 'Kayaking'
,@LID = 3
GO
*/