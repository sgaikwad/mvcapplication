﻿using System.ComponentModel.DataAnnotations;
using MvcApplicationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        [NonNullableParameters]
        public ActionResult Index(SearchModel searchModel)
        {
            var restaurants = RestaurantData.GetRestaurants();

            IEnumerable<Restaurant> model = null;

            if (ModelState.IsValid)
            {
                model = restaurants
                    .OrderByDescending(r => r.Id)
                    .Where(
                        r =>
                            searchModel == null || searchModel.SearchTerm == null ||
                            r.Name.StartsWith(searchModel.SearchTerm))
                    .Select(r => new Restaurant
                    {
                        Id = r.Id,
                        Name = r.Name,
                        City = r.City,
                        Country = r.Country
                    });

            }
            if (Request.IsAjaxRequest())
            {
                return PartialView("_PartialRestaurantView", model);
            }
            return View(model);
        }

        public ActionResult About()
        {

            var aboutModel = new AboutModel();
            aboutModel.Name = "Sachin Dattatraya Gaikwad";
            aboutModel.Location = "Pune";

            var view = View(aboutModel);

            return view;

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Search(string name)
        //{
        //    var restaurants = RestaurantData.GetRestaurants();

        //    var model = restaurants
        //        .OrderByDescending(r => r.Id)
        //        .Where(r => name == null || r.Name.StartsWith(name))
        //        .Select(r => new Restaurant
        //        {
        //            Id = r.Id,
        //            Name = r.Name,
        //            City = r.City,
        //            Country = r.Country
        //        });

        //    return View(model);
        //}
    }
}
