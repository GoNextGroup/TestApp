using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data_Classes;

namespace TestApp.Responses
{
    public class UserProfileResponse
    {
        public Roles RoleProfile { get; set; }

        public bool? IsHealthBook { get; set; }
        public bool? IsPorter { get; set; }
        public bool? IsAvailableForHire { get; set; }
    }

    public class UserProfileCollectionResponse
    {
        public ICollection<UserProfileResponse> UserProfiles { get; set; }
    }
}
