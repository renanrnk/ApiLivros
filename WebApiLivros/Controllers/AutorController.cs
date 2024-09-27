using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiLivros.Models;
using WebApiLivros.Services.Autor;

namespace WebApiLivros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _AutorInterface;
        public AutorController(IAutorInterface autorInterface)
        {
            _AutorInterface = autorInterface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _AutorInterface.ListarAutores();
            return Ok(autores);
        }
        [HttpGet("BuscarAutorPorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int idAutor)
        {
            var autor = await _AutorInterface.BuscarAutorPorId(idAutor);
            return Ok(autor);
        }
    }
}
