using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Ecole.Models
{
    public class Administrator
    {
        [Key]
        public int idAdministrator { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public data.Roles roles { get; set; }
    }
}
