using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetWithReact.Domain.Errors
{
    public static class Errors
    {
        public static Error NotFound = Error.NotFound("Kayıt bulunamamıştır.");
        public static Error DbPersistence = Error.Failure("Kayıt işlemi sırasında hata oluştu");
       
    }
}
