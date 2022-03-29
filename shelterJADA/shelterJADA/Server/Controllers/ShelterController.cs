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
        public IEnumerable<Shelter> Get()
        {
            List<Shelter> shelters;

            using (StreamReader r = new StreamReader("Shelters.json"))
            {
                string json = r.ReadToEnd();

                shelters = JsonConvert.DeserializeObject<List<Shelter>>(json);

                return shelters;
            }


        }




      


        //        foreach (var item in liste)
        //        {
        //            float price = (float)item["price"];
        //OnlineItem nytOnlineItem = new OnlineItem($"{item["title"]}", false, price, $"{item["description"]}");

        //virkNuPlz.Add(nytOnlineItem);
        //        }

        //        return virkNuPlz;
               







    
        
    }
}
