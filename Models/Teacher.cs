using System.ComponentModel.DataAnnotations;

namespace Authentification.Models
{
    public class Teacher
    {

        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }


        public string Prenom { get; set; }


    }
}
