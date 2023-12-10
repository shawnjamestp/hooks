using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooks.Shared.Domain
{
    public class Message : BaseDomainModel
    {
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Status { get; set; }
    }
}
