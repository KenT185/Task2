using System.Threading.Tasks;
using Contacts.DataAccessLayer.Entities;
using Contacts.Services.Contacts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Contacts.WebAPI.Controllers 
{
    [ApiController]
    [Route("")]
    //[EnableCors("AllowOrigin")]
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
        //[EnableCors("AllowOrigin")]
        public async Task<IEnumerable<Contact>> GetDiet()
        {
            _logger.LogInformation("Got list of contacts");
            return await _iContactService.GetContactAsync();
        }

        //PUT: /Contact/1
        [HttpPut("{id}")]
        //[EnableCors("AllowOrigin")]
        public async Task<IActionResult> EditContactAddress(int id, Contact contact)
        {
            if (id != contact.Id)
            {
                _logger.LogWarning("Contact has not been updated, Id does not match");
                return BadRequest("Id does not match");
            }
            await _iContactService.UpdateContactAddressAsync(contact);
            _logger.LogInformation("Contact address has been updated");
            return NoContent();
        }
    }
}
