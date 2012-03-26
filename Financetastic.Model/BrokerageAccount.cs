using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financetastic.Model
{
    public class BrokerageAccount
    {

        public BrokerageAccount()
        {
            Positions = new HashSet<Position>();
            Orders = new HashSet<Order>();
        }

        // Primitive properties
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountTitle { get; set; }
        public decimal Total { get; set; }
        public decimal MarginBalance { get; set; }
        public bool IsRetirement { get; set; }
        public int CustomerId { get; set; }
        public decimal CashTotal { get; set; }
        public decimal PositionsTotal { get; set; }
        public int WatchListId { get; set; }

        // Navigation properties
        public ICollection<Position> Positions { get; set; }
        public ICollection<Order> Orders { get; set; }
        public WatchList WatchList { get; set; }






    }
}
