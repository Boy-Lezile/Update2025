using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data {
    public class SalesWebMvcContext : DbContext {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options) {
        }

        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Seller> Sellers { get; set; } = null!;
        public DbSet<SalesRecord> SalesRecords { get; set; } = null!;
    }
}
