using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using shelterJADA.Shared;


namespace shelterJADA.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingsDBController : ControllerBase
    {

        private readonly ILogger<BookingsDBController> logger;

        public BookingsDBController(ILogger<BookingsDBController> logger)
        {
            this.logger = logger;
        }

        [HttpPost()]
        public async Task AddBooking(Booking nyBooking)
        {
            var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

            var database = client.GetDatabase("Shelter");

            var collection = database.GetCollection<Booking>("Booking");

            await collection.InsertOneAsync(nyBooking);
        }

        // Logik til at hente data ned fra .json dokument (ligger lokalt på server)
        [HttpGet()]
        public async Task<IEnumerable<Booking>> GetAsync()
        {
            try
            {
                var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

                var database = client.GetDatabase("Shelter");

                var collection = database.GetCollection<BsonDocument>("Booking");

                var list = await collection.Find(_ => true).ToListAsync();

                List<Booking> bookings = new List<Booking>();

                foreach (var item in list)
                {
                    Booking nyBokking = new Booking();

                    Bruger bruger = new Bruger();
                    Udlejet_Shelter shelter = new Udlejet_Shelter();

                    bruger.Fornavn = item["bruger"]["fornavn"].ToString();
                    bruger.Efternavn = item["bruger"]["efternavn"].ToString();
                    bruger.Email = item["bruger"]["email"].ToString();
                    bruger.Telefon = item["bruger"]["telefon"].ToString();

                    shelter.Shelter_Navn = item["udlejet_shelter"]["shelter_navn"].ToString();
                    shelter.Shelter_Id = item["udlejet_shelter"]["shelter_id"].ToString();

                    nyBokking.Start_Dato = ((DateTime)item["start_dato"]);
                    nyBokking.Slut_Dato = ((DateTime)item["slut_dato"]);

                    nyBokking.Id = item["_id"].ToString();
                    nyBokking.Bruger = bruger;
                    nyBokking.Udlejet_Shelter = shelter;

                    bookings.Add(nyBokking);

                }

                return bookings;


            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (Newtonsoft.Json.JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;



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
