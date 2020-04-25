using Microsoft.AspNetCore.Components;
using PhoneBook.Data;
using PhoneBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Pages
{
    public class PhoneBookOverviewBase : ComponentBase
    {
        [Inject]
        public IContactsDataService ContactsDataService { get; set; }

       
       
        protected async override Task OnInitializedAsync()
        {
           var response = await ContactsDataService.GetContacts(1, 25);
            Contacts = response.Results.Select(c => new Contact
            {
                Email = c.Email,
                FirstName = c.Name.First,
                LastName = c.Name.Last,
                Phone = c.Phone,
                ImageUrl = c.Picture.Medium.AbsoluteUri,


            }).ToList();
            

        }

        public List<Contact> Contacts { get; set; } = new List<Contact>();



    }
}
