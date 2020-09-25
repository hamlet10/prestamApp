using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.Loans.Commands.CreateLoan;
using PrestamApp.Application.Loans.Commands.CreateLoanWithDues;
using PrestamApp.Application.Loans.Commands.DeleteLoan;
using PrestamApp.Application.Loans.Queries.GetLoanDetail;
using PrestamApp.Application.Loans.Queries.GetLoanList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrestamApp.API.Controllers
{
    
    public class LoanController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<LoanListDto>> GetLoanList()

        {
            return Ok(await Mediator.Send(new GetLoanListQuery ()));
        }

        [HttpGet]
        public async Task<ActionResult<LoanDetailDto>> GetDetail(int id)
        {
            return Ok(await Mediator.Send(new GetLoanDetailQuery { LoanId = id }));
        }

        [HttpPost]
        public async Task<ActionResult> Create( [FromBody] CreateLoanWithDuesCommand command)
        {
            await Mediator.Send(command);
            return Ok(command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteLoanCommand { Id = id });
            return Ok("Prestamo eliminado exitosamente");
        }


    }
}
