using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financetastic.Model
{
    public class MarketIndex
    {
        public int Id { get; set; }
        public decimal Last { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal YeahHigh { get; set; }
        public decimal YearLow { get; set; }
        public decimal Open { get; set; }
        public decimal Volume { get; set; }
        public string Title { get; set; }
        public string Symbol { get; set; }
        public System.DateTime RetrievalDateTime { get; set; }

        
    }
}
