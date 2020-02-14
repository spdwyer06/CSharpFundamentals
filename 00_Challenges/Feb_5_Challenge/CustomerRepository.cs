using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.Feb_5_Challenge
{
    /*  store and manipulate our customers on a list. => Customer Repository

        send a message to customers based on their years of subscribing. => Repository Method
            If they’ve been part of a plan for 1-5 years, we send them a thank you note.
            If they have been a customer for more than 5 years, we send them a note that says: “Thank you for being a Gold member.”  
            
        Write unit tests to ensure your methods are working properly and use the repository pattern.    */

    public class CustomerRepository
    {
        private List<Customer> _customers = new List<Customer>(); //    the "_" in "_customers" denotes that _customers is a field

        public void AddCustomerToList(Customer newCustomer)
        {
            _customers.Add(newCustomer);
        }

        public string GetThankYou(Customer existingCustomer)
        {
            if (existingCustomer.EnrollmentLength <= 5)
            {
                return "Thank you for being a valued customer.";
            }
            else 
            {
                return "Thank you for being a Gold Member.";
            }
        }
    }
}
