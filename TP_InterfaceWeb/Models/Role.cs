using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_InterfaceWeb.Models
{
    [Table("Role")]
    public class Role
    {
        
        public Role()
        {
            AccountRoles = new HashSet<AccountRole>();
        }

        [Key]
        public int NewAccountID { get; set; }
        public string Name { get; set; }


        public ICollection<AccountRole> AccountRoles { get; set; }
    }  
}
