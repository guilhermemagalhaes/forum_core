using forum.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core.Service.Contract
{
    public interface IComentarioService
    {
        void AddOrUpdate(Comentario comentario);

        void Delete(int id);

        IList<Comentario> Get(int idPost);
    }
}
