using Microsoft.AspNetCore.Mvc;
using FolhaPagamento.Models;
using System.Collections.Generic;
using System.Linq;


namespace FolhaPagamento.Controllers
{
    
     [ApiController]
     [Route("api/funcionario")]

   public class FuncionarioController : ControllerBase
    {


    private static List<Funcionario> funcionarios = new List<Funcionario>();

    // GET: /api/funcionario/listar
    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar() => Ok(funcionarios);

    // GET: /api/funcionario/cadastrar
    [HttpPost]
    [Route("cadastrar")]
   public IActionResult Cadastrar([FromBody] Funcionario funcionario)
   {
     
     funcionarios.Add(funcionario);
     return Created("",funcionario);

   }

    // GET: /api/funcionario/buscar
    [HttpGet]
    [Route("buscar/{cpf}")]
    public IActionResult Buscar([FromRoute] string cpf)
    {

        // Percorrer toda a lista da mesma maneira que o for abaixo porém 
            // sem retornar o index de cada funcionario

            // foreach(Funcionario funcionarioCadastrado in funcionarios){
            //     if(funcionarioCadastrado.Cpf.Equals(cpf)){
            //         return Ok(funcionarioCadastrado);
            //     }
            // }


            // for (int i = 0; i < funcionarios.Count; i++)
            // {
            //     if(funcionarios[i].Cpf.Equals(cpf)){
            //         return Ok(funcionarios[i]);
            //     }
            // }
      
      Funcionario funcionario = funcionarios.FirstOrDefault(
      funcionarioCadastrado => funcionarioCadastrado.Cpf.Equals(cpf)
      );
         
        // Expressão lambda
     return funcionario != null ? Ok(funcionario) : NotFound();

     // return funcionario != null ? Ok(funcionario) : NotFound();
            // if(funcionario != null){
            //    return Ok(funcionario);
            // }
            // return NotFound();

     
    } 

    // DELETE: /api/funcionario/deletar/123
    [Route("deletar/{cpf}")]
    [HttpDelete]
    public IActionResult Deletar([FromRoute] string cpf){
        
        Funcionario funcionario = funcionarios.FirstOrDefault(
            f => f.Cpf.Equals(cpf)
        );
        if(funcionario != null){
            funcionarios.Remove(funcionario);
            return Ok(funcionario);
        }
        return NotFound();
        
        
        }
    
    }

}
