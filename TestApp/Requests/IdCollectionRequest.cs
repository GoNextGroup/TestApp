using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Requests
{
    public class IdCollectionRequest
    {
        public ICollection<Guid> Ids { get; set; }
    }
}
