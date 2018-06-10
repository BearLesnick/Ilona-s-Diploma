using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using iTextSharp.text;
using MvcRazorToPdf;
using Logic;
namespace ProjectWithAuthorization.Controllers
{
    public class ComponentController : Controller
    {
        ComponentProcessing _logic = new ComponentProcessing();
        // GET: Component
        public ActionResult Index()
        {
            return RedirectToAction("ComponentList","Component");
        }
        public ActionResult EditComponent(int componentId)//TODO
        {
            var component = _logic.GetComponentDetails(componentId);

            return View(component);
        }
        public ActionResult ShowComponentDetales(int componentId)
        {
            ComponentDetails component = _logic.GetComponentDetails(componentId);
            return View(component);
        }

        public ActionResult ComponentList()
        {
            return View(_logic.GetAllComponents());
        }
        
    }
}