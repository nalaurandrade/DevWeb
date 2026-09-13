using Microsoft.AspNetCore.Mvc;
using Questao5.Models;
using System.Collections.Generic;
using System.Linq;

namespace Questao5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        [Route("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            return Ok(produtos);
        }

        [HttpGet]
        [Route("ObterPorCodigo/{codigo}")]
        public IActionResult ObterPorCodigo(string codigo)
        {
            var produto = produtos.FirstOrDefault(p => p.CodigoProduto == codigo);

            if (produto == null)
            {
                return NotFound("Produto não encontrado");
            }

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existe = produtos.Any(p => p.CodigoProduto == produto.CodigoProduto);
            if (existe)
            {
                return BadRequest("Já existe um produto cadastrado com este código");
            }

            produtos.Add(produto);
            return Ok("Produto cadastrado com sucesso");
        }

        [HttpPut]
        public IActionResult Atualizar(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resultado = produtos.FirstOrDefault(p => p.CodigoProduto == produto.CodigoProduto);
            if (resultado is null)
            {
                return NotFound("Produto informado não existe");
            }

            produtos.Remove(resultado);
            produtos.Add(produto);

            return Ok("Produto atualizado com sucesso");
        }

        [HttpDelete("{codigo}")]
        public IActionResult Remover(string codigo)
        {
            var resultado = produtos.FirstOrDefault(p => p.CodigoProduto == codigo);
            if (resultado is null)
            {
                return NotFound("Produto informado não existe");
            }

            produtos.Remove(resultado);
            return Ok("Produto removido com sucesso");
        }
    }
}
