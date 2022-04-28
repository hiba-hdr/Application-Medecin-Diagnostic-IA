using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_InterfaceWeb.Models
{
    [Table("Diagnostic")]
    public class Diagnostic
    {
        public int DiagnosticId { get; set; }   

        [Required(ErrorMessage = "Champs requis !")]
        public string? Choice { get; set; }

        [Required(ErrorMessage = "Champs requis !")]
        public string? TypeDouleur { get; set; }

        [Required(ErrorMessage = "Champs requis !")]
        public int? Thalassemie { get; set; }

        [Required(ErrorMessage = "Champs requis !")]
        public string? DS { get; set; }

        [Required(ErrorMessage = "Champs requis !")]
        public string? NG { get; set; }

        [Required(ErrorMessage = "Champs requis !")]
        public string? Resultat { get; set; }

        
        


    }
}
