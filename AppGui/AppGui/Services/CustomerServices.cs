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

        public bool validatePassword(string password)
        {
            bool infoPassword = _repo.validatePassword(password);
            return infoPassword;
        }
        public void registerAccount(string f, string l, string e, string p)
        {
            _repo.registerAccount(f, l, e, p);
        }
        public List<CustomerModel> GetCustomerInfo(string email)
        {
            List<CustomerModel> newList = _repo.GetCustomerInfo(email).ToList<CustomerModel>();
            return newList;
            
        }
        public void bookTickets(string f, string l, int tn)
        {
            _repo.bookTickets(f, l, tn);
        }

    }
}