using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace wall.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostService _postservice;
        public PostController(IPostService postservice)
        {
            _postservice = postservice;
        }

        [HttpGet]
        public List<post> Get()
        {
            return _postservice.GetAllPosts();
        }
        [HttpGet("{id}")]
        public post Get(int id)
        {
            return _postservice.GetPostById(id);
        }

        [HttpPost]
        public post Post([FromBody] post post)
        {
            return _postservice.CreatePost(post);
        }
        [HttpPut]
        public post Put([FromBody] post post)
        {
            return _postservice.UpdatePost(post);
        }
    }
}
