using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Interview.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private ILogger<AgentController> _ilog;

        public AgentController(ILogger<AgentController> ilogger)
        {
            _ilog = ilogger;
        }

        public void Get()
        {

        }
    }
}