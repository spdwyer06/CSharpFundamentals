using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void SetCustomerID()
        {

        }

        [TestMethod]
        public void SetCustomerName()
        {
            
        }

        [TestMethod]
        public void SetCustomerAge()
        {

        }

        [TestMethod]
        public void SetEnrollmentDate()
        {

        }

        [TestMethod]
        public void EnrollmentLengthMessage()
        {
            Customer sean = new Customer();
            sean.EnrollmentDate = (2000, 1, 1);

        }
    }
}
