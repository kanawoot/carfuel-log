﻿using CarFuel.Models.Facts;
using CarFuel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarFuel.Web.Controllers
{
    public class CarsController : Controller
    {
        private readonly IService<Car> _carService;
        public CarsController(IService<Car> carService) {

            _carService = carService;

        }
        // GET: Cars
        public ActionResult Index()
        {
            var cars = _carService.All();

            return View(cars);
        }

    }
}