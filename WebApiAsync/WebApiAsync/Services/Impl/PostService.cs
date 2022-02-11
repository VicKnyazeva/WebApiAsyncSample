using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAsync.Services.Impl
{
    class PostService : IPostService
    {
        private static readonly Post[] _posts =
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

        public PostService() { }

        public Task<IEnumerable<Post>> GetAllAsync()
        {
            return Task.FromResult(_posts as IEnumerable<Post>);
        }

        public Task<Post> GetByIdAsync(int id)
        {
            return Task.FromResult(_posts.FirstOrDefault(p => p.Id == id));
        }
    }
}
