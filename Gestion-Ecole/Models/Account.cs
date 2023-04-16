using System.ComponentModel;

namespace Gestion_Ecole.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public data.Roles roles { get; set; }

    }
}
