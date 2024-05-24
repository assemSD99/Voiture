using System.ComponentModel.DataAnnotations.Schema;

namespace VoitureWeb.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public int NbrPortes { get; set; }
        public int NbrPlaces { get; set; }
        public string Photo { get; set; }
        public string Couleur { get; set; }
        public int MarqueId { get; set; }
        [ForeignKey("MarqueId")]
        public Marque Marque { get; set; }
        public List<Assurance> Assurances { get; set; }
        public List<Location> Locations { get; set; }



    }
}
