using System;
namespace MainProj
{
    public class Train {

        private int TrainId { get; set; }
        private string TrainNumber { get; set; }
        private int DepartureStationID { get; set; }
        private int ArrivalStationID { get; set; }
        private int DepartureTime { get; set; }
        private int ArrivalTime { get; set; }

    }
    public class Stations {

        private int StationID { get; set; }
        private string StationName { get; set; }
        private string Location { get; set; }

    }
    public class Passenger {

        private int PassengerId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string PassengerPassword { get; set; }

    }
    public class Tickets {

        private int TicketId { get; set; }
        private int PassengerID { get; set; }
        private int TrainID { get; set; }
        private int PurchaseTime { get; set; }
        private string SeatNumber { get; set; }
        private int Price { get; set; }

    }

    public class TrainSchedules
    {
        private int ScheduleID { get; set; }
        private int TrainID { get; set; }
        private int StationID { get; }
        private int DepartureTime { get; set; }
        private int ArrivalTime { get; set; }
    }

    public class Employees
    {
        private int EmployeeID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string JobTitle { get; set; }
        private int StationID { get; set; }
        private string EmpPasswork { get; set; }
    }
}