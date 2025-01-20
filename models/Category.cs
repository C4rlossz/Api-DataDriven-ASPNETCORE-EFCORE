using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{

    public class Category
    {
        [Key]

        public int Id { get; set; }

        [Required (ErrorMessage = "Este campo e obrigatorio")]
        [MaxLength(60, ErrorMessage =60, "Este campo deve conter entre 3 a 60 caracteres")]
        [MinLength(60, ErrorMessage =3, "Este campo deve conter entre 3 a 60 caracteres")]

        public string Title { get; set; }
    }
}