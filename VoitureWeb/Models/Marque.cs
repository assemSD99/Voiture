using System.ComponentModel.DataAnnotations;

namespace VoitureWeb.Models
{
    public class Marque
    {
        public int Id { get; set; }
        [Display(Name = "Libelle de marque")]
        [Required(ErrorMessage = "Le champs de libelle marque est obligatoire")]
        public string Libelle { get; set; }
        public List<Voiture>? Voitures { get; set; }
    }
}