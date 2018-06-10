using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace Logic
{
    public class ComponentProcessing
    {
        private ComponentRepository _componentRepository = new ComponentRepository();
        ComponentList FromDbComponentToViewComponent(component component)
        {
            var addableComponent = new ComponentList();
            addableComponent.Id = component.ComponentId;
            addableComponent.CriticalityLevel = component.criticality_level.CriticalityLevel;
            addableComponent.Name = component.NameAndVersion;
            addableComponent.Vendor = component.VendorLink;
            switch (addableComponent.CriticalityLevel)
            {
                case "5":
                    addableComponent.CriticalityClass = "very high";
                    break;
                case "4":
                    addableComponent.CriticalityClass = "high";
                    break;
                case "3":
                    addableComponent.CriticalityClass = "medium";
                    break;
                case "2":
                    addableComponent.CriticalityClass = "low";
                    break;
                case "1":
                    addableComponent.CriticalityClass = "very low";
                    break;
            }

            return addableComponent;
        }
        public IEnumerable<ComponentList> GetAllComponents()
        {


            List<ComponentList> components = new List<ComponentList>();
            foreach (var component in _componentRepository.GetComponentsList())
            {
                var addableComponent = FromDbComponentToViewComponent(component);

                components.Add(addableComponent);
            }

            return components;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            var projects = _componentRepository.GetProjectList();
            var viewProjects = new List<Project>();
            foreach (var project in projects)
            {
                var addableproject = new Project();
                addableproject.Id = project.ProjectId;
                addableproject.CreationDate = (DateTime)project.CreationDate;
                addableproject.ProjectName = project.ProjectName;
                addableproject.CriticalityClass = "table-light";
                foreach (component component in project.component)
                {
                    addableproject.Components.Add(FromDbComponentToViewComponent(component));
                    if (component.criticality_level.CriticalityLevel == "very high")
                    {
                        addableproject.CriticalityClass = "table-warning";
                    }
                    viewProjects.Add(addableproject);
                }
            }

            return viewProjects;
        }

        public Project GetProjectById(int projectId)
        {
            var project = _componentRepository.GetProjectById(projectId);
            Project addableproject = new Project
            {
                Id = project.ProjectId,
                CreationDate = (DateTime) project.CreationDate,
                ProjectName = project.ProjectName,
                CriticalityClass = "table-light"
            };
            foreach (component component in project.component)
            {
                if (component.criticality_level.CriticalityLevel == "very high")
                {
                    addableproject.Components.Add(FromDbComponentToViewComponent(component));
                    addableproject.CriticalityClass = "table-warning";
                }
            }

            return addableproject;
        }
    }
}
