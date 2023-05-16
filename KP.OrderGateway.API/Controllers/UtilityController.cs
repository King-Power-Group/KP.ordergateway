using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KP.OrderGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UtilityController : ControllerBase
    {
        [HttpGet]
        [Route("test-token")]
        public bool TestToken()
        {
            return true;
        }
    }
}