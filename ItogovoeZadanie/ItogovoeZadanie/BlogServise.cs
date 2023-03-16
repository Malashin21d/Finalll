using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class BlogService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Post> _postRepository;
        private readonly IRepository<Blog> _blogRepository;

        public BlogService(IRepository<User> userRepository, IRepository<Post> postRepository, IRepository<Blog> blogRepository)
        {
            _userRepository = userRepository;
            _postRepository = postRepository;
            _blogRepository = blogRepository;
        }

        public async Task AddBlog(Blog blog)
        {
            if (blog.User != null && await _userRepository.GetById(blog.User.Id) != null)
            {
                await _blogRepository.Add(blog);
            }
            else
            {
                throw new ArgumentException("User does not exist");
            }
        }

        public async Task<List<Post>> GetPostsByUserIdAsync(int userId)
        {
            var posts = await _postRepository.GetAll();
            return posts.FindAll(p => p.UserId == userId);
        }

        public async Task<List<Blog>> GetAllBlogsAsync()
        {
            return await _blogRepository.GetAll();
        }
    }
}

