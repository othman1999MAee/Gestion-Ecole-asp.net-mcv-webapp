using System.ComponentModel.DataAnnotations;

namespace Gestion_Ecole.Models
{
    public class Groupe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        //teachers
        public List<Teacher_Group> Groupes_teachers { get; set; }

    }
}
