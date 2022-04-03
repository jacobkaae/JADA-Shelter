using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using shelterJADA.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace shelterJADA.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingsDBController : ControllerBase
    {
        // Connection variabler til MongoDB
        private const string ConnectionString = "mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority";
        private const string DatabaseName = "Shelter";
        private const string BookingCollection = "Booking";

        // Opretter et nyt booking dokument i databasen
        [HttpPost("opret")]
        public async Task AddBooking(Booking nyBooking)
        {
            // Connecter til vores database og collection:
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<Booking>(BookingCollection);

            nyBooking.Id = ObjectId.GenerateNewId().ToString();

            await collection.InsertOneAsync(nyBooking);
        }

        // Sletter et booking dokument fra booking collection
        [HttpPost("slet")]
        public async Task DeleteBooking(Booking booking)
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<BsonDocument>(BookingCollection);

            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", booking.Id);

            await collection.DeleteOneAsync(deleteFilter);
        }

        // Logik til at hente data ned fra .json dokument (ligger lokalt på server)
        [HttpGet()]
        public async Task<IEnumerable<Booking>> GetAsync()
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<BsonDocument>(BookingCollection);

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
    }
}