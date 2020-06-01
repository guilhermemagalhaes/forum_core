using forum.core.Models;
using forum.core.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forum.core.Repository.Impl
{
    public class ComentarioRepository : IComentarioRepository
    {

        private readonly ForumContext _forumContext;

        public ComentarioRepository(ForumContext context)
        {
            _forumContext = context;
        }

        public int InsertOrUpdate(Comentario comentario)
        {
            var _comentario = _forumContext.Comentario.FirstOrDefault(x => x.ComentarioId == comentario.ComentarioId);

            if (_comentario == null)
                _comentario = new Comentario();


            _comentario.Autor = comentario.Autor;
            _comentario.Texto = comentario.Texto;
            _comentario.PostId = comentario.PostId;
            _comentario.DataCadastro = comentario.DataCadastro;
            
            _forumContext.Add(_comentario);
            _forumContext.SaveChanges();

            return _comentario.ComentarioId;
        }

        public void Delete(int id)
        {
            var ret = _forumContext.Comentario.Find(id);
            _forumContext.Remove(ret);
            _forumContext.SaveChanges();
        }

        public IList<Comentario> Get(int postId)
        {
            return _forumContext.Comentario
                .Where(x => x.PostId == postId)
                .Select(x => new Comentario()
                {
                    ComentarioId = x.ComentarioId,
                    Autor = x.Autor,
                    DataCadastro = x.DataCadastro,
                    Texto = x.Texto,
                    Post = x.Post
                })
                .ToList();
        }
    }
}
