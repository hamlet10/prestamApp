using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Dues.Queries
{
    public class GetDueListQuery : IRequest<IEnumerable<DuesDto>>
    {
        public int LoanId { get; set; }
    }
}
