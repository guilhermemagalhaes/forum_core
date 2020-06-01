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

        public void AddOrUpdate(Comentario comentario)
        {
            _forumContext.Add(comentario);
            _forumContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ret = _forumContext.Comentario.Find(id);
            _forumContext.Remove(ret);
            _forumContext.SaveChanges();
        }

        public IList<Comentario> Get(int idPost)
        {
            return _forumContext.Comentario
                .Where(x => x.PostId == idPost)
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
