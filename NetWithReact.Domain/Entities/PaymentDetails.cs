using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("payment_details")]
    public class PaymentDetails : BaseEntity
    {
        [Column("order_id")]
        public long OrderId { get; set; }

        [Column("amount")]
        public int Amount { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [ForeignKey("OrderId")]
        public OrderDetails OrderDetails { get; set; }

    }
}
