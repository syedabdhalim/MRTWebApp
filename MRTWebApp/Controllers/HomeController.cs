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
            if (ModelState.IsValid)
            {
                double[,] rate =
            {
                {0.8, 1.2, 1.8, 2.0,2.6,2.7,3.1,3.3,3.2,3.5,3.3},
                {1.2, 0.8, 1.5, 1.8,2.3,2.7,2.8,3.1,3.4,3.3,3.7},
                {1.8, 1.5, 0.8, 1.1,1.8,2.1,2.6,2.6,3.0,3.2,3.3},
                {2.0, 1.8, 1.1, 0.8,1.6,1.9,2.3,2.6,2.8,3.0,3.1},
                {2.6, 2.3, 1.8, 1.6,0.8,1.3,1.8,2.0,2.4,2.8,3.0},
                {2.7, 2.7, 2.1, 1.9,1.3,0.8,1.3,1.7,2.0,2.4,2.7},
                {3.1, 2.8, 2.6, 2.3,1.8,1.3,0.8,1.3,1.7,2.0,2.6},
                {3.3, 3.1, 2.6, 2.6,2.0,1.7,1.3,0.8,1.3,1.7,2.2},
                {3.2, 3.4, 3.0, 2.8,2.4,2.0,1.7,1.3,0.8,1.2,1.8},
                {3.5, 3.3, 3.2, 3.0,2.8,2.4,2.0,1.7,1.2,0.8,1.6},
                {3.3, 3.7, 3.3, 3.1,3.0,2.7,2.6,2.2,1.8,1.6,0.8}
            };

                IDictionary<int, string> dictOrigin = new Dictionary<int, string>()
            {
                {0, "Sungai Buloh" },
                {1, "Kampung Selamat" },
                {2, "Kwasa Damansara" },
                {3, "Kwasa Sentral" },
                {4, "Kota Damansara" },
                {5, "Surian" },
                {6, "Mutiara Damansara" },
                {7, "Bandar Utama" },
                {8, "Taman Dr Tun Ismail" },
                {9, "Phelio Damansara" },
                {10, "Pusat Bandar Damansara" }
            };

                IDictionary<int, string> dictDestination = new Dictionary<int, string>()
            {
                {0, "Sungai Buloh" },
                {1, "Kampung Selamat" },
                {2, "Kwasa Damansara" },
                {3, "Kwasa Sentral" },
                {4, "Kota Damansara" },
                {5, "Surian" },
                {6, "Mutiara Damansara" },
                {7, "Bandar Utama" },
                {8, "Taman Dr Tun Ismail" },
                {9, "Phelio Damansara" },
                {10, "Pusat Bandar Damansara" }
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

                DateTime datetime = DateTime.Now;
                ViewBag.Datetime = datetime;
                return View("Result", mrt);
            }

            else
            {

                return View();
            }
        }
    }
}
