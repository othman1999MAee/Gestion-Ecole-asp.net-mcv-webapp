using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_Ecole.Models
{
    public class Student
    {
        [Key]
        public int idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public data.Roles roles { get; set; }
        public bool isAccepted { get; set; }

        // groupe
        public int idGroupe { get; set; }
        [ForeignKey("idGroupe")]
        public Groupe groupe { get; set; }
    }
}
