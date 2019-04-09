using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Scaffolding.EntityFramework;

namespace Vidly.Models
{
    public class ModelContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get;set;} 
        public DbSet<Genre> Genres { get; set; }

        public ModelContext():base("MVCDBContext")
        {

        }

    }
}