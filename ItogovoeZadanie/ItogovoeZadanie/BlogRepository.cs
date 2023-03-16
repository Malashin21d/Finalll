using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class BlogRepository : IRepository<Blog>
    {
        private List<Blog> _blogs;

        public BlogRepository()
        {
            _blogs = new List<Blog>();
        }

        public async Task<Blog> GetById(int id)
        {
            return await Task.FromResult(_blogs.Find(b => b.User.Id == id));
        }

        public async Task<List<Blog>> GetAll()
        {
            return await Task.FromResult(_blogs);
        }

        public async Task Add(Blog blog)
        {
            _blogs.Add(blog);
            await Task.CompletedTask;
        }

        public async Task Delete(Blog blog)
        {
            _blogs.Remove(blog);
            await Task.CompletedTask;
        }
    }
}
