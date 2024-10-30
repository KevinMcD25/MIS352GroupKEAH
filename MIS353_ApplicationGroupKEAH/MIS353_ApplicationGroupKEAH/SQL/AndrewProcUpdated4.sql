use AdventureWV
go
--create proc


--create proc SearchActivity1

--@Aname nvarchar(255)

--AS
--BEGIN
--SET NOCOUNT ON;
----SELECT FROM ACTIVITIES


--where Aname = @Aname 
--end
--GO

--Searches Activity
 exec SearchActivity 1, 'Hiking'
 go