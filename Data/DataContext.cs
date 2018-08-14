using Microsoft.EntityFrameworkCore;
using WBA.API.Models;

namespace WBA.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}