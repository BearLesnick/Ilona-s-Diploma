
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace ProjectWithAuthorization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Project> projectsList = new List<Project>()
            {
                new Project() { Id = 0, ProjectName = "My workspace", CreationDate=new DateTime(2018,6,3,4,12,34), CriticalityClass="table-light"},
                new Project() { Id = 1, ProjectName = "Test Project", CreationDate=new DateTime(2018,5,21,21,1,12), CriticalityClass="table-light"},
                new Project() { Id = 2, ProjectName = "First project", CreationDate=new DateTime(2018,5,18,14,45,1), CriticalityClass="table-light"},
            };
            return View(projectsList);
        }

        [HttpGet]
        public ActionResult GenerateReport(String text)
        {

           return RedirectToAction("GenerateReport", "Component",text);//TODO connect to entityModel
        }

        public ActionResult Components()
        {
            List<ComponentList> componentsList = new List<ComponentList>()
            {
                new ComponentList() { Id = 0, Name = "First Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-warning"},
                new ComponentList() { Id = 1, Name = "Second Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-danger"},
                new ComponentList() { Id = 2, Name = "Third Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"},
                new ComponentList() { Id = 3, Name = "Fourth Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"},
                new ComponentList() { Id = 4, Name = "Fifth Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"}
            };


            return View(componentsList);
        }

        public ActionResult New()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}