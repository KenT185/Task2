using Contacts.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Contacts.DataAccessLayer
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) 
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    Name = "Name1",
                    Surname = "Surname1",
                    PhoneNumber = "123456789",
                    Email = "mail1@o2.pl",
                    Address = "Lazurowa 42A"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Name2",
                    Surname = "Surname2",
                    PhoneNumber = "9876543",
                    Email = "mail2@o2.pl",
                    Address = "Szamocka 8"
                },
                new Contact
                {
                    Id = 3,
                    Name = "Name3",
                    Surname = "Surname3",
                    PhoneNumber = "333333333",
                    Email = "mail3@o2.pl",
                    Address = "Górczewska 22"
                });
        }
    }
}
