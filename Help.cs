using System;
using System.ComponentModel.Design;
using System.Linq;
using MySql.Data.MySqlClient;

namespace MainProj
{
    public class Train {

        private int TrainId { get; set; }
        private string TrainNumber { get; set; }
        private int DepartureStationID { get; set; }
        private int ArrivalStationID { get; set; }
        private int DepartureTime { get; set; }
        private int ArrivalTime { get; set; }

        bool add_Train(SqlCommand cmd)
        {

            cmd.Parameters.Add("@TrainId", SqlDbType.Int).Value = this.TrainId;
            cmd.Parameters.Add("@TrainNumber", SqlDbType.NVarChar).Value = this.TrainNumber;
            cmd.Parameters.Add("@DepartureStationID", SqlDbType.Int).Value = this.DepartureStationID;
            cmd.Parameters.Add("@ArrivalStationID", SqlDbType.Int).Value = this.ArrivalStationID;
            cmd.Parameters.Add("@DepartureTime", SqlDbType.Int).Value = this.DepartureTime;
            cmd.Parameters.Add("@ArrivalTime", SqlDbType.Int).Value = this.ArrivalTime;

            int affectedRows = cmd.ExecuteNonQuery();

            return affectedRows > 0;

        }

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
        private string EmpPassword { get; set; }

        bool public add_EmployeeDB(SqlCommand cmd)
        {
            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar).Value = this.EmployeeID;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = this.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = this.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = this.Email;
            cmd.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = this.JobTitle;
            cmd.Parameters.Add("@StationID", SqlDbType.Int).Value = this.StationID;
            cmd.Parameters.Add("@EmpPassword", SqlDbType.NVarChar).Value = this.EmpPassword;

            int affectedRows = cmd.ExecuteNonQuery();

            return affectedRows > 0;

        }


    }
}