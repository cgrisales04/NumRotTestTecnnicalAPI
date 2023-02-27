using Microsoft.EntityFrameworkCore;
using NumRotTestTecnnicalAPI.Persistence.Repository.InfoUser;
using System.Security.Principal;

namespace NumRotTestTecnnicalAPI.Persistence.Entity
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Genders>? Genders { get; set; }
        public DbSet<TypeUsers>? TypeUsers { get; set; }
        public DbSet<InfoUsers>? InfoUsers { get; set; }
    }
}
