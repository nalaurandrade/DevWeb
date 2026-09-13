using DevWeb1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DevWeb1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> alunos = new List<Aluno>();

        #region Métodos GET

        [HttpGet]
        [Route("Saudacao")]
        public IActionResult Saudacao(string nome)
        {
            return Ok("Oi " + nome);
        }

        [HttpGet]
        [Route("OutraSaudacao")]
        public IActionResult OutraSaudacao(string nome)
        {
            return Ok("Fala comigooo " + nome);
        }

        [HttpGet]
        [Route("ListarAlunos")]
        public IActionResult ListarAlunos()
        {
            return Ok(alunos);
        }

        [HttpGet]
        [Route("obterPorRa")]
        public IActionResult obterporRa(string ra)
        {
            var resultado = alunos.FirstOrDefault(a => a.RA == ra);
            if (resultado == null)
            {
                return NotFound("Aluno não encontrado");
            }
            return Ok(resultado);
        }

        #endregion

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resultado = alunos.FirstOrDefault(a => a.RA == aluno.RA);

            if (resultado is null)
            {
                alunos.Add(aluno);
                return Ok("Cadastrado com sucesso");
            }
            return BadRequest("RA já cadastrado");
        }

        [HttpPut]
        [Route("Atualizar")]
        public IActionResult Atualizar(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resultado = alunos.FirstOrDefault(a => a.RA == aluno.RA);

            if (resultado is null)
            {
                return NotFound("Ra informado não existe");
            }

            alunos.Remove(resultado);
            alunos.Add(aluno);

            return Ok("Dados updated com sucesso");
        }

        [HttpDelete]
        [Route("Remover/{ra}")]
        public IActionResult Remover(string ra)
        {
            var resultado = alunos.FirstOrDefault(a => a.RA == ra);

            if (resultado is null)
            {
                return NotFound("Ra informado não existe");
            }

            alunos.Remove(resultado);
            return Ok("Aluno removido com sucesso");
        }
    }
}
