using System.Threading.Tasks;
using Contacts.DataAccessLayer.Entities;
using Contacts.Services.Contacts;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.WebAPI.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _iContactService;
        private readonly ILogger<ContactController> _logger;

        public ContactController(IContactService iContactService, ILogger<ContactController> logger)
        {
            _iContactService = iContactService;
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into ContactController");
        }

        [HttpGet]
        public async Task<IEnumerable<Contact>> GetContact()
        {
            _logger.LogInformation("Got list of contacts");
            return await _iContactService.GetContactAsync();
        }

        [HttpPut]
        public async Task<IActionResult> EditContactAddress([FromBody]Contact contact)
        {
            await _iContactService.UpdateContactAddressAsync(contact);
            _logger.LogInformation("Contact address has been updated");
            return Ok(contact);
        }
    }
}
