using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data_Classes
{
    public class LogistianProfile : UserProfile
    {
        public int GainRoutes { get; set; }

        public bool IsAvailableForHire { get; set; }
    }
}
