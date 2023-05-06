using CsvHelper;
using MarketIntraday;
using System;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Net;

// Compatible with any recent version of .NET Framework or .Net Core

namespace ConsoleTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // replace the "demo" apikey below with your own key from https://www.alphavantage.co/support/#api-key
            string QUERY_URL = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY_EXTENDED&symbol=IBM&interval=1min&slice=year1month1&apikey=demo";

            Uri queryUri = new Uri(QUERY_URL);

            // print the output
            // This example uses the fine nuget package CsvHelper (https://www.nuget.org/packages/CsvHelper/)

            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            using (WebClient client = new WebClient())
            {
                using (MemoryStream stream = new MemoryStream(client.DownloadDataTaskAsync(queryUri).Result))
                {
                    stream.Position = 0;

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            csv.Context.RegisterClassMap<QuoteValueMap>();
                            var records = csv.GetRecords<QuoteValue>();
                            foreach (QuoteValue record in records)
                            {
                                Console.WriteLine(record);
                            }
                        }
                    
                    }
                }
            }
        }
    }
}