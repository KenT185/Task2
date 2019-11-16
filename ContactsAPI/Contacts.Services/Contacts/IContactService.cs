using Contacts.DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contacts.Services.Contacts
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetContactAsync();
        Task<bool> UpdateContactAddressAsync(Contact contact);
    }
}
