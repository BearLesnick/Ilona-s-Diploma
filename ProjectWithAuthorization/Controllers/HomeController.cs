
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
            return RedirectToAction("ProjectList","Component");
        }

        [HttpGet]
        public ActionResult GenerateReport(Project project)
        {

           return RedirectToAction("GenerateReport", "Component",project);//TODO connect to entityModel
        }

        public ActionResult Components()
        {



            return RedirectToAction("ComponentList","Component");
        }

    }
}