using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nankivell_MIS4200.Models;
using System.Data.Entity;

namespace Nankivell_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,Nankivell_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Character> Character { get; set; }
        public DbSet<Adventure> Adventure { get; set; }
        public DbSet<Episode> Episode { get; set; }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    } 
}