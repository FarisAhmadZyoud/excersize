using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerID { get; private set; }

        public string EmailAddress { get; set; }

        public string FirstName {get;set; }


        private string _lastname; 
        public string LastName
        {
            set
            {
                _lastname = value;

            }

            get
            {

                return _lastname;

            }
        }

        public  static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {

                    if (!string.IsNullOrWhiteSpace(fullname))
                    {

                        fullname += ", ";

                    }
                    fullname += FirstName;
                }
                return fullname;    
            }
        }
        public Customer Retrieve(int CustomerID)
        {

            return new Customer();



        }
        public List<Customer> Retrieve()
        {

            return new List<Customer>(); 



        }
        public bool Validate()
        {
            var isvalid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isvalid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isvalid = false;
            return isvalid;

        }
    }
}
