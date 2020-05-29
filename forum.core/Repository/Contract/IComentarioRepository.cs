using forum.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core.Repository.Contract
{
    public interface IComentarioRepository
    {
        void AddOrUpdate(Comentario comentario);

        void Delete(int id);

        IList<Comentario> Get(int idPost);
    }
}
