using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoronaApi.Models;
using CoronaApi.Services;

namespace CoronaApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoronaService _coronaService;

        public HomeController(CoronaService coronaService)
        {
            _coronaService = coronaService;
        }

        public async Task<IActionResult> Index(string name)
        {
            var modelList = await _coronaService.GetAllCountry();

            if (string.IsNullOrWhiteSpace(name))
            {
                return RedirectToAction("Country");
            }

            var country = ConvertEnglish.ToEnglish(name);
            var model = modelList.Where(x => x.country.ToLower() == country.ToLower()).FirstOrDefault();

            if (model != null)
            {
                ViewBag.country = country;
                return View(await _coronaService.GetByCountryName(country));
            }

            return RedirectToAction("Country");

        }

        public async Task<IActionResult> Country()
        {
            return View(await _coronaService.GetAllCountry());
        }


    }
}
