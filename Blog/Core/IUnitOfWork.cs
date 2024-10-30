using Blog.Core.Repositories;


namespace Blog.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICommentRepository Comment { get; }
        IPostRepository Post { get; }
        ICategoryRepository Category { get; }
        int Complete();
    }
}