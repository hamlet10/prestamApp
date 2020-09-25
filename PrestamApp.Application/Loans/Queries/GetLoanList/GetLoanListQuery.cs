using System.Collections.Generic;
using MediatR;

namespace PrestamApp.Application.Loans.Queries.GetLoanList
{
    public class GetLoanListQuery: IRequest<IEnumerable<LoanListDto>>
    {

    }
}