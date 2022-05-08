using Contact.API.Models.Dtos;

namespace Contact.API.Infrastructure.Interfaces
{
    public interface IContactService
    {
        public ContactDto GetContactById(int id);
    }
}
