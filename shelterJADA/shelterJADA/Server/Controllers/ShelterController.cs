using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using shelterJADA.Shared;


namespace shelterJADA.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShelterController : ControllerBase
    {

        private readonly ILogger<ShelterController> logger;

        public ShelterController(ILogger<ShelterController> logger)
        {
            this.logger = logger;
        }

        // Logik til at hente data ned fra .json dokument (ligger lokalt på server)
        [HttpGet]
        public IEnumerable<ShoppingItem> Get()
        {
            List<ShoppingItem> items;

            using (StreamReader r = new StreamReader("Hangover.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ShoppingItem>>(json);

                return items;
            }


        }







    }
        }
    }
}
