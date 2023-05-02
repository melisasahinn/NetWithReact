using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("discount")]
    public class Discount:BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("discount_percent")]
        public decimal DiscountPercent { get; set; }
    }
}
