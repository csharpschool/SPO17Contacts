using Microsoft.EntityFrameworkCore;

namespace Contacts.Entities
{
    // För att skapa ny migration när något förändrats: add-migration NamnPåMigration
    // För att uppdatera databasen med de nya ändringarna: update-database

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
