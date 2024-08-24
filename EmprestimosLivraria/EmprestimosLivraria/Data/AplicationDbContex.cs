using EmprestimosLivraria.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimosLivraria.Data
{
    public class AplicationDbContex : DbContext
    {
        public AplicationDbContex(DbContextOptions<AplicationDbContex> options) : base(options) 
        { 
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    }
}
