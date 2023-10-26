using Microsoft.EntityFrameworkCore;
using ProductProgram.Models;

namespace ProductProgram
{
    public class ConexaoDB : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
