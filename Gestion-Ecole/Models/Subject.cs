using Gestion_Ecole.Models.data;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Ecole.Models
{
    public class Subject
    {
        [Key]
        public int idSubject { get; set; }
        public SubjectEnum subjectName { get; set; }
        public List<Teacher> teachers { get; set; }
    }
}
