
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectWithAuthorization.Models;
using Logic;
using Domain;

namespace ProjectWithAuthorization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("ProjectList","Project");
        }

        public ActionResult Components()
        {



            return RedirectToAction("ComponentList","Component");
        }

    }
}