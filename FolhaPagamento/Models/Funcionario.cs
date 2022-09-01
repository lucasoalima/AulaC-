using System;

namespace FolhaPagamento.Models
{
    public class Funcionario
    {
        public Funcionario(){
            CriadoEm = DateTime.Now;
        }
        public string Name {get; set;}

        public DateTime CriadoEm {get; set;}

    }
}