using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masglobal_Application.CQRS.Query;
using Masglobal_Infrastructure.Dto_s;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Masglobal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediatory)
        {
            _mediator = mediatory;
        }
        // GET api/values
        [HttpGet]
        public async Task<List<EmployeeDto>>  Get()
        {
            return await _mediator.Send(new EmployeeQuery.Query());

        }

       

    }
}
