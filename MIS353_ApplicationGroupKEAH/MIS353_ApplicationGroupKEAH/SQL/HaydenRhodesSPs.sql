use AdventureWv
GO
--create proc 1

--For running APi Select *, LID as Landmark 
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

CREATE proc addHospitality
@HType nvarchar(255),
@HName nvarchar(255),
@HRating int = NULL,
@LID Int
AS
BEGIN
    -- Check if LID is NULL
    IF @LID IS NULL
    BEGIN
        RAISERROR('LID must be provided and cannot be NULL.', 16, 1);
        RETURN;  -- Exit the procedure if LID is NULL
    END

    INSERT INTO HOSPITALITY (HType, HName, HRating, LID)
    VALUES (@HType, @HName, @HRating, @LID);
END

--exec addHospitality @HType = 'Hotel', @HName = 'Motel 6', @HRating = 1,@LID = 1

--DROP Proc addHospitality
--GO
