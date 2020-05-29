using forum.core.Models;
using forum.core.Repository.Contract;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forum.core.Repository.Impl
{
    public class PostRepository : IPostRepository
    {
        private readonly ForumContext _forumContext;
        public PostRepository(ForumContext forumContext)
        {
            _forumContext = forumContext;
        }

        public void Delete(Post post)
        {
            _forumContext.Posts.Remove(post);
            _forumContext.SaveChanges();
        }

        public IList<Post> GetAll()
        {
            return _forumContext.Posts.ToList();
        }

        public Post GetById(int postId)
        {
            return _forumContext.Posts.FirstOrDefault(p => p.PostId == postId);
        }

        public int InsertOrUpdate(Post post)
        {
            var po = _forumContext.Posts.FirstOrDefault(p => p.PostId == post.PostId);

            if (po == null)
                po = new Post();

            po.Assunto = post.Assunto;
            po.Autor = post.Autor;
            //po.Comentarios = post.Comentarios;
            po.DataAtualizacao = post.DataAtualizacao;
            po.DataCadastro = post.DataCadastro;
            po.FlaAtivo = post.FlaAtivo;
            po.Texto = post.Texto;

            _forumContext.Posts.Add(post);
            _forumContext.SaveChanges();

            return po.PostId;
        }
    }
}
