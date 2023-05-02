using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("cart_item")]
    public class CartItem : BaseEntity
    {
        [Column("shopping_session_id")]
        public int ShoppingSessionId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("ShoppingSessionId")]
        public ShoppingSession ShoppingSession { get; set; }

        [Column("quantity")]
        public long Quantity { get; set; }
    }
}
