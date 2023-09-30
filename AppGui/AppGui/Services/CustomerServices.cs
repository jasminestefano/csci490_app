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

    }
}