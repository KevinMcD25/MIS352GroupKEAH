use AdventureWV
go
--create proc


create proc SearchActivity
@AID int,
@Aname nvarchar(255) = 'Hiking',
@LName nvarchar(255) = null
AS
BEGIN
SET NOCOUNT ON;

Select AID as 'Activity ID', AName as 'Activtity Name', LName as 'Location Name'
from ACTIVITIES, LANDMARKS

where AName = @AName 
end


--Searches Activity
-- exec SearchActivity 1