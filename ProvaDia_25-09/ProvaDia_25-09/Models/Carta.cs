using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace ProvaDia_25_09.Models
{
    public class Carta
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "A criança deve ter no mínimo 15 anos.")]
        [Range(3, 255, ErrorMessage = "Mínimo de 3 caracteres e máximo de 255 caracteres")]
        public string NomeCrianca { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(1, ErrorMessage = "A criança deve ter menos de 15 anos.")]
        public int IdadeCriança { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(500, ErrorMessage ="Essa carta deve ter no máximo 500 caracteres")]
        public string TextoCarta { get; set; }
    }
}
