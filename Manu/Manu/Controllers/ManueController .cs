using Manu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManueController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Manue> Get()
        {
            using (var context = new ManueContext())
            {
                return context.Manue.ToList();
            }
        }
    }
}
