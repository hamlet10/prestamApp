using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.Zones.Queries.Commands;
using PrestamApp.Application.Zones.Queries.Commands.DeleteZone;
using PrestamApp.Application.Zones.Queries.GetZoneList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrestamApp.API.Controllers
{

    public class ZonesController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<ZoneDto>> Get()
        {
            return Ok(await Mediator.Send(new GetZoneListQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateZoneCommand command)
        {
            await Mediator.Send(command);
            return Ok(command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteZoneCommand { Id = id });
            return Ok("Zona eliminada exitosamente");
        }

    }
}
