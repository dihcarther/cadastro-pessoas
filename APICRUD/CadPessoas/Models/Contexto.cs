using Microsoft.EntityFrameworkCore;
using CadPessoas.Models;

namespace CadPessoas.Models
{
    public class Contexto: DbContext
    {

        public Contexto(DbContextOptions<Contexto> options):base(options) 
        
        
        {
             
             
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Endereco> Endereco { get; set; }



    }
}
