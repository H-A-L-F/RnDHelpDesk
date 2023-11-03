using RnDHelpDesk.Domain.Common;
using RnDHelpDesk.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnDHelpDesk.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public string Username { get; set; }
        public Role Role { get; set; }
    }
}
