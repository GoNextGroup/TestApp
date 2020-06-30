using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data_Classes
{

    public class UserProfile
    {
        [Key]
        public Guid Id { get; set; }

        public Roles RoleProfile { get; set; }
        public bool IsActive { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
