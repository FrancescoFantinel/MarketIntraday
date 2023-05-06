namespace MarketIntraday
{
    internal class QuoteValue
    {
        public DateTime DateTime { get; set; }
        public decimal OpenValue { get; set; }
        public decimal HighValue { get; set; }
        public decimal LowValue { get; set; }
        public decimal CloseValue { get; set; }
        public long OperationQuantity { get; set; }

        public override string ToString()
        {
            return $"{nameof(DateTime)} : {DateTime}, " +
             $"{nameof(OpenValue)} : {OpenValue:F4}, " +
             $"{nameof(HighValue)} : {HighValue:F4}, " +
             $"{nameof(LowValue)} : {LowValue:F4}, " +
             $"{nameof(CloseValue)} : {CloseValue:F4}, " +
             $"{nameof(OperationQuantity)} : {OperationQuantity}";
        }
    }
}
