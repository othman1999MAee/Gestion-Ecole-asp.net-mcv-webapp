namespace Gestion_Ecole.Models
{
    public class Teacher_Group
    {
        public int IdTeacher { get; set; }
        public Teacher teacher { get; set; }

        public int IdGroupe { get; set; }
        public Groupe Groupe { get; set; }
    }
}
