using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace USDToBRL
{
    public class Class
    {
        private string apiURL = "https://open.er-api.com/v6/latest/USD";

        private async Task<double> GetExchangeRate()
        {
            double exchangeRate = 0;

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage req = await httpClient.GetAsync(apiURL);

                    if (req.IsSucessStatusCode)
                    {
                        string json = await req.Contets.ReadAsStringAsync();

                        dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                        exchangeRate = data.rates.BRL;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get exchange rate!");
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            return exchangeRate;
        }
        public async void Exec()
        {
            Console.Write("Write the value in USD that you want to convert: ");
            string input = Console.ReadLine()?.ToString() ?? "";

            double USDvalue = Convert.ToDouble(input);

            double exchangeRate = await GetExchangeRate();

            Console.WriteLine($"In current exchange rate, 1 USD = {exchangeRate} BRL. Your value in BRL is: {USDvalue * exchangeRate}");
        }
    }
}