using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_InterfaceWeb.Models
{
    [Table("Account_Role")]
    public class AccountRole
    {
        
        public int AccountId { get; set; }
        
        public int RoleId { get; set; }
        public bool? Enable { get; set; }

        public NewAccount Account { get; set; }
        public Role Role { get; set; }

    }
}
