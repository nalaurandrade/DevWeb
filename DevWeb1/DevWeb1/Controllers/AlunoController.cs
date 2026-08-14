using DevWeb1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevWeb1.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
        //sintaxe de uma função é a visibilidade da função
        // visibilidade da função: public, private, protected
        //pritvate so a classe acessar
        //Tipo de retorno
        //nome da funça
        //parâmetros
        [HttpGet]

        public IActionResult Saudacao()
        {
            return Ok("Oi H1");
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            //imagine que vou no gravar banco de dados
            return Ok("Cadastrado com sucesso");
        }
        
    }

}
