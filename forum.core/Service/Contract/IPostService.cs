using forum.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core.Service.Contract
{
    public interface IPostService
    {
        int InsertOrUpdate(Post post);

        void Delete(int postId);

        Post GetById(int postId);

        IList<Post> GetAll();
    }
}
