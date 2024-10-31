MIS353GroupKEAHAPI
This is the MIS 353 API Repo for ( Kevin McDonald, Eric Scull, Andrew Taughinbaugh, and Hayden Rhodes )
*********************************************************************************************************************************************
API's

1. Hospitality Search - Allows users to search what type of lodging they would like to stay at.  When we go to build our website, we plan to have a drop-down search instead of user input.  Users will be able to choose between. Hotel, Inn, Camping, etc. When the user selects an option, it will display all results within our system to the user.
Input: Htype
Output: HID, HName, HRating, LID

3. addHospitality - Allows for the addition of hospitality options for front-end programming into the database.  It is a measure to circumvent SQL Injection
Input: HID, HType, HName, HRating, LID
Output: -> Sends to Database 

5. TravelPlan Add
This API adds a plan to the Travel Plan table
Inputs : HID, AID
OUTPUT PID, HID, AID

4. PlanDelete

This API deletes a plan in the Travel Plan table
Inputs : PID
OUTPUT : Drop(travel plan)

5.
AddActivity2 (Andrew)
This API adds an activity in the Activities table.
Inputs: Aname, LID
Output: Aname, LID

6.
UserTravelAdd (Andrew)
This API adds a UserTravel to the table.
Inputs: PID, UID, UTDateTime
Output: PID, UID, UTDateTime

*********************************************************************************************************************************************
Contribution

Hayden:
(10/29) - Completed HospitalitySearch API
(10/29) - Completed addHospitality API
(10/29) - Added Webpage outline for Hospitality Search (dynamic), Contact Us, and Our Weather Search (External)
(10/31) - Updated README design

Kevin:

Andrew:

Eric:


*********************************************************************************************************************************************

