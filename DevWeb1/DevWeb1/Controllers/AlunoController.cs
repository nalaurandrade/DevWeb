using DevWeb1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevWeb1.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {

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
