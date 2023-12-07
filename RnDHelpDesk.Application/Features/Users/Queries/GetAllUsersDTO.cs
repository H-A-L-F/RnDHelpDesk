using RnDHelpDesk.Application.Common.Mappings;
using RnDHelpDesk.Domain.Entities;
using RnDHelpDesk.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnDHelpDesk.Application.Features.Users.Queries
{
    public class GetAllUsersDTO : IMapFrom<User>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
