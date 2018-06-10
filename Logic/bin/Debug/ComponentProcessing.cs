using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                addableproject.CriticalityClass = "normal";
                addableproject.Components = new List<ComponentList>();
                foreach (component component in project.component)
                {
                    addableproject.Components.Add(FromDbComponentToViewComponent(component));
                    if (component.criticality_level.CriticalityLevel == "very high")
                    {
                        addableproject.CriticalityClass = "very high";
                    }
                    
                }
                viewProjects.Add(addableproject);
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
                CriticalityClass = "normal",
                Components = new List<ComponentList>()
                
            };
            foreach (component component in project.component)
            {
                if (component.criticality_level.CriticalityLevel == "very high")
                {
                    addableproject.Components.Add(FromDbComponentToViewComponent(component));
                    addableproject.CriticalityClass = "very high";
                }
            }

            return addableproject;
        }

        public ComponentDetails GetComponentDetails(int componentId)
        {
            var component = _componentRepository.GetComponentById(componentId);
            var analogs = new List<ComponentList>();
            foreach (component com in component.component2)
            {
                analogs.Add(FromDbComponentToViewComponent(com));
            }

            ComponentDetails details = new ComponentDetails()
            {
                ComponentName = component.NameAndVersion,
                CriticalityLevel = component.criticality_level.CriticalityLevel,
                Vendor = component.VendorLink,
                Analogs = analogs
            };
            return details;
        }
    }
}
