using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    public class UserPayment:BaseEntity
    {
        [Column("user_id")]
        public long UserId { get; set; }

        [Column("payment_type")]
        public string PaymentType { get; set; }

        [Column("account_no")]
        public long AccountNo { get; set; }

        [Column("expiry")]
        public DateTime Expiry { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
