use AdventureWV
go
--create proc


create proc SearchActivity
@Aid int,
@Aname nvarchar(255),
@LName nvarchar(255) = null
AS
BEGIN
SET NOCOUNT ON;

Select Aid as 'Activity ID', Aname as 'Activtity Name', LName as 'Location Name'
from ACTIVITIES A
Inner Join LANDMARKS L on A.LID = L.LID

where Aname = @Aname 
end
GO

--Searches Activity
 exec SearchActivity 1, 'Hiking'
 go