using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using iTextSharp.text;
using Logic;
using MvcRazorToPdf;

namespace ProjectWithAuthorization.Controllers
{
    public class ProjectController : Controller
    {
        ComponentProcessing _logic = new ComponentProcessing();
        // GET: Project
        public ActionResult Index()
        {
            return RedirectToAction("ProjectList", "Project");
        }
        public ActionResult CreateNewProject()
        {
            return View();
        }
        public ActionResult ProjectList()
        {
            return View(_logic.GetAllProjects());
        }

        [HttpGet]
        public ActionResult LoadConfigurationAndCreateProject(String projectName)
        {
            return RedirectToAction("ProjectList", "Project");//TODO
        }
        [HttpGet]
        public ActionResult LoadConfiguration(Project projet)
        {
            return RedirectToAction("ProjectList", "Project");//TODO 
        }

        [HttpGet]
        public ActionResult ProjectView(int projectId)
        {

            return View(_logic.GetProjectById(projectId));
        }
        [HttpGet]
        public ActionResult GenerateReport(int projectId)//TODO Rebuild method and connect to repository
        {
            var project = _logic.GetProjectById(projectId);

            return new PdfActionResult("GenerateReport", project, (writer, document) =>
            {
                document.SetPageSize(new Rectangle(500f, 500f, 90));
                document.NewPage();
            })
            {
                FileDownloadName = "Report.pdf"
            };
        }
    }
}