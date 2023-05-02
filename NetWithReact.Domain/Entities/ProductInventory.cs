using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("product_inventory")]
    public class ProductInventory :BaseEntity
    {
        [Column("quantity")]
        public long Quantity { get; set; }
    }
}
