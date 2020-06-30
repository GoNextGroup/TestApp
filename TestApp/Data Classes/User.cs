using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data_Classes
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public Roles Role { get; set; }

        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public UserProfile UserProfile { get; set; }

        public bool IsActive { get; set; }
        public int AccessFailedCount { get; set; }
    }
}
