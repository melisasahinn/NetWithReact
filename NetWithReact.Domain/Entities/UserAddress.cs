using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Domain.Entities
{
    [Table("user_adress")]
    public class UserAddress : BaseEntity
    {
        [Column("user_id")]
        public long UserId { get; set; }

        [Column("address_line")]
        public string AddressLine { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("phone_number")]
        public int PhoneNumber { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }



    }
}
