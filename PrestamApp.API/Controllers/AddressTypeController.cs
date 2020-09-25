using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.AddressTypes.Queries;
using PrestamApp.Application.TimeFrames.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamApp.API.Controllers
{
    public class AddressTypeController : BaseController

    {
        [HttpGet]
        public async Task<ActionResult<AddresTypeDto>> Get()
        {
            return Ok(await Mediator.Send(new GetAddressTypeListQuery()));
        }
    }
}
