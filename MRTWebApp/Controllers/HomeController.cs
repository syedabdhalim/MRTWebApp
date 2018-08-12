using MRTWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRTWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(MRT mrt)
        {
            double[,] rate =
            {
                {0.8, 1.2, 1.8, 2.0},
                {1.2, 0.8, 1.5, 1.8},
                {1.8, 1.5, 0.8, 1.1},
                {2.0, 1.8, 1.1, 0.8 }
            };

            IDictionary<int, string> dictOrigin = new Dictionary<int, string>()
            {
                {0, "Sungai Buloh" },
                {1, "Kampung Selamat" },
                {2, "Kwasa Damansara" },
                {3, "Kwasa Sentral" },
                {4, "Kota Damansara" }
            };

            IDictionary<int, string> dictDestination = new Dictionary<int, string>()
            {
                {0, "Sungai Buloh" },
                {1, "Kampung Selamat" },
                {2, "Kwasa Damansara" },
                {3, "Kwasa Sentral" },
                {4, "Kota Damansara" }
            };

            ViewBag.Quantity = mrt.Quantity;
            ViewBag.Name = mrt.Name;
            ViewBag.Email = mrt.Email;

            ViewBag.Rate = rate;
            ViewBag.DictOrigin = dictOrigin;
            ViewBag.DictDestination = dictDestination;
            int originIndex = int.Parse(mrt.Origin);
            ViewBag.Origin = dictOrigin[originIndex];
            int destinationIndex = int.Parse(mrt.Destination);
            ViewBag.Destination = dictDestination[destinationIndex];

            double fare = rate[originIndex, destinationIndex];
            ViewBag.Fare = fare;
          
            return View("Result", mrt);
        }
    }
}