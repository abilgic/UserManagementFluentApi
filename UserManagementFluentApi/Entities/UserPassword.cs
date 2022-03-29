using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementFluentApi.Entities
{
    public class UserPassword
    {
        public int Id { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public string Password3 { get; set; }

        //public int UserPasswordId { get; set; }
        //public virtual User User { get; set; }

    }
}
