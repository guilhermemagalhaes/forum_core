﻿using forum.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core.Repository.Contract
{
    public interface IPostRepository
    {
        int InsertOrUpdate(Post post);

        void Delete(int postId);

        Post GetById(int postId);

        IList<Post> GetAll();
    }
}
