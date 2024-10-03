use AdventureWV
GO



create table [LANDMARKS](
[LID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
[LName] nvarchar(255) NOT NULL,
[LType] nvarchar(255) NOT NULL,
)
GO

create table [ACTIVITIES] (
    [AID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [AName] nvarchar(255) NOT NULL,
    [LID] int NOT NULL,  
    FOREIGN KEY ([LID]) REFERENCES [LANDMARKS]([LID])
)
GO

create table  [HOSPITALITY] (
[HID] int PRIMARY KEY IDENTITY(1,1) NOT NULL,
[HName] nvarchar(255) NOT NULL,
[HType] nvarchar(255) NOT NULL,
[HRating] int,
[LID] int NOT NULL,
 FOREIGN KEY ([LID]) REFERENCES [LANDMARKS]([LID])
)
GO

create table [TRAVELPLAN] (
[PID] int primary key not null,
[HID] int not null,
[AID] int not null,
[PDatetime] datetime not null,
FOREIGN KEY ([HID]) REFERENCES [HOSPITALITY]([HID]),
FOREIGN KEY ([AID]) REFERENCES [ACTIVITIES]([AID])
)
GO

create table [USERDATA] (
[UID] int primary key not null,
[PID] int not null,
[UFName] nvarchar(255) not null,
[ULName] nvarchar(255) not null,
[UEmail] nvarchar(255) not null,
[UPhone] int not null
FOREIGN KEY ([PID]) REFERENCES [TRAVELPLAN]([PID])
)
GO






