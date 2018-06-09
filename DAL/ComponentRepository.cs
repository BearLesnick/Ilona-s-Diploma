using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComponentRepository
    {

        private DiplomaContext _dbContext = new DiplomaContext();

        public IEnumerable<component> GetComponentsList()
        {
            return _dbContext.Components.ToList();
        }

        public void AddComponent(component cmp)
        {
            _dbContext.Components.Add(cmp);
            _dbContext.SaveChanges();
        }
    }
}
