using Final;
var userRepository = new UserRepository();
var postRepository = new PostRepository();
var blogRepository = new BlogRepository();
var user1 = new User { Id = 1, Name = "Andrey" };
var user2 = new User { Id = 2, Name = "Jora" };
await userRepository.Add(user1);
await userRepository.Add(user2);
var post1 = new Post { Id = 1, UserId = 1, Content = "Смешно от Andrey" };
var post2 = new Post { Id = 2, UserId = 1, Content = "Хотя нет от Andrey" };
var post3 = new Post { Id = 3, UserId = 2, Content = "Я на пляже от Jora" };
var post4 = new Post { Id = 4, UserId = 2, Content = "Вода от Jora" };
await postRepository.Add(post1);
await postRepository.Add(post2);
await postRepository.Add(post3);
await postRepository.Add(post4);
var blog1 = new Blog { User = user1, Posts = new List<Post> { post1, post2 } };
var blog2 = new Blog { User = user2, Posts = new List<Post> { post3, post4 } };
await blogRepository.Add(blog1);
await blogRepository.Add(blog2);
var blogs = await blogRepository.GetAll();
foreach (var blog in blogs)
{
    Console.WriteLine($"Blog by {blog.User.Name} with {blog.ViewCount} views:");
    foreach (var post in blog.Posts)
    {
        Console.WriteLine($" - {post.Content}");
    }
    Console.WriteLine();
}


