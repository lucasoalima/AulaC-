using System;

namespace FolhaPagamento.Models
{
    public class Funcionario
    {
        public Funcionario() => CriadoEm = DateTime.Now;
        
        public string Nome {get; set;}

        public string Cpf {get; set;}

        public DateTime Nascimento {get; set;}

        public DateTime CriadoEm {get; set;}

    }
}