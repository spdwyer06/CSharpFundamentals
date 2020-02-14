using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetAddress()
        {
            Person sean = new Person();
            sean.Address.HouseNumber = "3726";
            sean.Address.StreetName = "Branch Way";
            sean.Address.City = "Indianapolis";
            sean.Address.State = "IN";
            sean.Address.ZipCode = "46268";

            Console.WriteLine(sean.Address);

            Customer maria = new Customer();
            maria.Address.HouseNumber = "7127";
            maria.Address.StreetName = "Doral N. Dr.";
            maria.Address.ApartmentNumber = "A";
            maria.Address.City = "Indianapolis";
            maria.Address.State = "IN";
            maria.Address.ZipCode = "46250";

            Console.WriteLine(maria.Address);
        }

        [TestMethod]
        public void CustomerIsPremium()
        {
            Customer kevin = new Customer();
            kevin.IsPremium = true;

            Console.WriteLine(kevin.IsPremium);
            Console.WriteLine(kevin.GetType());

            Assert.IsTrue(kevin.IsPremium);
        }

        [TestMethod]
        public void EmployeeTests()
        {
            Employee james = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            tony.HoursWorked = 12;
            tony.HourlyWage = 20;
            SalaryEmployee ichigo = new SalaryEmployee();
            ichigo.SalaryWage = 100000;

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(james);
            allEmployees.Add(tony);
            allEmployees.Add(ichigo);

            var employee = allEmployees[1];

            foreach (Employee worker in allEmployees)
            {
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker; // casting
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.SalaryWage}.");
                }
                else if(worker is HourlyEmployee hourlyWorker) //  pattern matching
                {
                    Console.WriteLine($"This is an hourly employee that makes {hourlyWorker.HourlyWage}.");
                }
                else
                {
                    Console.WriteLine("This is an employee.");
                }
            }
        }

        [TestMethod]
        public void SetName()
        {
            Name sean = new Name();
            sean.FirstName = "Sean";
            sean.LastName = "Dwyer";

            
        }
    }
}
