using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data_Classes
{
    public class DriverProfile : UserProfile
    {
        public bool IsPorter { get; set; }
        public bool IsHealthBook { get; set; }

        public bool IsAvailableForHire { get; set; }
    }
}
