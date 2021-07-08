using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VegeMarketProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {
        private readonly ILogger<FruitController> _logger;

        public FruitController(ILogger<FruitController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Fruit> Get()
        {
            IEnumerable<Fruit> fruits = Enumerable.Range(1, 5).Select(index => new Fruit(
                DateTime.Now.AddDays(index), 0.4 * index, 0.12 * index)
            ).ToArray();
            return fruits;
        }
    }
}
