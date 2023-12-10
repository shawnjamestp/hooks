using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooks.Shared.Domain
{
    public class Preference : BaseDomainModel
    {
        public string UserID { get; set; }
        public int AgeStart { get; set; }
        public int AgeEnd { get; set;}
        public string Gender { get; set; }
    }
}
