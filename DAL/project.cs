//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class project
    {
        public project()
        {
            this.component = new HashSet<component>();
        }
    
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string AuthorId { get; set; }
    
        public virtual ICollection<component> component { get; set; }
    }
}
