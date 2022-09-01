using Microsoft.AspNetCore.Mvc;
using FolhaPagamento.Models;
using System.Collections.Generic;

namespace FolhaPagamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        //using System.Linq;
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        //GET: /FolhaPagamento/funcionario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(funcionarios);
        }

        //Post: /FolhaPagamento/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]

        public IActionResult Cadastrar(
            [FromBody] Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            return Created("", funcionario);
        }

        //GET: /FolhaPagamento/usuario/buscar/{name}
        [HttpGet]
        [Route("buscar/{name}")]
        public IActionResult Buscar([FromRoute] string name)
        {
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if(funcionarios[i].Name.Equals(name)){
                    return Ok(funcionarios[i]);
                }
            }
            return NotFound();
        }

        [HttpPut]
        [Route("alterar/{name}")]

        public async Task<ActionResult<List<Funcionario>>> Update(Funcionario request){
            var funcionario = funcionarios.Find(i => i.Name == request.Name);
            if (funcionarios == null)
                return BadRequest("Funcionario nao encontrado");

                funcionario.Name = request.Name;

                return Ok(funcionarios);
        }
        
    }
}