using Microsoft.EntityFrameworkCore;

namespace Contacts.Entities
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactDbContext(
            DbContextOptions<ContactDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
