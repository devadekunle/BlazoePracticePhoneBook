using Microsoft.AspNetCore.Components;
using PhoneBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Pages.ContactDetails
{
    public class ContactDetailBase : ComponentBase
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        [Parameter]
        public string ContactId { get; set; }

        

        public Contact Contact { get; set; } = new Contact();

        protected override Task OnInitializedAsync()
        {
            InitializeCategories();
            InitializeContacts();

            Contact = Contacts.Find(c => c.Id ==int.Parse(ContactId));

            return base.OnInitializedAsync();
        }



        private void InitializeContacts()
        {
            var c1 = new Contact
            {

                FirstName = "Ingrid",
                LastName = "Onan",
                Email = "Ionan@gmail.com",
                Phone = "09826472654",
                CategoryId = 1,
                Id = 0,

            };
            var c2 = new Contact
            {

                FirstName = "Toi",
                LastName = "Esker",
                Email = "Tesker@gmail.com",
                Phone = "9471648264",
                CategoryId = 1,
                Id = 10,

            };
            var c3 = new Contact
            {

                FirstName = "Ping",
                LastName = "Charland",
                Email = "PCharland@gmail.com",
                Phone = "9472616484",
                CategoryId = 1,
                Id = 11,

            };
            Contacts.Add(c1);
            Contacts.Add(c2);
            Contacts.Add(c3);
        }

        private void InitializeCategories()
        {
            var ca1 = new Category
            {
                Id = 1,
                Color = Color.Blue,
                Name = "Friends"

            };
            var ca2 = new Category
            {
                Id = 2,
                Color = Color.Orange,
                Name = "Work"

            };

        }
    }


}
