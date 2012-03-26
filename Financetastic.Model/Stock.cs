using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financetastic.Model
{
    public class Stock
    {
        // Primitive properties
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal Dividend { get; set; }
        public decimal Open { get; set; }
        public decimal Volume { get; set; }
        public decimal YeahHigh { get; set; }
        public decimal YearLow { get; set; }
        public decimal AverageVolume { get; set; }
        public decimal MarketCap { get; set; }
        public int ExchangeId { get; set; }

        // Navigation properties
        public virtual Exchange Exchange { get; set; }

    }
}
