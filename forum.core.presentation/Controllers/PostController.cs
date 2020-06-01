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
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public int InsertOrUpdate(Post post)
        {
            return _postService.InsertOrUpdate(post);
        }

        [HttpDelete]
        public void Delete(int postId)
        {
            _postService.Delete(postId);
        }


        [HttpGet("{postId}")]
        public Post GetById(int postId)
        {
            return _postService.GetById(postId);
        }

        [HttpGet]
        public IList<Post> GetAll()
        {
            return _postService.GetAll();
        }
    }
}
