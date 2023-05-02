using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("shopping_session")]
    public class ShoppingSession : BaseEntity
    {
        [Column("user_id")]
        public long UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
