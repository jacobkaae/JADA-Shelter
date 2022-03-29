using System;
using System.Security.Cryptography;
using MongoDB.Bson;

namespace shelterJADA.Shared
{
    public class Shelter
    {
        public _id _id { get; set; }

        public Properties Properties { get; set; }

    }

    public class Properties
    {
        public string cvr_navn { get; set; }
        public int kommunekode { get; set; }
        public string facil_ty { get; set; }
        public string navn { get; set; }
        public string beskrivels { get; set; }
        public string lang_beskr { get; set; }
        public int antal_pl { get; set; }
    }

    public class _id
    {
        public string Oid { get; set; }
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

