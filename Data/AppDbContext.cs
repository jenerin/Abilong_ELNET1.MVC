using Microsoft.EntityFrameworkCore;
using Abilong_ELENET1.MVC.Models;

namespace Abilong_ELENET1.MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}