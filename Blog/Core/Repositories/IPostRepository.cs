using Blog.Core.Domain;


namespace Blog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetPostWithComment(int pageIndex, int pageSize);
    }
}