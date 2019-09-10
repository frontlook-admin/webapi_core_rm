﻿using Microsoft.EntityFrameworkCore;
using wepapi_core.Models;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wepapi_core.Models
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    
    public class employmentEntities : DbContext
    {
        public employmentEntities(DbContextOptions options)
            : base(options)
        {
        }

        public employmentEntities()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<employee_recruit> employee_recruit { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<version> versions { get; set; }
        //public virtual DbSet<__efmigrationshistory> C__efmigrationshistory { get; set; }
        //public DbSet<employee_manager> employee_manager { get; set; }
        //public DbSet<user_manager> user_manager { get; set; }

    }
}
