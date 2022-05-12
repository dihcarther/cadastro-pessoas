using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadPessoas.Models
{
     


        [Table("Pessoa")]
        public class Pessoa
        {

            [Display(Name = "Id")]
            [Column("Id")]
            public int Id { get; set; }


            [Display(Name = "Nome")]
            [Column("Nome")]
            public string Nome { get; set; }


            [Display(Name = "DataNasc")]
            [Column("DataNasc")]
            public string DataNasc { get; set; }


        }
}
