

using Blog.Core.Domain;
using Blog.Core.Repositories;

namespace Blog.Persistence.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(BlogContext context)
            : base(context)
        {
        }



    }
}