using System;
namespace shelterJADA.Shared
{
    public class Booking
    {
        public string Id { get; set; }
        public Udlejet_Shelter Udlejet_Shelter { get; set; }
        public Bruger Bruger { get; set; }
        public DateTime Start_Dato { get; set; }
        public DateTime Slut_Dato { get; set; }
    }

    public class Udlejet_Shelter
    {
        public string Shelter_Navn { get; set; }
        public string Shelter_Id { get; set; }
    }

    public class Bruger
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }

}
