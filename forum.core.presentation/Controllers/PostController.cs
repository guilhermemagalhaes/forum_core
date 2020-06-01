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
        private readonly IPostService postService;

        [HttpPost]
        public int InsertOrUpdate(Post post)
        {
            return postService.InsertOrUpdate(post);
        }

        [HttpDelete]
        public void Delete(int postId)
        {
            postService.Delete(postId);
        }

        [HttpGet]
        public Post GetById(int postId)
        {
            return postService.GetById(postId);
        }

        [HttpGet]
        public IList<Post> GetAll()
        {
            return postService.GetAll();
        }
    }
}
