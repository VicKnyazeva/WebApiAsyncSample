using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiAsync.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private static readonly Post[] p =
        {
            new Post() { UserId = 1, Id = 1, Title = "voluptatem eligendi optio 1", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 2, Id = 2, Title = "voluptatem eligendi optio 2", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 3, Id = 3, Title = "voluptatem eligendi optio 3", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 4, Id = 4, Title = "voluptatem eligendi optio 4", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 5, Id = 5, Title = "voluptatem eligendi optio 5", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 6, Id = 6, Title = "voluptatem eligendi optio 6", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 7, Id = 7, Title = "voluptatem eligendi optio 7", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 8, Id = 8, Title = "voluptatem eligendi optio 8", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 9, Id = 9, Title = "voluptatem eligendi optio 9", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 10, Id = 10, Title = "voluptatem eligendi optio 10", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 11, Id = 11, Title = "voluptatem eligendi optio 11", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 12, Id = 12, Title = "voluptatem eligendi optio 12", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 13, Id = 13, Title = "voluptatem eligendi optio 13", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 14, Id = 14, Title = "voluptatem eligendi optio 14", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
            new Post() { UserId = 15, Id = 15, Title = "voluptatem eligendi optio 15", Body = "voluptatem eligendi optio voluptatem eligendi optio" },
        };

        //private readonly IPostService _postService;
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)//, IPostService postService)
        {
            _logger = logger;
        }

        // GET: api/<PostsController>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return p; // await _postService.GetPosts();
        }

        static Random r = new Random();

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            //if (id % 2 == 0) throw new ArgumentException("id"); для проверки Serilog
            return p.FirstOrDefault(p => p.Id == id);
        }
#if X
        // POST api/<PostsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
#endif
    }
}
