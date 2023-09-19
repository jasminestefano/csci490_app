
--
-- Current Database: `train_station`
-- csci 490 
-- v 1.0
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `train_station` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `train_station`;

-- Table to store information about train stations
DROP TABLE IF EXISTS `Stations`;
CREATE TABLE Stations (
    StationID INT PRIMARY KEY,
    StationName VARCHAR(255) NOT NULL,
    Location VARCHAR(255) NOT NULL
);

-- Table to store information about trains
DROP TABLE IF EXISTS `Trains`;
CREATE TABLE Trains (
    TrainID INT PRIMARY KEY,
    TrainNumber VARCHAR(10) NOT NULL,
    DepartureStationID INT,
    ArrivalStationID INT,
    DepartureTime DATETIME,
    ArrivalTime DATETIME,
    FOREIGN KEY (DepartureStationID) REFERENCES Stations(StationID),
    FOREIGN KEY (ArrivalStationID) REFERENCES Stations(StationID)
);

-- Table to store information about passengers
DROP TABLE IF EXISTS `Passengers`;
CREATE TABLE Passengers (
    PassengerID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    PassengerPassword VARCHAR(20) NOT NULL
);

-- Table to store information about tickets
DROP TABLE IF EXISTS `Tickets`;
CREATE TABLE Tickets (
    TicketID INT PRIMARY KEY,
    PassengerID INT,
    TrainID INT,
    PurchaseTime DATETIME,
    SeatNumber VARCHAR(10),
    Price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (PassengerID) REFERENCES Passengers(PassengerID),
    FOREIGN KEY (TrainID) REFERENCES Trains(TrainID)
);

-- Table to store information about train schedules
DROP TABLE IF EXISTS `TrainSchedules`;
CREATE TABLE TrainSchedules (
    ScheduleID INT PRIMARY KEY,
    TrainID INT,
    StationID INT,
    ArrivalTime DATETIME,
    DepartureTime DATETIME,
    FOREIGN KEY (TrainID) REFERENCES Trains(TrainID),
    FOREIGN KEY (StationID) REFERENCES Stations(StationID)
);

-- Table to store information about train employees
DROP TABLE IF EXISTS `Employees`;
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    JobTitle VARCHAR(255) NOT NULL,
    StationID INT,
    EmpPassword VARCHAR(20) NOT NULL,
    FOREIGN KEY (StationID) REFERENCES Stations(StationID)
);
