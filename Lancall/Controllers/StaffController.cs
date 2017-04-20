using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lancall.Models;

namespace Lancall.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ViewResult Index()
        {
            var staff = GetStaff();

            return View(staff);
        }

        private IEnumerable<Staff> GetStaff()
        {
            return new List<Staff>
            {
                new Staff {Name = "Philip"},
                new Staff {Name = "Calvin"}
            };
        }
    }
}