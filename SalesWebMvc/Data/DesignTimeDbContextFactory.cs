using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace SalesWebMvc.Data {
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SalesWebMvcContext> {
        public SalesWebMvcContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<SalesWebMvcContext>();
            optionsBuilder.UseMySql(
                "Server=localhost;Database=SalesWebMvc;User=root;Password=123456;",
                new MySqlServerVersion(new Version(8, 0, 28))
            );

            return new SalesWebMvcContext(optionsBuilder.Options);
        }
    }
}
