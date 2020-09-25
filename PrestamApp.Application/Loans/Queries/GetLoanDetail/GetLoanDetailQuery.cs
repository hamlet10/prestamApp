using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Loans.Queries.GetLoanDetail
{
   public class GetLoanDetailQuery : IRequest<LoanDetailDto>
    {
        public int LoanId { get; set; }

    }
}
