using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityGiris.Controllers
{
    public class BilgilerController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
