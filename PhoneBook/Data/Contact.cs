using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public class Contact
    {
        public int Id { get; set; }
        public Guid UUID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }       
}
