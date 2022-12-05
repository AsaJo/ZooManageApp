using Microsoft.EntityFrameworkCore;
using ZooManageApp.Models;

namespace ZooManageApp.Data
{
    public class ZooManageAppDbContext:DbContext
    {
        public ZooManageAppDbContext(DbContextOptions<ZooManageAppDbContext> options) : base(options) { }
        public DbSet<Animal>? Animals { get; set; } 
        public DbSet<Veterinary>? Veterinaries { get; set; }
    }
}
