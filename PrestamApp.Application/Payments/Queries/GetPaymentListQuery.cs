using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Payments.Queries
{
    public class GetPaymentListQuery : IRequest<IEnumerable<PaymentDto>>
    {
        public int LoanId { get; set; }

    }
}
