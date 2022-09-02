using Microsoft.EntityFrameWorkCore;

namespace FolhaPagamento.Models{
    
    public class DataContext : DbContext{
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }
        public DbSet <Funcionario> Funcionarios { get; set; }
    }
}