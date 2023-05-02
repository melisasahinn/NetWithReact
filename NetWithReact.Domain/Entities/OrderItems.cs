using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("OrderItems")]
    public class OrderItems:BaseEntity
    {
        [Column("order_id")]
        public long OrderId { get; set; }

        [Column("product_id")]
        public long ProductId { get; set; }

        [Column("quantity")]
        public long Quantity { get; set; }

        [ForeignKey("order_id")]
        public OrderDetails  OrderDetails { get; set; }

        [ForeignKey("product_id")]
        public Product Product { get; set; }
    }
}
