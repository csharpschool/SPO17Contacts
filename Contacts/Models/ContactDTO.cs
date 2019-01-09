using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class ContactDTO
    {
        [DisplayName("Contact Id")]
        public int Id { get; set; }
        [DisplayName("Contact Name")]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
