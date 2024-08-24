namespace EmprestimosLivraria.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        public string Recbedor { get; set; }
        public string LivroEmprestado { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
