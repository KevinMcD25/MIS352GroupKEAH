use AdventureWV
GO

CREATE PROC LocationDetails  --Create Proc
    @LName NVARCHAR(255),     -- Parameters
    @LType NVARCHAR(255) = NULL
AS             -- AS
BEGIN
   
SELECT --Picking the two columns I want to use
LName AS "Location", --Making Column Headers with as statement
LType AS "Type of Location"
   
FROM LANDMARKS -- Landmarks table 
  
WHERE LName = @LName
AND (@LType IS NULL OR LType = @LType);
END
GO
-- Eric Scull Proc 1
--exec LocationDetails @LName = "Grand Canyon" 
--go

CREATE PROC HospitalityByLocation
AS

BEGIN

SELECT LANDMARKS.LName AS "Landmark Name", --Selecting Columns from Landmarks Table
LANDMARKS.LType AS "Landmark Type", 
HOSPITALITY.HName AS "Hospitality Name", 
HOSPITALITY.HType AS "Hospitality Type", 
HOSPITALITY.HRating AS "Hospitality Rating"
    FROM 
        LANDMARKS --The actual from statement being used
    INNER JOIN 
        HOSPITALITY --Joining the two tables together
    ON 
        LANDMARKS.LID = HOSPITALITY.LID; --Using LID as link between tables
END
GO
--Eric Scull Proc 2
--exec HospitalityByLocation; --Run stored procedure
--go
Use AdventureWV
GO

Create proc SearchLandmark2
@LID int,
@Ltype nvarchar(255) 
AS
BEGIN
SET NOCOUNT ON;

SELECT LName AS 'Landmark Name', LID AS 'Landmark ID'
FROM LANDMARKS
   WHERE Ltype = @Ltype 
END
