using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWithAuthorization.Models
{
    public class Project
    {
        public Int32 Id { get; set; }
        public String ProjectName { get; set; }
        public DateTime CreationDate { get; set; }
        public String CriticalityClass { get; set; }
    }
}