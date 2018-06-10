using System;
using System.Collections.Generic;

namespace Domain
{
    public class ProjectDetailed
    {
        public Int32 Id { get; set; }
        public String ProjectName { get; set; }
        public DateTime CreationDate { get; set; }
        public String CriticalityClass { get; set; }
        public List<ComponentDetails> Components { get; set; }

    }
}