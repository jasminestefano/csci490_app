using AppGui.Models;
using AppGui.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppGui.TestUnits
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void passwordValidation_True()
        {
            string password = "testing1234";
            var repository = new CustomerRepository();
            bool results = repository.validatePassword(password);
            Assert.IsTrue(results);
        }
        [TestMethod]
        public void passwordValidation_False()
        {
            string password = "1234";
            var repository = new CustomerRepository();
            bool results = repository.validatePassword(password);
            Assert.IsFalse(results);
        }
        [TestMethod]
        public void emailValidation_True()
        {
            string email = "testing@gmail.com";
            var repository = new CustomerRepository();
            bool results = repository.validateEmail(email);
            Assert.IsTrue(results);
        }
        [TestMethod]
        public void emailValidation_False()
        {
            string email = "testinggmail.com";
            var repository = new CustomerRepository();
            bool results = repository.validateEmail(email);
            Assert.IsFalse(results);
        }
        [TestMethod]
        public void checkListFilled_True()
        {
            List<CustomerModel> newList = GetCustomerInfo();
            Assert.IsTrue(newList.Count > 0);
        }
        private List<CustomerModel> GetCustomerInfo()
        {
            return new List<CustomerModel>()
            {
                new CustomerModel()
                {
                    passengerID = 1,
                    Firstname = "Test",
                    Lastname = "Test",
                    Email = "Test@gmail.com",
                    password = "password1234"
                }
            };
        }
    }
}
