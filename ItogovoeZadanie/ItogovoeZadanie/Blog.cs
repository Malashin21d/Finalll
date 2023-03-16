using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Blog
    {
        public User User { get; set; }
        public List<Post> Posts { get; set; }
        public int ViewCount { get; set; }
    }
}