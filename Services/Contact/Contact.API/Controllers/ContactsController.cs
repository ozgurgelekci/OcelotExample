using Contact.API.Infrastructure.Interfaces;
using Contact.API.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [HttpGet("{id}")]
        public ContactDto Get(int id)
        {
            return _contactService.GetContactById(id);
        }
    }
}
