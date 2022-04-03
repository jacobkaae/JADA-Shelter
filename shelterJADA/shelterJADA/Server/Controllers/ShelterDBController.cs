using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using shelterJADA.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace shelterJADA.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShelterDBController : ControllerBase
    {
        // Connection variabler til MongoDB
        private const string ConnectionString = "mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority";
        private const string DatabaseName = "Shelter";
        private const string SheltersCollection = "shelter_6";

        // Logik at hente sheltere basseret på kommune
        [HttpGet("all")]
        public async Task<IEnumerable<Shelter>> GetAsync()
        {
            // Connecter til vores database og collection:
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<BsonDocument>(SheltersCollection);

            var list = await collection.Find(_ => true).ToListAsync();

            List<Shelter> shelterListe = new List<Shelter>();

            foreach (var item in list)
            {
                Properties opsætning = new Properties();

                opsætning.Cvr_navn = item["properties"]["cvr_navn"].ToString();
                opsætning.Kommunekode = item["properties"]["kommunekode"].ToInt32();
                opsætning.Facil_ty = item["properties"]["facil_ty"].ToString();
                opsætning.Navn = item["properties"]["navn"].ToString();
                opsætning.Beskrivels = item["properties"]["beskrivels"].ToString();
                opsætning.Lang_beskr = item["properties"]["lang_beskr"].ToString();
                opsætning.Antal_pl = item["properties"]["antal_pl"].ToInt32();

                Shelter shelter = new Shelter();

                shelter.Id = item["_id"].ToString();
                shelter.Properties = opsætning;

                shelterListe.Add(shelter);
            }
            return shelterListe;
        }

        [HttpGet("distinctkommune")]
        public async Task<IEnumerable<string>> GetKommune()
        {
            // Connecter til vores database og collection:
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<BsonDocument>(SheltersCollection);

            var list = await collection.Find(_ => true).ToListAsync();

            List<string> kommuner = new List<string>();

            foreach (var item in list)
            {
                if (!kommuner.Contains(item["properties"]["cvr_navn"].ToString()))
                {
                    kommuner.Add(item["properties"]["cvr_navn"].ToString());
                }
            }

            return kommuner;
        }


        // Logik at hente sheltere basseret på kommune
        [HttpGet("kommune")]
        public async Task<IEnumerable<Shelter>> GetKommuneSheltere(string kommunenavn)
        {
            // Connecter til vores database og collection:
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<BsonDocument>(SheltersCollection);

            var list = await collection.Find(_ => true).ToListAsync();

            List<Shelter> kommuneShelters = new List<Shelter>();

            foreach (var item in list)
            {
                if (item["properties"]["cvr_navn"].ToString() == kommunenavn)
                {
                    Properties opsætning = new Properties();

                    opsætning.Cvr_navn = item["properties"]["cvr_navn"].ToString();
                    opsætning.Kommunekode = item["properties"]["kommunekode"].ToInt32();
                    opsætning.Facil_ty = item["properties"]["facil_ty"].ToString();
                    opsætning.Navn = item["properties"]["navn"].ToString();
                    opsætning.Beskrivels = item["properties"]["beskrivels"].ToString();
                    opsætning.Lang_beskr = item["properties"]["lang_beskr"].ToString();
                    opsætning.Antal_pl = item["properties"]["antal_pl"].ToInt32();

                    Shelter shelter = new Shelter();

                    shelter.Id = item["_id"].ToString();
                    shelter.Properties = opsætning;

                    kommuneShelters.Add(shelter);
                }

            }
            return kommuneShelters;
        }

        // Logik at hente shelterid og navn basseret på Id
        [HttpGet("idnavn")]
        public async Task<Shelter> GetShelterIdNavn(string shelterId)
        {
            // Connecter til vores database og collection:
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<BsonDocument>(SheltersCollection);

            var list = await collection.Find(_ => true).ToListAsync();

            foreach (var item in list)
            {
                if (item["_id"].ToString() == shelterId)
                {
                    Properties opsætning = new Properties();

                    opsætning.Cvr_navn = item["properties"]["cvr_navn"].ToString();
                    opsætning.Kommunekode = item["properties"]["kommunekode"].ToInt32();
                    opsætning.Facil_ty = item["properties"]["facil_ty"].ToString();
                    opsætning.Navn = item["properties"]["navn"].ToString();
                    opsætning.Beskrivels = item["properties"]["beskrivels"].ToString();
                    opsætning.Lang_beskr = item["properties"]["lang_beskr"].ToString();
                    opsætning.Antal_pl = item["properties"]["antal_pl"].ToInt32();

                    Shelter shelter = new Shelter();

                    shelter.Id = item["_id"].ToString();
                    shelter.Properties = opsætning;

                    return shelter;
                }
            }

            return null;
        }

        // Logik til at opdatere booking
        [HttpPost("opdater")]
        public async Task OpdaterShelter(Shelter shelter)
        {
            // Connecter til vores database og collection:
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<BsonDocument>(SheltersCollection);

            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", shelter.Id);

            await collection.ReplaceOneAsync(deleteFilter, shelter.ToBsonDocument());

        }
    }
}
