﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semester2Challenge2BasketballApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Semester2Challenge2Entities2 : DbContext
    {
        public Semester2Challenge2Entities2()
            : base("name=Semester2Challenge2Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }
    }
}