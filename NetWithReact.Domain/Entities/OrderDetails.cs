using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("order_details")]
    public class OrderDetails : BaseEntity
    {
        [Column("user_id")]
        public long UserId { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("payment_details_id")]
        public long PaymentDetailsId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("payment_details_id")]
        public PaymentDetails  PaymentDetails { get; set; }

    }
}
