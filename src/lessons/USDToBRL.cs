using System.Diagnostics;
using Newtonsoft.Json;

namespace USDToBRL
{
    public class Class
    {
        private readonly string apiURL = "https://open.er-api.com/v6/latest/USD";

        private async Task<double> GetExchangeRate()
        {
            using (HttpClient httpClient = new())
            {
                try
                {
                    HttpResponseMessage req = await httpClient.GetAsync(apiURL);

                    if (req.IsSuccessStatusCode)
                    {
                        string json = await req.Content.ReadAsStringAsync();

                        dynamic data = JsonConvert.DeserializeObject(json) ?? new { };

                        return data.rates.BRL.Value<double>();
                    }
                    else
                    {
                        Console.WriteLine("Failed to get exchange rate!");
                        Environment.Exit(1);
                    }
                }
                catch
                {
                    Console.WriteLine("Failed to get exchange rate!");
                    Environment.Exit(1);
                }

                return 1;
            }

        }
        public async void Exec()
        {
            Console.Write("Write the value in USD that you want to convert: ");
            string input = Console.ReadLine()?.ToString() ?? "";

            double USDValue = Convert.ToDouble(input);

            double exchangeRate = await GetExchangeRate();

            Console.WriteLine($"In current exchange rate, 1 USD = {exchangeRate} BRL. Your value in BRL is: {USDValue * exchangeRate}");
        }
    }
}