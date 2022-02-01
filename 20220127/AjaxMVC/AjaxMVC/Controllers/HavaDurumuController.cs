using AjaxMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Dynamic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AjaxMVC.Controllers
{
    public class HavaDurumuController : Controller
    {
        public async Task<IActionResult> Getir(string yer)
        {
            HavaViewModel havaViewModel;
            if (string.IsNullOrEmpty(yer))
            {
                return BadRequest();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");

                var result = await client.GetAsync($"weather?q={yer}&appid=7a1d3a5cc63422d173d553b61b277c9e&units=metric&lang=tr");

                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    dynamic durum = JsonSerializer.Deserialize<ExpandoObject>(data); //NEWTONSOFT


                    havaViewModel = new HavaViewModel()
                    {
                        Yer = durum.name.GetString(),
                        Resim = durum.weather[0].GetProperty("icon").GetString(),
                        Sicaklik = (int)durum.main.GetProperty("temp").GetDecimal(),
                        Aciklama = durum.weather[0].GetProperty("description").GetString()
                    };
                    return PartialView("_HavaPartial", havaViewModel);
                }
            }
            return BadRequest();
        }
    }
}
