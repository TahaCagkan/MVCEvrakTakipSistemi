﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEvrakTakipSistemi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVCEvrakTakipDBEntities : DbContext
    {
        public MVCEvrakTakipDBEntities()
            : base("name=MVCEvrakTakipDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Durumlar> Durumlar { get; set; }
        public virtual DbSet<Evraklar> Evraklar { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<Raporlar> Raporlar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yerler> Yerler { get; set; }
        public virtual DbSet<Yetkiler> Yetkiler { get; set; }
    }
}
