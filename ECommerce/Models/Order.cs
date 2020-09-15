using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Order
    {
        public Order()
        {
            Dispute = new HashSet<Dispute>();
        }

        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int ServiceId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public int? Rating { get; set; }
        public string OrderNotes { get; set; }
        public string RatingNotes { get; set; }

        public AspNetUsers Customer { get; set; }
        public Service Service { get; set; }
        public ICollection<Dispute> Dispute { get; set; }
    }
}
