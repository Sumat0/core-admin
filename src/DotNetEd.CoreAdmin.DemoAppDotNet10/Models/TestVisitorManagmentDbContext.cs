using Microsoft.EntityFrameworkCore;

namespace DotNetEd.CoreAdmin.DemoApp.Models
{
    public class TestVisitorManagmentDbContext : DbContext
    {
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Visitor> Visitors { get; set; }

#pragma warning disable CS8618
        public TestVisitorManagmentDbContext(DbContextOptions<TestVisitorManagmentDbContext> contextOptions) : base(contextOptions)
#pragma warning restore CS8618
        {
        }
    }
}
