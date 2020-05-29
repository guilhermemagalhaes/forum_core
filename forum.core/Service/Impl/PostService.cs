using forum.core.Models;
using forum.core.Repository.Contract;
using forum.core.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace forum.core.Service.Impl
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void Delete(Post post)
        {
            _postRepository.Delete(post);
        }

        public IList<Post> GetAll()
        {
            return _postRepository.GetAll();
        }

        public Post GetById(int postId)
        {
            return _postRepository.GetById(postId);
        }

        public int InsertOrUpdate(Post post)
        {
            return _postRepository.InsertOrUpdate(post);
        }
    }
}
