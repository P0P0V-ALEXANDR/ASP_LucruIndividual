using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Adaugă acest using
using Microsoft.EntityFrameworkCore;
using App.Models;
using Microsoft.AspNetCore.Identity;  // Presupun că `Product` este în `App.Models`

namespace Studiu_Individual.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>  // Extinde IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        Database.EnsureCreated();
        }

        // DbSet pentru modelele tale
        public DbSet<Product> Products { get; set; }
    }
}
