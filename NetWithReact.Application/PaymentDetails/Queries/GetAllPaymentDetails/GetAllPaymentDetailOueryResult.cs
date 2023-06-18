using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Queries.GetAllPaymentDetails
{
    public record GetAllPaymentDetailOueryResult
     (int CurrentPage,
    int PageSize,
    int TotalPageCount,
    int TotalRowCount,
    List<NetWithReact.Domain.Entities.PaymentDetails> Data);
}
