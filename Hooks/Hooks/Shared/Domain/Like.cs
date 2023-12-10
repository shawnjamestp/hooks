using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooks.Shared.Domain
{
    public class Like : BaseDomainModel
    {
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public DateTime LikeDate { get; set; }
    }
}
