using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class PostRepository : IRepository<Post>
    {
        private List<Post> _posts;

        public PostRepository()
        {
            _posts = new List<Post>();
        }

        public async Task<Post> GetById(int id)
        {
            return await Task.FromResult(_posts.Find(p => p.Id == id));
        }

        public async Task<List<Post>> GetAll()
        {
            return await Task.FromResult(_posts);
        }

        public async Task Add(Post post)
        {
            _posts.Add(post);
            await Task.CompletedTask;
        }

        public async Task Delete(Post post)
        {
            _posts.Remove(post);
            await Task.CompletedTask;
        }
    }
}
