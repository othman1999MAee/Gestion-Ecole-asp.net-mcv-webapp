using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_Ecole.Models
{
    public class Mark
    {
        [Key]
        public int Idmark { get; set; } 
        public double mark{ get; set; }

        public int idSubject { get; set; }
        [ForeignKey("idSubject")]
        public Subject Subject { get; set; }

        public int idStudent { get; set; }
        [ForeignKey("idStudent")]
        public Student Student { get; set;}


    }
}
