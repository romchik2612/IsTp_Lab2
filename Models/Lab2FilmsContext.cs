using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IsTp_Lab2.Models
{
    public class Lab2FilmsContext : DbContext
    {
        public virtual DbSet<Film> Films { get; set; }

        public virtual DbSet<Actors> Actors { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Studio> Studios { get; set; }

        public Lab2FilmsContext(DbContextOptions<Lab2FilmsContext> options) : base(options){
            Database.EnsureCreated();
        }
    }
}
