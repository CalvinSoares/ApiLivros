using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi8.Dto.Autor;
using webApi8.Models;
using webApi8.Services.Autor;
using webApi8.Services.Livro;

namespace webApi8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroInterface _livroInterface;
        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ListarLivros()
        {
            var livros = await _livroInterface.ListarLivros();
            return Ok(livros);
        }

        [HttpGet("BuscarLivroPorId/{idLivro}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorId(int idLivro)
        {
            var livro = await _livroInterface.BuscarLivroPorId(idLivro);
            return Ok(livro);
        }

        [HttpGet("BuscarLivroPorIdAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorIdAutor(int idAutor)
        {
            var livro = await _livroInterface.BuscarLivroPorId(idAutor);
            return Ok(livro);
        }

        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livro = await _livroInterface.CriarLivro(livroCriacaoDto);
            return Ok(livro);
        }

        [HttpDelete("ExcluirLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ExcluirLivro(int idAutor)
        {
            var livros = await _livroInterface.ExcluirLivro(idAutor);
            return Ok(livros);
        }

        [HttpPut("EditarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(LivroEdcaoDto livroEdcaoDto)
        {
            var livros = await _livroInterface.EditarLivro(livroEdcaoDto);
            return Ok(livros);
        }
    }
}
