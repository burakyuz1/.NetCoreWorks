using Microsoft.AspNetCore.Mvc;
using System;

namespace AjaxMVC.Controllers
{
    public class RastgeleController : Controller
    {
        static Random rnd = new Random();
        public int Zar()
        {
            return rnd.Next(1, 7);
        }
        public int[] CiftZar()
        {
            var dizi = new[] { rnd.Next(1, 7), rnd.Next(1, 7) };
            Array.Sort(dizi);
            return dizi;
        }
    }
}
