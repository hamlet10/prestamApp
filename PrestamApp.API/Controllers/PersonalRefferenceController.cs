using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrestamApp.Application.PersonalRefferences.Commands;

namespace PrestamApp.API.Controllers
{
    public class PersonalRefferenceController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePersonalRefferenceCommand command)
        {
            await Mediator.Send(command);
            return Ok(command);
        }
    }
}
