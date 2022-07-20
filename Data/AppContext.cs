using Microsoft.EntityFrameworkCore;

namespace ConsultantPlus.Data
{
    internal class AppContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }


        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=myEFCoreDB;trusted_connection=true;");
        }
    }
}
