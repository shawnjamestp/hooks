using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooks.Shared.Domain
{
    public class Location : BaseDomainModel
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}
