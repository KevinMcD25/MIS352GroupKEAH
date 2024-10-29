CREATE DATABASE AdventureWV
GO

use AdventureWV
GO



create table [LANDMARKS](
[LID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
[LName] nvarchar(255) unique NOT NULL,
[LType] nvarchar(255) NOT NULL,
)
GO

create table [ACTIVITIES] (
    [AID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [AName] nvarchar(255) NOT NULL,
    [LID] int  NOT NULL,  

    FOREIGN KEY ([LID]) REFERENCES [LANDMARKS]([LID])
)
GO

ALTER TABLE ACTIVITIES
    ADD Constraint ADSD UNIQUE(AName, LID)
    go

create table  [HOSPITALITY] (
[HID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
[HName] nvarchar(255) unique NOT NULL,
[HType] nvarchar(255)  NOT NULL,
[HRating] int,
[LID] int NOT NULL,
 FOREIGN KEY ([LID]) REFERENCES [LANDMARKS]([LID])
)
GO

create table [TRAVELPLAN] (
[PID] int primary key IDENTITY (1,1) not null,
[HID] int unique not null,
[AID] int unique not null,
FOREIGN KEY ([HID]) REFERENCES [HOSPITALITY]([HID]),
FOREIGN KEY ([AID]) REFERENCES [ACTIVITIES]([AID])
)
GO



create table [USERDATA] (
[UID] int primary key IDENTITY (1,1) not null,
[UFName] nvarchar(255) not null,
[ULName] nvarchar(255) not null,
[UEmail] nvarchar(255) unique not null,
[UPhone] VARCHAR(15) not null
)
GO

create table [UserTravel](
[UTID] int primary key not null IDENTITY (1,1),
[PID] int not null,
[UID] int not null,
[UTDateTime] datetime not null,
FOREIGN KEY ([PID]) REFERENCES [TRAVELPLAN]([PID]),
FOREIGN KEY ([UID]) REFERENCES [USERDATA]([UID])
)
GO






