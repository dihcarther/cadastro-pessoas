using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadPessoas.Models
{

        [Table("Endereco")]
    public class Endereco
    {
     
  
            [Key]
            [Display(Name = "Id")]
            [Column("Id")]
            public int Id { get; set; }


            [Display(Name = "IdRef")]
            [Column("IdRef")]
            public int UsuarioId { get; set; }


            [Display(Name = "Longradouro")]
            [Column("Longradouro")]
            public string Longradouro { get; set; }

        }
    }

