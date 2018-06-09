﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iTextSharp.text;
using MvcRazorToPdf;
using ProjectWithAuthorization.Models;

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
            var component = new ComponentDetails()
            {
                Id = 0,
                ComponentName = "Some Component",
                CriticalityLevel = "5",
                Analogs = new List<ComponentList>()
                {
                new ComponentList() { Id = 0, Name = "First Component", CriticalityLevel="4", Vendor="rrrrr", CriticalityClass="table-warning"},
                new ComponentList() { Id = 1, Name = "Second Component", CriticalityLevel="1", Vendor="rrrrr", CriticalityClass="table-danger"},
                new ComponentList() { Id = 2, Name = "Third Component", CriticalityLevel="2", Vendor="rrrrr", CriticalityClass="table-light"}
                }
            };
            return View(component);
        }
        public ActionResult ShowComponentDetales()
        {
            ComponentDetails component = new ComponentDetails()
            {
                Id = 0,
                ComponentName = "Ilona",
                CriticalityLevel = "5",
                Analogs = new List<ComponentList>()
                {
                new ComponentList() { Id = 0, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-warning"},
                new ComponentList() { Id = 1, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-danger"},
                new ComponentList() { Id = 2, Name = "Some Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"}
                }
            };
            return View(component);
        }

        [HttpGet]
        public ActionResult GenerateReport(String text)//TODO Rebuild method and connect to repository
        {
            List<ComponentList> componentsList = new List<ComponentList>()
            {
                new ComponentList() { Id = 0, Name = "First Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-warning"},
                new ComponentList() { Id = 1, Name = "Second Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-danger"},
                new ComponentList() { Id = 2, Name = "Third Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"},
                new ComponentList() { Id = 3, Name = "Fourth Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"},
                new ComponentList() { Id = 4, Name = "Fifth Component", CriticalityLevel="5", Vendor="rrrrr", CriticalityClass="table-light"}
            };
            
            return new PdfActionResult("../Component/GenerateReport", componentsList, (writer, document) =>
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