using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Dispute
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime OpenedDate { get; set; }
        public string ArbiterId { get; set; }
        public string Complaint { get; set; }
        public string Result { get; set; }
        public string Status { get; set; }

        public AspNetUsers Arbiter { get; set; }
        public Order Order { get; set; }
    }
}
