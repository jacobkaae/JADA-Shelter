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
    public class ShelterDBController : ControllerBase
    {

        private readonly ILogger<ShelterDBController> logger;

        public ShelterDBController(ILogger<ShelterDBController> logger)
        {
            this.logger = logger;
        }

        // Logik at hente sheltere basseret på kommune
        [HttpGet("all")]
        public async Task<IEnumerable<Shelter>> GetAsync()
        {

            try
            {

                var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

                var database = client.GetDatabase("Shelter");

                var collection = database.GetCollection<BsonDocument>("Shelters");

                var list = await collection.Find(_ => true).ToListAsync();

                List<Shelter> shelters = new List<Shelter>();

                foreach (var item in list)
                {
                        Shelter shelter = new Shelter();

                        Properties opsætning = new Properties();

                        opsætning.Cvr_navn = item["properties"]["cvr_navn"].ToString();
                        opsætning.Kommunekode = item["properties"]["kommunekode"].ToInt32();
                        opsætning.Facil_ty = item["properties"]["facil_ty"].ToString();
                        opsætning.Navn = item["properties"]["navn"].ToString();
                        opsætning.Beskrivels = item["properties"]["beskrivels"].ToString();
                        opsætning.Lang_beskr = item["properties"]["lang_beskr"].ToString();
                        opsætning.Antal_pl = item["properties"]["antal_pl"].ToInt32();

                        shelter.Id = item["_id"].ToString();
                        shelter.Properties = opsætning;

                    shelters.Add(shelter);
                }
                return shelters;
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

        [HttpGet("distinctkommune")]
        public async Task<IEnumerable<string>> GetKommune()
        {
            try
            {                               
                var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

                var database = client.GetDatabase("Shelter");

                var collection = database.GetCollection<BsonDocument>("Shelters");

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


        // Logik at hente sheltere basseret på kommune
        [HttpGet("kommune")]
        public async Task<IEnumerable<Shelter>> GetKommuneSheltere(string kommunenavn)
        {

            try
            {
        
                var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

                var database = client.GetDatabase("Shelter");

                var collection = database.GetCollection<BsonDocument>("Shelters");

                var list  = await collection.Find(_ => true).ToListAsync();

                List<Shelter> kommuneShelters = new List<Shelter>();

                foreach (var item in list)
                {
                    if (item["properties"]["cvr_navn"].ToString() == kommunenavn)
                    {
                        Shelter shelter = new Shelter();

                        Properties opsætning = new Properties();

                        opsætning.Cvr_navn = item["properties"]["cvr_navn"].ToString();
                        opsætning.Kommunekode = item["properties"]["kommunekode"].ToInt32();
                        opsætning.Facil_ty = item["properties"]["facil_ty"].ToString();
                        opsætning.Navn = item["properties"]["navn"].ToString();
                        opsætning.Beskrivels = item["properties"]["beskrivels"].ToString();
                        opsætning.Lang_beskr = item["properties"]["lang_beskr"].ToString();
                        opsætning.Antal_pl = item["properties"]["antal_pl"].ToInt32();

                        shelter.Id = item["_id"].ToString();
                        shelter.Properties = opsætning;

                        kommuneShelters.Add(shelter);
                    }
                   
                }
                return kommuneShelters;
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


        // Logik at hente shelterid og navn basseret på Id
        [HttpGet("idnavn")]
        public async Task<Shelter> GetShelterIdNavn(string shelterId)
        {
            try
            {
                var client = new MongoClient("mongodb+srv://admin:cLQhpvD7G3wzvegG@cluster0.gyuyl.mongodb.net/Shelter?retryWrites=true&w=majority");

                var database = client.GetDatabase("Shelter");
                
                var collection = database.GetCollection<BsonDocument>("Shelters");

                var list = await collection.Find(_ => true).ToListAsync();

                foreach (var item in list)
                {
                    if (item["_id"].ToString() == shelterId)
                    {
                        Shelter shelter = new Shelter();

                        Properties opsætning = new Properties();

                        opsætning.Cvr_navn = item["properties"]["cvr_navn"].ToString();
                        opsætning.Kommunekode = item["properties"]["kommunekode"].ToInt32();
                        opsætning.Facil_ty = item["properties"]["facil_ty"].ToString();
                        opsætning.Navn = item["properties"]["navn"].ToString();
                        opsætning.Beskrivels = item["properties"]["beskrivels"].ToString();
                        opsætning.Lang_beskr = item["properties"]["lang_beskr"].ToString();
                        opsætning.Antal_pl = item["properties"]["antal_pl"].ToInt32();

                        shelter.Id = item["_id"].ToString();
                        shelter.Properties = opsætning;

                        return shelter;

                    }



                }
                
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
