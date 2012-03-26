using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financetastic.Model
{
    public class Order
    {
        // Primitive properties
        public int Id { get; set; }
        public decimal NumberOfShares { get; set; }
        public decimal Price { get; set; }
        public int OrderTypeId { get; set; }
        public int SecurityId { get; set; }
        public int BrokerageAccountId { get; set; }

        // Navigation properties
        public virtual BrokerageAccount BrokerageAccount { get; set; }
        public virtual Security Security { get; set; }
        public virtual OrderType OrderType { get; set; }

    }
}
