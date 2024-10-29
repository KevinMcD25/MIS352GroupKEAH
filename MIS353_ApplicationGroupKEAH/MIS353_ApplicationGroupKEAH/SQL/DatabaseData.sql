use AdventureWV
GO

-- Insert into LANDMARKS
INSERT INTO [LANDMARKS] ([LName], [LType]) VALUES
('Grand Canyon', 'Natural'),
('Statue of Liberty', 'Monument'),
('Eiffel Tower', 'Monument');

-- Insert into ACTIVITIES
INSERT INTO [ACTIVITIES] ([AName], [LID]) VALUES
('Hiking', 1),  -- Hiking at Grand Canyon
('Sightseeing', 2),  -- Sightseeing at Statue of Liberty
('Photography', 3);  -- Photography at Eiffel Tower

-- Insert into HOSPITALITY
INSERT INTO [HOSPITALITY] ([HName], [HType], [HRating], [LID]) VALUES
('Canyon Hotel', 'Hotel', 5, 1),  -- Associated with Grand Canyon
('Liberty Inn', 'Inn', 4, 2),  -- Associated with Statue of Liberty
('Parisian Stay', 'Hotel', 4, 3);  -- Associated with Eiffel Tower

-- Insert into TRAVELPLAN
INSERT INTO [TRAVELPLAN] ([PID], [HID], [AID]) VALUES
(1, 1, 1),  -- Plan for Hiking with Canyon Hotel
(2, 2, 2),  -- Plan for Sightseeing with Liberty Inn
(3, 3, 3);  -- Plan for Photography with Parisian Stay

-- Insert into USERDATA
INSERT INTO [USERDATA] ([UFName], [ULName], [UEmail], [UPhone]) VALUES
('John', 'Doe', 'john.doe@example.com', '1234567890'),
('Jane', 'Smith', 'jane.smith@example.com', '2345678901'),
('Alice', 'Johnson', 'alice.johnson@example.com', '3456789012');
GO

INSERT INTO [UserTravel] ([UID], [PID], [UTDateTime]) VALUES
(1, 1, 2024-10-10),
(2, 2, 2024-10-11),
(3, 3, 2024-10-12);
GO
