MIS353GroupKEAHAPI
This is the MIS 353 API Repo for ( Kevin McDonald, Eric Scull, Andrew Taughinbaugh, and Hayden Rhodes )
*********************************************************************************************************************************************
API's<br>

1. Hospitality Search - Allows users to search what type of lodging they would like to stay at.  When we go to build our website, we plan to have a drop-down search instead of user input.  Users will be able to choose between. Hotel, Inn, Camping, etc. When the user selects an option, it will display all results within our system to the user.<br>
Input: Htype<br>
Output: HID, HName, HRating, LID<br>

3. addHospitality - Allows for the addition of hospitality options for front-end programming into the database.  It is a measure to circumvent SQL Injection<br>
Input: HID, HType, HName, HRating, LID<br>
Output: -> Sends to Database <br>

5. TravelPlan Add<br>
This API adds a plan to the Travel Plan table<br>
Inputs : HID, AID<br>
OUTPUT PID, HID, AID<br>

4. PlanDelete<br>

This API deletes a plan in the Travel Plan table<br>
Inputs : PID<br>
OUTPUT : Drop(travel plan)<br>

5.
AddActivity2 (Andrew)<br>
This API adds an activity in the Activities table.<br>
Inputs: Aname, LID<br>
Output: Aname, LID<br>

6.
UserTravelAdd (Andrew)<br>
This API adds a UserTravel to the table.<br>
Inputs: PID, UID, UTDateTime<br>
Output: PID, UID, UTDateTime<br>

7.
Landmark Search
This API allows the user to search for landmarks using Landmark Type.

Input: LType
Output: LType

8.
Landmark Add
This API gives the user the chance to add their own landmark if they find something not in our database. 

Input: LName, LType
Output: LName, LType


*********************************************************************************************************************************************
Contribution<br>

Hayden:<br>
(10/29) - Completed HospitalitySearch API<br>
(10/29) - Completed addHospitality API<br>
(10/29) - Added Webpage outline for Hospitality Search (dynamic), Contact Us, and Our Weather Search (External)<br>
(10/31) - Updated README design<br>

Kevin:<br>

Andrew:<br>

Eric:<br>
(10/30) - Completed LandmarkAdd API<br>
(10/31) - Completed LandmarkSearch API<br>
(10/31) - Edited ReadME

*********************************************************************************************************************************************

