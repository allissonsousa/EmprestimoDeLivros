using EmprestimosLivraria.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimosLivraria.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options) 
        { 
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    }
}
