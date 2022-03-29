using System;
using System.Collections.Generic;

namespace UserManagementFluentApi.Models
{
    public partial class Person
    {
        public Person()
        {
            Orders = new HashSet<Order>();
        }

        public int PersonId { get; set; }
        public string LastName { get; set; } = null!;
        public string? FirstName { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
