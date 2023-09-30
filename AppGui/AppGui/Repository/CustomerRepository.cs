using System;
using MySql.Data.MySqlClient;
using AppGui.Models;
using System.Xml.Linq;
using System.Globalization;

using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace AppGui.Repository
{
	public class CustomerRepository
	{
		public List<CustomerModel> CustomerModel { get; set; }
		private MySqlConnection _connection;
		public CustomerRepository()
		{
			string connectionString = "server=sql9.freesqldatabase.com;userid=sql9649325;password=N98B1iW8Gi;database=sql9649325";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
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
	}
}