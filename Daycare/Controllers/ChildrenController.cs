using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Daycare.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Daycare.Services;

namespace Daycare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChildrenController : ControllerBase
    {
        IChildrenServices services;
        public ChildrenController(IChildrenServices services)
        {
            this.services = services;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var childrens = await services.GetChildrens_Data();
                return Ok(childrens);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

    }
}

