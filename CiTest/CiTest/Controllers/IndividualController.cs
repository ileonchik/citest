using System;
using System.Collections.Generic;
using System.Linq;
using CiTest.Database;
using CiTest.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

namespace CiTest.Controllers
{

    [ApiController]
    [Route("individual")]
    public class IndividualController : ControllerBase
    {
      

        private readonly ILogger<IndividualController> logger;

        public IndividualController(ILogger<IndividualController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        [Route("SearchIndividual")]
        public bool Search(string nationalId)
        {
            return DatabaseManager.Instance.Context.Individuals.Count(i => i.NationalID==nationalId) > 0;
        }

        [HttpGet]
        [Route("Details")]
        public IActionResult Details(string nationalId)
        {
            var individual = DatabaseManager.Instance.Context.Individuals.SingleOrDefault(i => i.NationalID == nationalId);
            if (individual != null)
            {
                var contracts = DatabaseManager.Instance.Context.Contracts.Where(
                    c => c.Individuals.Any(i => i.NationalID == nationalId)).ToList();
                return new JsonResult(new DetailedIndividual(individual, contracts));
            }
            else
            {
                return new NotFoundResult();
            }
        }
    }
}
