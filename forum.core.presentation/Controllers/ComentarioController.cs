using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forum.core.Models;
using forum.core.Service.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace forum.core.presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioService _comentarioService;

        public ComentarioController(IComentarioService comentarioService)
        {
            _comentarioService = comentarioService;
        }

        [HttpGet]
        public IList<Comentario> Get(int idPost)
        {
            return _comentarioService.Get(idPost);
        }

        [HttpPost]
        public int Post(Comentario comentario)
        {
            return _comentarioService.InsertOrUpdate(comentario);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _comentarioService.Delete(id);
        }
    }
}