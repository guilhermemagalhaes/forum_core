using forum.core.Models;
using forum.core.Repository.Contract;
using forum.core.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core.Service.Impl
{
    public class ComentarioService : IComentarioService
    {

        private readonly IComentarioRepository _comentarioRepository;

        public ComentarioService(IComentarioRepository comentarioRepository)
        {
            _comentarioRepository = comentarioRepository;
        }

        public int InsertOrUpdate(Comentario comentario)
        {
            return _comentarioRepository.InsertOrUpdate(comentario);
        }

        public void Delete(int id)
        {
            _comentarioRepository.Delete(id);
        }

        public IList<Comentario> Get(int idPost)
        {
            return _comentarioRepository.Get(idPost);
        }
    }
}
