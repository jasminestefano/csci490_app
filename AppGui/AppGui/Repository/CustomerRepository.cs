using System;
using MySql.Data.MySqlClient;
using AppGui.Models;
using System.Xml.Linq;
using System.Globalization;

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

    }
}