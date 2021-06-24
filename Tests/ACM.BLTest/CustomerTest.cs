using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNmaeTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Faris",
                LastName = "Ahmad"
            };


         string expected = "Ahmad, Faris";
            string Actual = customer.FullName;


            Assert.AreEqual(Actual, expected); 

        }
        [TestMethod]
        public void LastNmaeTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Zyoud"
            };


            string expected = "Zyoud";
            string Actual = customer.FullName;
            

            Assert.AreEqual(expected, Actual);

        }
        [TestMethod]
        public void Checkstatic()
        {
            var c1 = new Customer();
            c1.FirstName = "Maha";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "Fayez";
            Customer.InstanceCount += 1; 
           


            Assert.AreEqual(2,Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            Customer customer = new Customer
            {
                EmailAddress = "fariszyoud@gmail.com ",
                LastName = "Ahmad"
            };
            var expected = true;
             var actual = customer.Validate(); 

            Assert.AreEqual(actual, expected);

        }
    }
}
