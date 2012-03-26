using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financetastic.Model
{
    public class Customer
    {
        public Customer()
        {
            BrokerageAccounts = new HashSet<BrokerageAccount>();
        }

        // Primitive properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string CustomerCode { get; set; }

        // Navigation properties
        public ICollection<BrokerageAccount> BrokerageAccounts { get; set; }

    }
}
