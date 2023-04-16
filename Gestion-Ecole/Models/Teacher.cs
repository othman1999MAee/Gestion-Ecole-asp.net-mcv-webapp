using Gestion_Ecole.Models.data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_Ecole.Models
{
    public class Teacher
    {
        [Key]
        public int idTeacher { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
 
        //subject
        public int IdSubject { get; set; }
        [ForeignKey("IdSubject")]
        public Subject Subject { get; set; }

        //groupes
        public List<Teacher_Group> Groupes_teachers { get; set;}
    }
}
