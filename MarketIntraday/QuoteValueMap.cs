using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIntraday
{
    internal class QuoteValueMap : ClassMap<QuoteValue>
    {
        public QuoteValueMap()
        {
            Map(m => m.DateTime).Index(0);
            Map(m => m.OpenValue).Index(1);
            Map(m => m.HighValue).Index(2);
            Map(m => m.LowValue).Index(3);
            Map(m => m.CloseValue).Index(4);
            Map(m => m.OperationQuantity).Index(5);
        }
    }
}