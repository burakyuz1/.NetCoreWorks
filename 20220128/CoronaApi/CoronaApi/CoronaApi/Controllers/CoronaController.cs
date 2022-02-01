using CoronaApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoronaApi.Controllers
{
    public class CoronaController : Controller
    {
        public async Task<IActionResult> AllCountries() //table
        {
            List<CoronaViewModel> cases = new List<CoronaViewModel>();


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://covid-api.mmediagroup.fr");

                var request = await client.GetAsync("/v1/cases");

                if (request.IsSuccessStatusCode)
                {
                    var jsonData = await request.Content.ReadAsStringAsync();

                    dynamic netDatas = JsonSerializer.Deserialize<ExpandoObject>(jsonData);
                    foreach (KeyValuePair<string, object> data in netDatas) //data= dictionary
                    {
                        string countryName = data.Key;
                        int @case = (int)(data.Value as dynamic).GetProperty("All").GetProperty("confirmed").GetDecimal();
                        int death = (int)(data.Value as dynamic).GetProperty("All").GetProperty("deaths").GetDecimal();

                        cases.Add(new CoronaViewModel()
                        {
                            CountryName = countryName,
                            TotalCases = @case,
                            TotalDeaths = death
                        });


                    }

                    return View(cases.OrderByDescending(x => x.TotalDeaths).ToList());
                }
                else
                {
                    return BadRequest();

                }
            }

        }

        public IActionResult CountryCases()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> CountryCases(string cn, DateTime dt) //normal
        {
            string formettedDateTime = dt.ToString("yyyy-MM-dd");
            string previousDay = dt.AddDays(-1).ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(cn))
            {
                return BadRequest();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://covid-api.mmediagroup.fr");
                var request = await client.GetAsync($"v1/history?country={cn}&status=confirmed");

                if (request.IsSuccessStatusCode)
                {
                    var jsonData = await request.Content.ReadAsStringAsync();
                    dynamic netData = JsonSerializer.Deserialize<ExpandoObject>(jsonData);

                    int currentCase = (int)netData.All.GetProperty("dates").GetProperty(formettedDateTime).GetDecimal();
                    int previousCase = (int)netData.All.GetProperty("dates").GetProperty(previousDay).GetDecimal();
                    int dailyCase = currentCase - previousCase;


                    CoronaViewModel corona = new CoronaViewModel()
                    {
                        CountryName = cn,
                        TotalCases = dailyCase
                    };


                    return PartialView("_ConfirmedPartial", corona);
                }

            }


            return View();
        }
    }
}
