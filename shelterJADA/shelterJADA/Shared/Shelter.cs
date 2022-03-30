using System;
using System.Security.Cryptography;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelterJADA.Shared
{

    // Laver en class for en "Shelter"
    public class Shelter
    {
        public string Id { get; set; }

        public Properties Properties { get; set; }

    }

    public class Properties
    {
        public string Cvr_navn { get; set; }
        public int Kommunekode { get; set; }
        public string Facil_ty { get; set; }
        public string Navn { get; set; }
        public string Beskrivels { get; set; }
        public string Lang_beskr { get; set; }
        public int Antal_pl { get; set; }
    }

   

    //// Laver constructor
    //public Shelter2(ObjectId ID, int KommuneKode, string KommuneNavn, string ShelterNavn, int AntalPladser, string KortBeskrivelse, string LangBeskrivelse)
    //{
    //    this.ID = ID;
    //    this.KommuneKode = KommuneKode;
    //    this.KommuneNavn = KommuneNavn;
    //    this.ShelterNavn = ShelterNavn;
    //    this.AntalPladser = AntalPladser;
    //    this.KortBeskrivelse = KortBeskrivelse;
    //    this.LangBeskrivelse = LangBeskrivelse;
    //}

    //// Laver tom constructor
    //public Shelter()
    //{
    //}


}

