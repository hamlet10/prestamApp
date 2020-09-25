using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.Loans.Queries.GetLoanList;
using PrestamApp.Application.Payments;
using PrestamApp.Application.Payments.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrestamApp.API.Controllers
{
    
    public class PaymentsController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<PaymentDto>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetPaymentListQuery { LoanId = id }));
        }
    }
}
