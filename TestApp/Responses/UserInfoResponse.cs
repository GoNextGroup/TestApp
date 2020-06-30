using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data_Classes;

namespace TestApp.Responses
{
    public class ShortUserInfoResponse
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class UserInfoResponse
    {
        public Roles Role { get; set; }

        public ShortUserInfoResponse ShortUserInfo { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
