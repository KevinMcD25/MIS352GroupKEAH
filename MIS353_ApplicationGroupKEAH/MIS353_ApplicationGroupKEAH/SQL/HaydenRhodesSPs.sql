use AdventureWv
GO
--create proc 1
Create proc SearchHotel
@HType nvarchar(255) = 'Hotel',
@HName nvarchar(255) = NULL,
@HRating int = NULL,
@LID Int = NULL
AS
BEGIN
SET NOCOUNT ON;

   SELECT Hname AS 'Hotel Name', HRating as 'Rating', LID 'Location ID'
   FROM HOSPITALITY
   WHERE HType = @HType and @HName is NULL or HName = @HName
END

--exec SearchHotel


--create proc 2

Create proc NewHospitality
@HType nvarchar(255),
@HName nvarchar(255),
@HRating int = NULL,
@LID Int = NULL
AS
BEGIN
	insert into HOSPITALITY(HType,HName,HRating,LID)
	VALUES (@HType,@HName,@HRating,@LID)
	
END
GO

--exec NewHospitality @HType = 'Hotel', @HName = 'Motel 6', @HRating = 1,@LID = 1

DROP Proc NewHospitality
GO
