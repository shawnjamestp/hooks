using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooks.Shared.Domain
{
    public class Match : BaseDomainModel
    {
        public string UserID { get; set; }
        public string User2ID { get; set; }
        public DateTime MatchDate { get; set; }
        public string Status { get; set; }
    }
}
