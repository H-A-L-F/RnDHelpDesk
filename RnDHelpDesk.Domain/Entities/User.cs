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
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string username, string password, Role role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
