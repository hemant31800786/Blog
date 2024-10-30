

using Blog.Core;
using Blog.Core.Repositories;
using Blog.Persistence.Repositories;

namespace Blog.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
            Comment = new CommentRepository(_context);
            Post = new PostRepository(_context);

            Category = new CategoryRepository(_context);
        }

        public ICommentRepository Comment { get; private set; }
        public IPostRepository Post { get; private set; }


        public ICategoryRepository Category { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}