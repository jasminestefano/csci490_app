using System.Collections.Generic;
using AppGui.Models;
using AppGui.Repository;
using System.Linq;
using System;

namespace AppGui.Services
{
	public class CustomerServices
	{
		CustomerRepository _repo;
		public CustomerServices()
		{
			_repo = new CustomerRepository();
		}
        public bool validateLogin(string email, string password)
		{
			bool infoLogin = _repo.validateLogin(email, password);
			return infoLogin;
		}
        public bool validateEmail(string email)
        {
            bool infoEmail = _repo.validateEmail(email);
            return infoEmail;
        }
        public bool validateFirstName(string firstName)
        {
            bool infoUserName = _repo.validateFirstName(firstName);
            return infoUserName;
        }
        public bool validateLastName(string lastName)
        {
            bool infoUserName = _repo.validateLastName(lastName);
            return infoUserName;
        }
        public bool validatePassword(string password)
        {
            bool infoPassword = _repo.validatePassword(password);
            return infoPassword;
        }
        public void registerAccount(string f, string l, string e, string p)
        {
            _repo.registerAccount(f, l, e, p);
        }

    }
}