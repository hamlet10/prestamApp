﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestamApp.Application.Dues;
using PrestamApp.Application.Dues.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrestamApp.API.Controllers
{
        public class DueController : BaseController

        {
            [HttpGet]
            public async Task<ActionResult<DuesDto>> Get(int id)
            {
                return Ok(await Mediator.Send(new GetDueListQuery { LoanId = id }));
            }

        }

    }
