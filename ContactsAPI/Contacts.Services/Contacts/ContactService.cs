using System.Collections.Generic;
using System.Threading.Tasks;
using Contacts.DataAccessLayer;
using Contacts.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Contacts.Services.Contacts
{
    public class ContactService : IContactService
    {
        private readonly ContactDbContext _dbContext;
        private readonly ILogger<ContactService> _logger;

        public ContactService(ContactDbContext dbContext, ILogger<ContactService> logger) 
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        // GET
        public async Task<IEnumerable<Contact>> GetContactAsync()
        {
                var contacts = await _dbContext.Set<Contact>().ToListAsync();
                if (contacts == null)
                {
                    _logger.LogWarning("No records in database");
                    return null;
                }
                return contacts;
        }

        // UPDATE
        public async Task<bool> UpdateContactAddressAsync(Contact contact)
        {
            _dbContext.Contacts.Attach(contact);
            _dbContext.Entry(contact).Property(x => x.Address).IsModified = true;
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
