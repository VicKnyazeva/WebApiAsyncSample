using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiAsync.Services
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(int id);
    }
}
