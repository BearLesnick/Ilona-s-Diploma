using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ComponentRepository
    {
        private readonly Entities1 _dbContext = new Entities1();

        public IEnumerable<component> GetComponentsList()
        {
            return _dbContext.component.ToList();

        }

        public component GetComponentById(int componentId)
        {
            return _dbContext.component.Find(componentId);
        }

        public bool AddComponent(component cmp)
        {
            _dbContext.component.Add(cmp);
            _dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<project> GetProjectList()
        {
            return _dbContext.project.ToList();
        }

        public project GetProjectById(int id)
        {
            try
            {
                return (project) _dbContext.project.Find(id);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
