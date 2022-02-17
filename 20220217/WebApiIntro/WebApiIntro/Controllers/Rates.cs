using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiIntro.Models;

namespace WebApiIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rates : ControllerBase
    {
        List<Rate> rates = new List<Rate>()
        {
            new Rate(){Code = "USD", Price = 13.3m},
            new Rate(){Code = "EUR", Price = 15.1m}
        };
        [HttpGet]
        public List<Rate> GetCurrencies() //Get olması şart başta.
        {
            return rates;
        }
        [HttpGet("{code}")]
        public ActionResult<Rate> GetRate(string code)
        {
         Rate rate = rates.FirstOrDefault(x => x.Code == code);
            if (rate== null)
            {
                return NotFound();
            }
            return rate;
        }
    }
}
