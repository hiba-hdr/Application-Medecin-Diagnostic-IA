using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_InterfaceWeb.Models
{
    [Table("AjoutPatient")]
    public class AjoutPatient
    {
        public int AjoutPatientId { get; set; }

      
        public string? UserName { get; set; }

       
        public string? Nom { get; set; }

       
        public string? Prenom { get; set; }

        public string? DateNaissance { get; set; }

        
        public string? HommeCheck { get; set; }

      
        public string? FemmeCheck { get; set; }

        public string? Ville { get; set; }

       
        public string? DernierDiagnostic { get; set; }




    }
}



