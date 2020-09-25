using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.Collectors.Commands;
using PrestamApp.Application.Collectors.Commands.DeleteCollector;
using PrestamApp.Application.Collectors.Commands.UpdateCollector;
using PrestamApp.Application.Collectors.Queries.GetCollectorDetail;
using PrestamApp.Application.Collectors.Queries.GetCollectorList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrestamApp.API.Controllers
{
    
    public class CollectorsController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<CollectorDto>> Get()
        {
            return Ok(await Mediator.Send(new GetCollectorListQuery()));
        }

        [HttpGet]
        public async Task<ActionResult<CollectorDetailDto>> GetDetail(int id)
        {
            return Ok(await Mediator.Send(new GetCollectorDetailQuery { Id = id }));

        }

        [HttpPost]
        public async Task<IActionResult> CreateCollector ([FromBody] CreateCollectorCommand command)
        {
            await Mediator.Send(command);
            return Ok(command);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UpdateCollectorCommand command)
        {
            await Mediator.Send(command);
            return Ok(command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteCollectorCommand { Id = id });
            return Ok("Cobrador eliminado exitosamente");
        } 


    }
}
