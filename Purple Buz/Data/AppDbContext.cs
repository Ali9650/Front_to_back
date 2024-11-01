using Microsoft.EntityFrameworkCore;
using Purple_Buz.Entities;

namespace Purple_Buz.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<Work> Works { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AboutService> AboutServices { get; set; }

    }
}
