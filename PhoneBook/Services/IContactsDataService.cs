using PhoneBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public interface IContactsDataService
    {

        Task<ContactResponse> GetContacts(int page, int results);

        ContactResponse GetContactById(Guid Id);
    }
}
