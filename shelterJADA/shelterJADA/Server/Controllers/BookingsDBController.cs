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

        [HttpPost("opret")]
        public async Task AddBooking(Booking nyBooking)
        {
            var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

            var database = client.GetDatabase("Shelter");

            var collection = database.GetCollection<Booking>("Booking");

            nyBooking.Id = ObjectId.GenerateNewId().ToString();

            await collection.InsertOneAsync(nyBooking);
        }

        [HttpPost("slet")]
        public async Task DeleteBooking(Booking booking)
        {
            var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

            var database = client.GetDatabase("Shelter");

            var collection = database.GetCollection<BsonDocument>("Booking");

            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", booking.Id);

            await collection.DeleteOneAsync(deleteFilter);
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

                    bruger.fornavn = item["bruger"]["fornavn"].ToString();
                    bruger.efternavn = item["bruger"]["efternavn"].ToString();
                    bruger.email = item["bruger"]["email"].ToString();
                    bruger.telefon = item["bruger"]["telefon"].ToString();

                    shelter.shelter_navn = item["udlejet_shelter"]["shelter_navn"].ToString();
                    shelter.shelter_id = item["udlejet_shelter"]["shelter_id"].ToString();

                    nyBokking.start_dato = ((DateTime)item["start_dato"]);
                    nyBokking.slut_dato = ((DateTime)item["slut_dato"]);

                    nyBokking.Id = item["_id"].ToString();
                    nyBokking.bruger = bruger;
                    nyBokking.udlejet_shelter = shelter;

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
