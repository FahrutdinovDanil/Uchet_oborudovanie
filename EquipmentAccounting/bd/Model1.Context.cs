﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquipmentAccounting.bd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UchetEntities : DbContext
    {
        public UchetEntities()
            : base("name=UchetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Equipment_type> Equipment_type { get; set; }
        public virtual DbSet<Production_plot> Production_plot { get; set; }
        public virtual DbSet<Сompany> Сompany { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Breakdown_during_inspection> Breakdown_during_inspection { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Equipment_failure> Equipment_failure { get; set; }
        public virtual DbSet<Technical_inspection> Technical_inspection { get; set; }
    }
}
