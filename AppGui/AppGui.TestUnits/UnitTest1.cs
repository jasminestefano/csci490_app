using AppGui.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
