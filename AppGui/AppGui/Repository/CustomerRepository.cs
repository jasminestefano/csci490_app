using System;
using MySql.Data.MySqlClient;
using AppGui.Models;
using System.Xml.Linq;
using System.Globalization;
using System.Security.Permissions;

using System.Collections.Generic;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Asn1.X509.Qualified;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppGui.Repository
{
	public class CustomerRepository
	{
		public List<CustomerModel> CustomerModel { get; set; }
		public MySqlConnection _connection;
		public CustomerRepository()
		{
			string connectionString = "server=sql9.freesqldatabase.com;userid=sql9649325;password=N98B1iW8Gi;database=sql9649325";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        ~CustomerRepository()
        {
            _connection.Close();
        }
        public bool validateLogin(string email, string password)
		{
			var statement = "Select Email,Password from Passengers";
			var command = new MySqlCommand(statement, _connection);
			var results = command.ExecuteReader();
			while(results.Read()) {
				if (email.Equals(results[0]) && password.Equals(results[1]))
				{
					return true;
				}
			}
			results.Close();
			return false;
		}
        public bool validateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else { return false; }
        }

        public bool validatePassword(string password)
		{
            if (password.Length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<CustomerModel> GetCustomerInfo(string email) {
            var statement = "Select * From Passengers where Email=@newEmail";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newEmail", email);
            var results = command.ExecuteReader();
            List<CustomerModel> newList = new List<CustomerModel>();
            while (results.Read())
            {
                CustomerModel newModel = new CustomerModel()
                {
                    passengerID = (int)results[0],
                    Firstname = (string)results[1],
                    Lastname = (string)results[2],
                    Email = (string)results[3],
                    password = (string)results[4]
                };
                newList.Add(newModel);
            }
           results.Close();
           return newList;

        }
   
        
        public void registerAccount(string f, string l, string e, string p)
        {
            var statement = "INSERT INTO Passengers(FirstName, LastName, Email, Password) VALUES(@newFirst, @newLast, @newEmail, @newPassword)";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newFirst", f);
            command.Parameters.AddWithValue("@newLast", l);
            command.Parameters.AddWithValue("@newEmail", e);       
            command.Parameters.AddWithValue("@newPassword", p);
            var results = command.ExecuteReader();
        }
        public void bookTickets(string f, string l, int tn)
        {
            var statement = "INSERT INTO Booking(FirstName, LastName, TrainNumber) VALUES(@newFirst, @newLast, @trainNumber)";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newFirst", f);
            command.Parameters.AddWithValue("@newLast", l);
            command.Parameters.AddWithValue("@trainNumber", tn);
            var results = command.ExecuteReader();
        }
        public void updateInformation(string f, string l, string e, string p, string target)
        {
            var statement = "Update Passengers Set FirstName = @firstName, LastName = @lastName, Email=@email, Password = @password Where Email = @targetEmail";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@firstName", f);
            command.Parameters.AddWithValue("@lastName", l);
            command.Parameters.AddWithValue("@email", e);
            command.Parameters.AddWithValue("@password", p);
            command.Parameters.AddWithValue("@targetEmail", target);
            int result = command.ExecuteNonQuery();
        }
       
    }
}