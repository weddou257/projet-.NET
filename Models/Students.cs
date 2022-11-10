using System.ComponentModel.DataAnnotations;
namespace Authentification.Models
{
    public class Students
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        public string adresse { get; set; }
    }
}
