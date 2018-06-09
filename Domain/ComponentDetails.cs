using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Domain
{
    public class ComponentDetails
    {
        public Int32 Id { get; set; }
        public String ComponentName { get; set; }
        public String CriticalityLevel { get; set; }
        public String Vendor { get; set; }
        public List<ComponentList> Analogs { get; set; }
        public ComponentDetails()
        {
            Analogs = new List<ComponentList>();
        }
    }
}