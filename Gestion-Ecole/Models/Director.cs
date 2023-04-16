using Gestion_Ecole.Models.data;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Ecole.Models
{
    public class Director
    {
        [Key]
        public int idDirector { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Roles roles { get; set; }
    }
}
