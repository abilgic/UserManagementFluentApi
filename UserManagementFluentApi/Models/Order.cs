using System;
using System.Collections.Generic;

namespace UserManagementFluentApi.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int? PersonId { get; set; }

        public virtual Person? Person { get; set; }
    }
}
