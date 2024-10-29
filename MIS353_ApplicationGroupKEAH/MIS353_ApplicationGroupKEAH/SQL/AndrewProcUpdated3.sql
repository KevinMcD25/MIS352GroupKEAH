use AdventureWV
go


create proc DeleteActivity
@AID int
AS
delete from ACTIVITIES where AID = @AID
go

--proc 2 Andrew Taughinbaugh; Deletes an Activity
--exec DeleteActivity 5
--go