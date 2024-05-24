namespace VoitureWeb.Models
{
    public class Location
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public bool Retour { get; set; }
        public int PrixJour { get; set; }
        public Voiture Voiture { get; set; }
        public int VoitureId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}