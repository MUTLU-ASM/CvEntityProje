﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvEntityProje.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CvEntityDBEntities : DbContext
    {
        public CvEntityDBEntities()
            : base("name=CvEntityDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adres> adres { get; set; }
        public virtual DbSet<calismalar> calismalar { get; set; }
        public virtual DbSet<hakkinda> hakkinda { get; set; }
        public virtual DbSet<iletisim> iletisim { get; set; }
        public virtual DbSet<yetenekler> yetenekler { get; set; }
        public virtual DbSet<admin> admin { get; set; }
    }
}
