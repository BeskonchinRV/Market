using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string PoleName { get; set; }

        public Role(int roleId, string poleName)
        {
            RoleID = roleId;
            PoleName = poleName;
        }
    }
}
