using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taerefas.Dados
{
    [Table("Dados")]
    public class Dado
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O assunto deve ter entre 3 e 50 caracteres.")]
        public string Assunto { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "A decrição deve ter entre 5 e 200 caracteres.")]
        public string Descricao { get; set; }
        public DateTime DataAtual { get; set; }
    }
}
