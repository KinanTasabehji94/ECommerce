using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string NationalId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string HomeLocation { get; set; }
        public string Gender { get; set; }
        public string UserType { get; set; }
        public DateTime RegisteredDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Active";
    }
}
