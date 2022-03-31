using System;
using MongoDB.Bson.Serialization.Attributes;

namespace shelterJADA.Shared
{
    public class Booking
    {
       [BsonId]
        public string Id { get; set; }
        public Udlejet_Shelter udlejet_shelter { get; set; }
        public Bruger bruger { get; set; }
        public DateTime start_dato { get; set; }
        public DateTime slut_dato { get; set; }
    }

    public class Udlejet_Shelter
    {
        public string shelter_navn { get; set; }
        public string shelter_id { get; set; }
    }

    public class Bruger
    {
        public string fornavn { get; set; }
        public string efternavn { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
    }

}
