using Contact.API.Infrastructure.Interfaces;
using Contact.API.Models.Dtos;

namespace Contact.API.Services.Classes
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int id)
        {
            return new ContactDto
            {
                Id = id,
                FirstName = "Özgür",
                LastName = "Gelekçi"
            };
        }
    }
}
