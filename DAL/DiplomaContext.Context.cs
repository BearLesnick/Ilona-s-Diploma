﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class diploma_bdEntities : DbContext
    {
        public diploma_bdEntities()
            : base("name=diploma_bdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<analogs> analogs { get; set; }
        public DbSet<component> component { get; set; }
        public DbSet<criticality_level> criticality_level { get; set; }
        public DbSet<project> project { get; set; }
    }
}
