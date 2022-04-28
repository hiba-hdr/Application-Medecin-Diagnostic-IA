using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_InterfaceWeb.Models
{
    [Table("NewAccount")]
    public class NewAccount
    {
        //commentaire
        public NewAccount()
        {
            AccountRoles = new HashSet<AccountRole>();
        }
        //commentaire



        public int NewAccountID { get; set; }  

        [Required(ErrorMessage = "Champs requis : Nom !")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "Champs requis : Prénom !")]
        public string? Prenom { get; set; }

        public bool? Enable { get; set; }





        public string? HommeCheck { get; set; } 

       
        public string? FemmeCheck { get; set; }

        public string? DateNaissance { get; set; }

        [Required(ErrorMessage = "Champs requis : Mail !")]
        public string? Ville { get; set; }  

        [Required(ErrorMessage = "Champs requis : Date d'entrée!")]
        public string? DateEntree { get; set; }

        [Required(ErrorMessage = "Champs requis : Mail !")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Champs requis : Nom d'utilisateur !")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Champs requis : Mot de passe !")]
        public string? Password { get; set; }

        //commentaire
        public ICollection<AccountRole> AccountRoles { get; set; }
        //commentaire



    }
}
