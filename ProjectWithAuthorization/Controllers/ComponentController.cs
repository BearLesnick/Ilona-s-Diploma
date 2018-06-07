using ProjectWithAuthorization.Models.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWithAuthorization.Controllers
{
    public class ComponentController : Controller
    {
        // GET: Component
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditComponent()
        {
            ComponentDetailsMode component = new ComponentDetailsMode()
            {
                Id = 0,
                ComponentName = "Some Component",
                CriticalityLevel = "5",
                Analogs = new List<ComponentListMode>()
                {
                new ComponentListMode() { Id = 0, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-warning"},
                new ComponentListMode() { Id = 1, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-danger"},
                new ComponentListMode() { Id = 2, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"}
                }
            };
            return View(component);
        }
        public ActionResult ShowComponentDetales()
        {
            ComponentDetailsMode component = new ComponentDetailsMode()
            {
                Id = 0,
                ComponentName = "Ilona",
                CriticalityLevel = "5",
                Analogs = new List<ComponentListMode>()
                {
                new ComponentListMode() { Id = 0, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-warning"},
                new ComponentListMode() { Id = 1, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-danger"},
                new ComponentListMode() { Id = 2, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"}
                }
            };
            return View(component);
        }
    }
}