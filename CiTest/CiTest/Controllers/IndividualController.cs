using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CiTest.Controllers
{
    [ApiController]
    public class IndividualController : ControllerBase
    {
      

        private readonly ILogger<IndividualController> logger;

        public IndividualController(ILogger<IndividualController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        [Route("GetIndividual")]
        public String Get()
        {
            return string.Empty;
        }
    }
}
