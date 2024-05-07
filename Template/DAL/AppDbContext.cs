using Microsoft.EntityFrameworkCore;
using Template.Models;

namespace Template.DAL
{
    public class AppDbContext : DbContext 
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Product>  Products {  get; set; }


        public DbSet<Farmer> Farmers { get; set; }


    }
}
