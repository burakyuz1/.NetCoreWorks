using System;
using System.Dynamic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CallApiExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=ankara&appid=7a1d3a5cc63422d173d553b61b277c9e&units=metric&lang=tr";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");

                var result = await client.GetAsync("weather?q=ankara&appid=7a1d3a5cc63422d173d553b61b277c9e&units=metric&lang=tr");

                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    dynamic durum = JsonSerializer.Deserialize<ExpandoObject>(data);
                    var sicaklik = durum.main.GetProperty("temp");
                    var aciklama = durum.weather[0].GetProperty("description");
                    Console.WriteLine(data);
                }
            }
        }
    }
}
