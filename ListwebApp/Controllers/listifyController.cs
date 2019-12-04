using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListwebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class listifyController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<int> Listify(int begin, int end, int index)
        {
            Listify list = new Listify(begin, end);
            return list[index];
          
        }

        
    }
}
