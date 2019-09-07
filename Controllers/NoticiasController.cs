using Microsoft.AspNetCore.Mvc;
using Noticias.Data.Entities;
using Noticias.Services;

namespace Noticias.Controllers
{
  [Route("api/noticias")]
    [ApiController]
    public class NoticiasController: ControllerBase
    {
        private readonly NoticiaServices _noticiasServicio;
        public NoticiasController(NoticiaServices noticiasServicio)
        {
            _noticiasServicio = noticiasServicio;
        }

        public IActionResult Prueba()
        {
            return Ok("Funciona");
        }

        [Route("VerNoticias")]
        [HttpGet]
        public IActionResult VerNoticias()
        {
            var resultado = _noticiasServicio.VerListadoTodasLasNoticias();
            return Ok(resultado);
        }

       [Route("PorNoticiaID/{NoticiaID}")]
        [HttpGet]
        public IActionResult NoticiaPorID( int NoticiaID)
        {
            return Ok(_noticiasServicio.ObtenerPorID(NoticiaID));
        }


        [Route("Agregar")]
        [HttpPost]
        public IActionResult Agregar([FromBody] Noticia NoticiaAgregar)
        {
            if (_noticiasServicio.Agregar(NoticiaAgregar))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


         


        [Route("Editar")]
        [HttpPut]
        public IActionResult Editar([FromBody] Noticia  NoticiaEditar)
        {
            if (_noticiasServicio.Editar(NoticiaEditar))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

   

        [Route("eliminar/{noticiaID}")]
        public IActionResult Eliminar(int noticiaID)
        {
            if (_noticiasServicio.Eliminar(noticiaID))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }



        [Route("listadoAutores")]
        public IActionResult ListadoAutores()
        {
            return Ok(_noticiasServicio.ListadoDeAutores());
        }

    }
}