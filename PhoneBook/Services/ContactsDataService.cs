using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public class ContactsDataService : IContactsDataService
    {
        private readonly HttpClient _httpClient;
        private readonly string Seed = "Adekunle"; 
        public ContactsDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ContactResponse> GetContacts(int page, int results)
        {
            var result = await _httpClient.GetAsync($"api/?page=1&results=10&seed=wrg");
            if (result.IsSuccessStatusCode)
            {
                var rie = await result.Content.ReadAsStringAsync();
                var works = JsonConvert.DeserializeObject<ContactResponse>(rie);
                return works ;
            }

            return default;
        }

        ContactResponse IContactsDataService.GetContactById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
