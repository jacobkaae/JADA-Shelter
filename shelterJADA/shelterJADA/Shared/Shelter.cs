using System;
using MongoDB.Bson;

namespace shelterJADA.Shared
{
    public class Shelter
    {
        private ObjectId ID { get; set; }

        public string KommuneNavn { get; set; }
        private string ShelterNavn { get; set; }
        private string KortBeskrivelse { get; set; }
        private string LangBeskrivelse { get; set; }

        private int KommuneKode { get; set; }
        private int AntalPladser { get; set; }


   

        public Shelter(ObjectId ID, int KommuneKode, string KommuneNavn, string ShelterNavn, int AntalPladser, string KortBeskrivelse, string LangBeskrivelse)
        {
            this.ID = ID;
            this.KommuneKode = KommuneKode;
            this.KommuneNavn = KommuneNavn;
            this.ShelterNavn = ShelterNavn;
            this.AntalPladser = AntalPladser;
            this.KortBeskrivelse = KortBeskrivelse;
            this.LangBeskrivelse = LangBeskrivelse;
        }

        public Shelter()
        {
        }
        
        
    }
}
