using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementFluentApi.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public int UserRoleId { get; set; }

        public virtual User User { get; set; }

    }
}
