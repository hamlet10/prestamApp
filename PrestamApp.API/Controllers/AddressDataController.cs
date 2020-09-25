using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.AddressDatas.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamApp.API.Controllers
{
    public class AddressDataController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<AddressDataDto>> Get(int? parentId)
        {
            return Ok(await Mediator.Send(new GetAddressDataListQuery { ParentId = parentId }));
        }
    }
}
