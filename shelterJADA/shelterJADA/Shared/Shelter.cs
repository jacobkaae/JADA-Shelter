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
}