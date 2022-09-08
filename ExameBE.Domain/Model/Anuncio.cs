using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExameBE.Domain.Model
{
    [Table("Ads")]
    public class Anuncio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Assunto deve ser mencionado.")]
        [Column(TypeName = "NVARCHAR(100)")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Descrição deve ser mencionada.")]
        [Column(TypeName = "NVARCHAR(400)")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O contacto deve ser mencionado.")]
        [Column(TypeName = "NVARCHAR(50)")]
        public string Contact { get; set; }

        [Required]
        public AdTypes AdType { get; set; }

        public enum AdTypes{
            Imóvel,
            Automóvel,
            Emprego
        }
    }
}
