

using Blog.Core.Domain;
using Blog.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Blog.Persistence.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(BlogContext context) : base(context)
        {
        }



        public IEnumerable<Post> GetPostWithComment(int pageIndex, int pageSize = 10)
        {
            return BlogContext.Post
                .Include(c => c.Comments)
                .OrderBy(c => c.PublishedOn)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public BlogContext BlogContext
        {
            get { return Context as BlogContext; }
        }


    }
}