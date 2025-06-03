using Microsoft.EntityFrameworkCore;
using PortfolyoSitem.Models;
using System.Collections.Generic;

namespace PortfolyoSitem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Project> Projects { get; set; }




    }
}
