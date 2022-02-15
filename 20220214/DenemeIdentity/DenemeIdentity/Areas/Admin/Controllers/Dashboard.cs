using DenemeIdentity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeIdentity.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles ="admin")]
    public class Dashboard : Controller
    {
        private readonly ApplicationDbContext _db;

        public Dashboard(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<IdentityUser> userList = _db.Users.ToList();

            return View(userList);
        }
    }
}
