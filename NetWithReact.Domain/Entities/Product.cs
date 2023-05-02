using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("product")]
    public class Product:BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("product_category_id")]
        public long ProductCategoryId { get; set; }

        [Column("product_inventory_id")]
        public long ProductInventoryId { get; set; }

        [Column("discount_id")]
        public long DiscountId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public ProductCategory ProductCategory { get; set; }

        [ForeignKey("ProductInventoryId")]
        public ProductInventory ProductInventory { get; set; }

        [ForeignKey("DiscountId")]
        public Discount Discount { get; set; }

    }
}
