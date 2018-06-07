using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWithAuthorization.Models.Component
{
    public class ComponentDetailsMode
    {
        public Int32 Id { get; set; }
        public String ComponentName { get; set; }
        public String CriticalityLevel { get; set; }
        public String Vendor { get; set; }
        public List<ComponentListMode> Analogs { get; set; }
        public ComponentDetailsMode()
        {
            Analogs = new List<ComponentListMode>();
        }
    }
}