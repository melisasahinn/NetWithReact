using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("product_category")]
    public class ProductCategory : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

    }
}
