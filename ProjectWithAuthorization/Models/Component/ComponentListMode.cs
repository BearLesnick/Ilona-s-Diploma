using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWithAuthorization.Models.Component
{
    public class ComponentListMode
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String CriticalityLevel { get; set; }
        public String Vendor { get; set; }
        public String CriticalityClass { get; set; }
    }
}